using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wifi_qr_generator
{
    public partial class Form_printQR : Form
    {
        private PrintDocument printDocument;
        public Image QRCodeImage { get; set; }
        public string TextBox1Text { get; set; }
        public string TextBox2Text { get; set; }

        public Form_printQR()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void Form_printQR_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = QRCodeImage;
            label1.Text = "WiFi SSID: " + TextBox1Text;
            label2.Text = "WiFi Password: " + TextBox2Text;
            label3.Text = "Date Generated: " + DateTime.Now.ToString("MM/dd/yyyy");

            // Show the print dialog
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Start printing
                    printDocument.Print();
                }
                else
                {
                    // Cancelled by the user, close the form
                    this.Close();
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Calculate the printable area
            Rectangle printBounds = e.MarginBounds;

            // Iterate through the controls and draw each control onto the print page
            foreach (Control control in this.Controls)
            {
                using (Bitmap bitmap = new Bitmap(control.Width, control.Height))
                {
                    control.DrawToBitmap(bitmap, new Rectangle(Point.Empty, control.Size));
                    e.Graphics.DrawImage(bitmap, control.Location.X + printBounds.Left, control.Location.Y + printBounds.Top);
                }
            }


        }
    }
}
