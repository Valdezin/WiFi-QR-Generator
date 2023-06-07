using System.ComponentModel;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace wifi_qr_generator
{
    public partial class Form1 : Form
    {
        
        string type_security = "";
        string type_hidden = "";
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = !rb_none.Checked;
            checkBox1.Enabled = !rb_none.Checked;
            checkBox1.Text = "Disabled";
            textBox2.Text = "";
        }

        public void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a SSID");
                return;
            }

            if (rb_wep.Checked)
            {
                type_security = "WEP";
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please enter a password");
                    return;
                }
                else if (textBox2.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters");
                    return;
                }
                }
            else if (rb_wpa.Checked)
            {
                type_security = "WPA";
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please enter a password");
                    return;
                }
                else if (textBox2.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters");
                    return;
                }
            }
            else if (rb_none.Checked)
            {
                type_security = "nopass";
            }

            else
            {
                MessageBox.Show("Please select a security type");
            }

            if (h_yes.Checked)
            {
                type_hidden = "true";
            }
            else if (h_no.Checked)
            {
                type_hidden = "false";
            }

            else
            {
                    MessageBox.Show("Please select if the SSID is Hidden");
            }


                string qrdata = "WIFI:S:" + textBox1.Text + ";T:" + type_security + ";P:" + textBox2.Text + ";H:" + type_hidden + ";";

            MessagingToolkit.QRCode.Codec.QRCodeEncoder qrcode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            pictureBox1.Image = qrcode.Encode(qrdata);
            pictureBox2.Image = pictureBox1.Image;
            button2.Enabled = true;

            button3.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text + "_wifiqrcode";
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("No WiFi QR Code to save!");
                }
                else
                {
                    saveFileDialog.FileName = name;
                    saveFileDialog.ShowDialog();
                    pictureBox2.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel1.Focus();
                e.Handled = true;
            }
        }

        private void rb_wpa_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Show Password";
        }

        private void rb_wep_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Show Password";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string qrData = "WIFI:S:" + textBox1.Text + ";T:" + type_security + ";P:" + textBox2.Text + ";H:" + type_hidden + ";";

            MessagingToolkit.QRCode.Codec.QRCodeEncoder qrcode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            Image qrCodeImage = qrcode.Encode(qrData);

            Form_printQR printQR = new Form_printQR();
            printQR.QRCodeImage = qrCodeImage;
            printQR.TextBox1Text = textBox1.Text;
            printQR.TextBox2Text = textBox2.Text;
            printQR.Show();
            this.Hide();
        }
    }
}