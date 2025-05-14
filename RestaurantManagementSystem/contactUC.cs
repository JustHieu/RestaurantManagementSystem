using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class contactUC : UserControl
    {
        public contactUC()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://www.google.com/maps/place/Landmark+81/@10.7926796,106.7212942,1534m/data=!3m1!1e3!4m6!3m5!1s0x317527c2f8f30911:0x36ac5073f8c91acd!8m2!3d10.7951119!4d106.722096!16s%2Fm%2F012hcpml?entry=ttu&g_ep=EgoyMDI1MDMxMi4wIKXMDSoASAFQAw%3D%3D");
            this.Controls.Add(webView21);
            address.MouseEnter += Address_MouseEnter;
            address.MouseLeave += Address_MouseLeave;
            guna2PictureBox2.MouseEnter += (s, e) => ZoomIn(guna2PictureBox2);
            guna2PictureBox2.MouseLeave += (s, e) => ZoomOut(guna2PictureBox2);
            guna2PictureBox3.MouseEnter += (s, e) => ZoomIn(guna2PictureBox3);
            guna2PictureBox3.MouseLeave += (s, e) => ZoomOut(guna2PictureBox3);
            guna2PictureBox4.MouseEnter += (s, e) => ZoomIn(guna2PictureBox4);
            guna2PictureBox4.MouseLeave += (s, e) => ZoomOut(guna2PictureBox4);
            this.Resize += (s, e) =>
            {
                ApplyRoundedCorners(webView21);
            };

            ApplyRoundedCorners(webView21);
        }

        private void address_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Landmark+81/@10.7926796,106.7212942,1534m/data=!3m1!1e3!4m6!3m5!1s0x317527c2f8f30911:0x36ac5073f8c91acd!8m2!3d10.7951119!4d106.722096!16s%2Fm%2F012hcpml?entry=ttu&g_ep=EgoyMDI1MDMxMi4wIKXMDSoASAFQAw%3D%3D");
        }
        private void Address_MouseEnter(object sender, EventArgs e)
        {

            address.ForeColor = Color.FromArgb(239, 116, 43);
        }

        private void Address_MouseLeave(object sender, EventArgs e)
        {
            address.ForeColor = Color.White;
        }
        private void ZoomIn(PictureBox pic)
        {
            pic.Size = new Size((int)(pic.Width * 1.1), (int)(pic.Height * 1.1)); 
            pic.Location = new Point(pic.Location.X - (int)(pic.Width * 0.05), pic.Location.Y - (int)(pic.Height * 0.05)); // Giữ tâm
        }

        private void ZoomOut(PictureBox pic)
        {
            pic.Size = new Size((int)(pic.Width / 1.1), (int)(pic.Height / 1.1)); 
            pic.Location = new Point(pic.Location.X + (int)(pic.Width * 0.05), pic.Location.Y + (int)(pic.Height * 0.05)); 
        }
        private void ApplyRoundedCorners(WebView2 webView)
        {

            using (GraphicsPath path = new GraphicsPath())
            {
                int cornerRadius = 30; 
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); 
                path.AddArc(webView.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90); 
                path.AddArc(webView.Width - cornerRadius - 1, webView.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90); 
                path.AddArc(0, webView.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90); 
                path.CloseFigure();

                webView.Region = new Region(path);
            }
        }
    }
}
