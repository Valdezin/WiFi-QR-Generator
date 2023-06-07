namespace wifi_qr_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.rb_wpa = new System.Windows.Forms.RadioButton();
            this.rb_wep = new System.Windows.Forms.RadioButton();
            this.h_yes = new System.Windows.Forms.RadioButton();
            this.h_no = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wifi_qr_generator.Properties.Resources.qr_placeholder1;
            this.pictureBox1.Location = new System.Drawing.Point(202, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(1, 3);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(66, 24);
            this.rb_none.TabIndex = 4;
            this.rb_none.Text = "None";
            this.rb_none.UseVisualStyleBackColor = true;
            this.rb_none.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_wpa
            // 
            this.rb_wpa.AutoSize = true;
            this.rb_wpa.Checked = true;
            this.rb_wpa.Location = new System.Drawing.Point(73, 3);
            this.rb_wpa.Name = "rb_wpa";
            this.rb_wpa.Size = new System.Drawing.Size(151, 24);
            this.rb_wpa.TabIndex = 5;
            this.rb_wpa.TabStop = true;
            this.rb_wpa.Text = "WPA/WPA2/WPA3";
            this.rb_wpa.UseVisualStyleBackColor = true;
            this.rb_wpa.CheckedChanged += new System.EventHandler(this.rb_wpa_CheckedChanged);
            // 
            // rb_wep
            // 
            this.rb_wep.AutoSize = true;
            this.rb_wep.Location = new System.Drawing.Point(230, 3);
            this.rb_wep.Name = "rb_wep";
            this.rb_wep.Size = new System.Drawing.Size(60, 24);
            this.rb_wep.TabIndex = 6;
            this.rb_wep.Text = "WEP";
            this.rb_wep.UseVisualStyleBackColor = true;
            this.rb_wep.CheckedChanged += new System.EventHandler(this.rb_wep_CheckedChanged);
            // 
            // h_yes
            // 
            this.h_yes.AutoSize = true;
            this.h_yes.Location = new System.Drawing.Point(0, 3);
            this.h_yes.Name = "h_yes";
            this.h_yes.Size = new System.Drawing.Size(51, 24);
            this.h_yes.TabIndex = 7;
            this.h_yes.Text = "Yes";
            this.h_yes.UseVisualStyleBackColor = true;
            // 
            // h_no
            // 
            this.h_no.AutoSize = true;
            this.h_no.Checked = true;
            this.h_no.Location = new System.Drawing.Point(0, 33);
            this.h_no.Name = "h_no";
            this.h_no.Size = new System.Drawing.Size(50, 24);
            this.h_no.TabIndex = 8;
            this.h_no.TabStop = true;
            this.h_no.Text = "No";
            this.h_no.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Security";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hidden?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(-29, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(612, 79);
            this.button1.TabIndex = 13;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(202, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(168, 321);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-11, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(579, 73);
            this.button2.TabIndex = 19;
            this.button2.Text = "SAVE QR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_none);
            this.panel1.Controls.Add(this.rb_wep);
            this.panel1.Controls.Add(this.rb_wpa);
            this.panel1.Location = new System.Drawing.Point(168, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 41);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.h_yes);
            this.panel2.Controls.Add(this.h_no);
            this.panel2.Location = new System.Drawing.Point(168, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 88);
            this.panel2.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "PRINT QR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiFi QR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private RadioButton rb_none;
        private RadioButton rb_wpa;
        private RadioButton rb_wep;
        private RadioButton h_yes;
        private RadioButton h_no;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
    }
}