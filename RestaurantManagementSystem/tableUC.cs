using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RestaurantManagementSystem
{
    public partial class tableUC : UserControl
    {
        private bool _hasCustomer = false; // Lưu trạng thái bàn (có người: true, trống: false)
        public void SetTableStatus(string status)
        {
            // status: "Full" hoặc "Empty" (lấy từ DB)
            _hasCustomer = status.Equals("Full", StringComparison.OrdinalIgnoreCase);
            panelStatus.Invalidate(); // Gọi vẽ lại panel
        }

        public void SetTableID(int id)
        {
            TableID = id;
            idTableLabel.Text = "Table " + id.ToString();
            LoadTableStatusFromDB();
        }
        private void LoadTableStatusFromDB()
        {
            try
            {
                // Sử dụng Database class riêng của bạn hoặc viết chuỗi kết nối tại đây
                Database db = new Database();
                string connectionString = db.Connectstring();
                string query = "SELECT status FROM Tables WHERE idTable = @idTable";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idTable", this.TableID);
                    string status = cmd.ExecuteScalar()?.ToString() ?? "Empty";
                    SetTableStatus(status); // Cập nhật panel trạng thái ngay
                }
            }
            catch (Exception ex)
            {
                // Có thể hiển thị trạng thái mặc định hoặc báo lỗi
                SetTableStatus("Empty");
            }
        }


        public int TableID { get; private set; }
        public event EventHandler OnTableSelected;
        public bool IsSelected { get; private set; }

        public void SetSelected(bool selected)
        {
            IsSelected = selected;
            this.BackColor = selected ? Color.Black : Color.Black;  // Đổi màu để biết bàn đang được chọn
        }
        // Hàm này sẽ được gọi tự động khi panelStatus vẽ lại
        private void panelStatus_Paint(object sender, PaintEventArgs e)
        {
            bool hasCustomer = this._hasCustomer; // Biến này sẽ set theo trạng thái bàn
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ nền panel: đỏ hoặc xanh lá
            Color bgColor = hasCustomer ? Color.Red : Color.LimeGreen;
            using (SolidBrush br = new SolidBrush(bgColor))
                g.FillRectangle(br, 0, 0, panelStatus.Width, panelStatus.Height);

            // Vẽ hình tròn trắng (nút trượt)
            int diameter = panelStatus.Height - 8;
            int y = 4;
            int x = hasCustomer ? panelStatus.Width - diameter - 4 : 4;
            using (SolidBrush br = new SolidBrush(Color.White))
                g.FillEllipse(br, x, y, diameter, diameter);
        }


        public tableUC()
        {
            InitializeComponent();
            panelStatus.Paint += panelStatus_Paint;
        }


        private void table11Button_Click(object sender, EventArgs e)
        {
          
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SetSelected(true);
            OnTableSelected?.Invoke(this, EventArgs.Empty);
        }

        private void tableUC_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
