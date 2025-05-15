using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
//using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

// alias đúng
using PdfFont = iTextSharp.text.Font;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantManagementSystem
{
    public partial class staffTableStatusUC : UserControl
    {

        Database db = new Database();
        public staffTableStatusUC()
        {
            InitializeComponent();
            LoadTables();

        }
        private void GenerateInvoicePdf(int tableId, int idBooking, decimal totalAmount)
        {

            string cnn = db.Connectstring();
            string customerName = "", phone = "-";
            DataTable order = new DataTable();

            using (SqlConnection conn = new SqlConnection(cnn))
            {
                conn.Open();

                string infoSql = @"SELECT t.name, t.phone
                           FROM Tables t
                           JOIN BookingKey bk ON t.idTable = bk.idTable
                           WHERE t.idTable = @tbl";
                using (SqlCommand cmd = new SqlCommand(infoSql, conn))
                {
                    cmd.Parameters.AddWithValue("@tbl", tableId);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            customerName = rd.IsDBNull(0) ? "Guest" : rd.GetString(0);
                            phone = rd.IsDBNull(1) ? "-" : rd.GetString(1);
                        }
                    }
                }

                string orderSql = @"SELECT d.Name, td.quantity, td.price
                            FROM TableDetail td
                            JOIN Dish d ON td.dishID = d.Id
                            WHERE td.idBooking = @bk";
                using (SqlDataAdapter ad = new SqlDataAdapter(orderSql, conn))
                {
                    ad.SelectCommand.Parameters.AddWithValue("@bk", idBooking);
                    ad.Fill(order);
                }
            }

            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Invoices");
            Directory.CreateDirectory(folder);

            string filePath = Path.Combine(
                folder, $"Invoice_Table{tableId}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            Document doc = new Document(PageSize.A5, 30, 30, 20, 20);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            PdfFont titleFont = FontFactory.GetFont("Helvetica", 16, PdfFont.BOLD);
            PdfFont normal = FontFactory.GetFont("Helvetica", 11);
            PdfFont bold = FontFactory.GetFont("Helvetica", 11, PdfFont.BOLD);

            Paragraph header = new Paragraph("RESTAURANT INVOICE\n", titleFont)
            { Alignment = Element.ALIGN_CENTER };
            doc.Add(header);
            doc.Add(new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy HH:mm}", normal));
            doc.Add(new Paragraph($"Table: {tableId}", normal));
            doc.Add(new Paragraph($"Customer: {customerName}", normal));
            doc.Add(new Paragraph($"Phone: {phone}\n", normal));
            doc.Add(new Paragraph("\n", normal));

            PdfPTable tbl = new PdfPTable(4) { WidthPercentage = 100 };
            tbl.SetWidths(new float[] { 40, 15, 20, 25 });

            void Cell(string txt, PdfFont f, int align = Element.ALIGN_LEFT)
            {
                PdfPCell c = new PdfPCell(new Phrase(txt, f))
                {
                    HorizontalAlignment = align,
                    Padding = 5
                };
                tbl.AddCell(c);
            }

            Cell("Dish", bold);
            Cell("Qty", bold, Element.ALIGN_CENTER);
            Cell("Unit", bold, Element.ALIGN_RIGHT);
            Cell("Total", bold, Element.ALIGN_RIGHT);

            foreach (DataRow row in order.Rows)
            {
                string dish = row["Name"].ToString();
                int qty = Convert.ToInt32(row["quantity"]);
                decimal tot = Convert.ToDecimal(row["price"]);
                decimal unit = tot / qty;

                Cell(dish, normal);
                Cell(qty.ToString(), normal, Element.ALIGN_CENTER);
                Cell(unit.ToString("C"), normal, Element.ALIGN_RIGHT);
                Cell(tot.ToString("C"), normal, Element.ALIGN_RIGHT);
            }

            PdfPCell blank = new PdfPCell(new Phrase("")) { Colspan = 3, Border = 0 };
            tbl.AddCell(blank);
            Cell(totalAmount.ToString("C"), bold, Element.ALIGN_RIGHT);

            doc.Add(tbl);

            doc.Add(new Paragraph("\nThank you and see you again!", normal)
            { Alignment = Element.ALIGN_CENTER });

            doc.Close();

            Process.Start(filePath);
        }

        private int GetBookingIdByTable(int tableId)
        {
            string connectionString = db.Connectstring();
            string query = "SELECT TOP 1 idBooking FROM BookingKey WHERE idTable = @idTable ORDER BY time DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idTable", tableId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No booking ID found for this table.");
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving idBooking from idTable " + ex.Message);
                return -1;
            }
        }

        private void LoadTables()
        {
            tablePanel.Controls.Clear();
            DataTable tableData = GetTablesData();
            if (tableData == null) return;

            foreach (DataRow row in tableData.Rows)
            {
                int id = Convert.ToInt32(row["idTable"]);
                string status = row["status"].ToString();
                tableUC tableItem = new tableUC();
                tableItem.SetTableID(id);
                tableItem.SetStatus(status == "Full");


                tableItem.OnTableSelected += (s, e) =>
                {
                    foreach (tableUC item in tablePanel.Controls)
                    {
                        item.SetSelected(false);
                    }
                    tableItem.SetSelected(true);
                    LoadTableDetails(id);
                };
                tablePanel.Controls.Add(tableItem);
            }
        }

        private DataTable GetTablesData()
        {
            string connectionString = db.Connectstring();
            string query = "SELECT idTable, status FROM Tables";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tables: " + ex.Message);
                return null;
            }
        }
        private DataTable GetOrderList(int idBooking)
        {
            string connectionString = db.Connectstring();
            string query = @"
                            SELECT 
                                d.Id AS dishID,
                                d.Name,
                                SUM(td.quantity) AS quantity,
                                SUM(td.price) AS price
                            FROM TableDetail td
                            JOIN Dish d ON td.dishID = d.Id
                            WHERE td.idBooking = @idBooking
                            GROUP BY d.Id, d.Name";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order list: " + ex.Message);
                return null;
            }
        }

        private void LoadTableDetails(int tableId)
        {
            detailPanel.Controls.Clear();
            int idBooking = GetBookingIdByTable(tableId);
            if (idBooking == -1) return;

            decimal totalAmount = GetTotalAmount(idBooking);

            totalLabel.Text = totalAmount.ToString("C");
        }
        private decimal GetTotalAmount(int idBooking)
        {
            DataTable orderData = GetOrderList(idBooking);
            if (orderData == null) return 0;

            decimal totalAmount = 0;

            foreach (DataRow row in orderData.Rows)
            {
                string name = row["Name"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                decimal totalPrice = Convert.ToDecimal(row["price"]);

                decimal unitPrice = totalPrice / quantity;

                showTableDetailUC detailItem = new showTableDetailUC();
                int dishID = Convert.ToInt32(row["dishID"]);
                detailItem.SetData(name, quantity, unitPrice, dishID);
                detailPanel.Controls.Add(detailItem);

                totalAmount += totalPrice;
            }

            return totalAmount;
        }

        private int GetSelectedTableId()
        {
            if (tablePanel.Controls.Count > 0)
            {
                foreach (tableUC tableItem in tablePanel.Controls)
                {
                    if (tableItem.IsSelected)
                    {
                        return tableItem.TableID;
                    }
                }
            }
            return -1;
        }
        private void ClearTableData(int tableId)
        {
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    int idBooking = GetBookingIdByTable(tableId);
                    if (idBooking == -1) return;


                    string deleteDetailQuery = "DELETE FROM TableDetail WHERE idBooking = @idBooking";
                    using (SqlCommand deleteDetailCmd = new SqlCommand(deleteDetailQuery, conn))
                    {
                        deleteDetailCmd.Parameters.AddWithValue("@idBooking", idBooking);
                        deleteDetailCmd.ExecuteNonQuery();
                    }


                    string deleteBookingQuery = "DELETE FROM BookingKey WHERE idBooking = @idBooking";
                    using (SqlCommand deleteBookingCmd = new SqlCommand(deleteBookingQuery, conn))
                    {
                        deleteBookingCmd.Parameters.AddWithValue("@idBooking", idBooking);
                        deleteBookingCmd.ExecuteNonQuery();
                    }


                    string updateTableQuery = "UPDATE Tables SET name = NULL, phone = NULL, time = NULL, personNumber = 0, price = 0, status = 'Empty' WHERE idTable = @idTable";
                    using (SqlCommand updateTableCmd = new SqlCommand(updateTableQuery, conn))
                    {
                        updateTableCmd.Parameters.AddWithValue("@idTable", tableId);
                        updateTableCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Payment successful! The table has been cleaned and is ready to serve the next customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during payment:" + ex.Message);
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            int selectedTableId = GetSelectedTableId();
            if (selectedTableId == -1)
            {
                MessageBox.Show("Please select a table to proceed with payment.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to pay for this table?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idBooking = GetBookingIdByTable(selectedTableId);
                decimal totalAmount = GetTotalAmount(idBooking);
                DateTime? dt = GetBookingTimeByTable(selectedTableId);

                AddPaymentToThanhToan(idBooking, selectedTableId, totalAmount, dt);
                GenerateInvoicePdf(selectedTableId, idBooking, totalAmount);
                AddToUsedIngredient(selectedTableId);
                ClearTableData(selectedTableId);
                LoadTables();
                detailPanel.Controls.Clear();
                totalLabel.Text = "0 VND";
            }
        }

        private void AddPaymentToThanhToan(int idBooking, int idTable, decimal totalAmount, DateTime? bookingTime)
        {
            string connectionString = db.Connectstring();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string costQuery = "SELECT SUM(Quantity * Price) FROM UsedIngredient WHERE idTable = @idTable";
                    SqlCommand costCmd = new SqlCommand(costQuery, conn);
                    costCmd.Parameters.AddWithValue("@idTable", idTable);
                    object result = costCmd.ExecuteScalar();
                    decimal ingredientCost = (result != DBNull.Value && result != null) ? Convert.ToDecimal(result) : 0;


                    string query = @"INSERT INTO PaymentHistory 
                             (idBooking, idTable, totalAmount, bookingTime, ingredientCost)
                             VALUES (@idBooking, @idTable, @totalAmount, @bookingTime, @ingredientCost)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);
                    cmd.Parameters.AddWithValue("@idTable", idTable);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@bookingTime", bookingTime);
                    cmd.Parameters.AddWithValue("@ingredientCost", ingredientCost);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private DateTime? GetBookingTimeByTable(int idTable)
        {
            string connectionString = db.Connectstring();
            string query = "SELECT time FROM BookingKey WHERE idTable = @idTable";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idTable", idTable);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToDateTime(result);
                    }
                    else
                    {
                        MessageBox.Show("No booking time found for this table ID.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error querying booking time: " + ex.Message);
                return null;
            }
        }

        private void AddToUsedIngredient(int idTable)
        {
            string connectionString = db.Connectstring();
            string selectQuery = @"
        SELECT 
            d.Name AS DishName,
            i.Id AS IngredientID,
            i.Name AS IngredientName,
            (dia.QuantityRequired * td.quantity) AS TotalQuantityRequired,
            i.Price AS IngredientPrice,
            td.quantity AS TableQuantity
        FROM 
            Tables t
            JOIN BookingKey bk ON t.idTable = bk.idTable
            JOIN TableDetail td ON bk.idBooking = td.idBooking
            JOIN Dish d ON td.dishID = d.Id
            JOIN DishIngredientAssignment dia ON d.Id = dia.DishID
            JOIN Ingredient i ON dia.IngredientID = i.Id
        WHERE 
            t.idTable = @idTable";

            string insertQuery = @"
        INSERT INTO UsedIngredient (idTable, DishName, Name, Quantity, Price, Amount, UsedTime)
        VALUES (@idTable, @DishName, @Name, @Quantity, @Price, @Amount, GETDATE())";

            string updateIngredientQuery = @"
        UPDATE Ingredient
        SET Quantity = Quantity - @UsedQuantity
        WHERE Id = @IngredientID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand selectCmd = new SqlCommand(selectQuery, conn, transaction);
                            selectCmd.Parameters.AddWithValue("@idTable", idTable);

                            SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                string dishName = row["DishName"].ToString();
                                string ingredientName = row["IngredientName"].ToString();
                                int ingredientId = Convert.ToInt32(row["IngredientID"]);
                                decimal quantity = Convert.ToDecimal(row["TotalQuantityRequired"]);
                                decimal price = Convert.ToDecimal(row["IngredientPrice"]);
                                int tableQuantity = Convert.ToInt32(row["TableQuantity"]);

                                int amount = tableQuantity;

                                // Insert UsedIngredient
                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("@idTable", idTable);
                                    insertCmd.Parameters.AddWithValue("@DishName", dishName);
                                    insertCmd.Parameters.AddWithValue("@Name", ingredientName);
                                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                                    insertCmd.Parameters.AddWithValue("@Price", price);
                                    insertCmd.Parameters.AddWithValue("@Amount", amount);
                                    insertCmd.ExecuteNonQuery();
                                }

                                // Update trừ kho Ingredient
                                using (SqlCommand updateCmd = new SqlCommand(updateIngredientQuery, conn, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@UsedQuantity", quantity);
                                    updateCmd.Parameters.AddWithValue("@IngredientID", ingredientId);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error adding ingredients and updating stock: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }

    }
}
