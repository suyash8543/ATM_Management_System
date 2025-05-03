
using System.Windows.Forms;

namespace ATM_Management_System
{
    partial class account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            Accnotb = new TextBox();
            Nametb = new TextBox();
            Fnametb = new TextBox();
            Addresstb = new TextBox();
            Phonetb = new TextBox();
            Pintb = new TextBox();
            label13 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            Occupationtb = new TextBox();
            label7 = new Label();
            Dobtp = new DateTimePicker();
            label9 = new Label();
            Educationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1178, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 48);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(284, 38);
            label1.Name = "label1";
            label1.Size = new Size(563, 48);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(108, 213);
            label5.Name = "label5";
            label5.Size = new Size(135, 41);
            label5.TabIndex = 18;
            label5.Text = "Acc no. :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(108, 329);
            label3.Name = "label3";
            label3.Size = new Size(124, 41);
            label3.TabIndex = 19;
            label3.Text = "NAME :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(108, 439);
            label4.Name = "label4";
            label4.Size = new Size(140, 41);
            label4.TabIndex = 20;
            label4.Text = "FNAME :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(108, 541);
            label6.Name = "label6";
            label6.Size = new Size(169, 41);
            label6.TabIndex = 21;
            label6.Text = "ADDRESS :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(675, 439);
            label8.Name = "label8";
            label8.Size = new Size(138, 41);
            label8.TabIndex = 27;
            label8.Text = "PHONE :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(675, 517);
            label10.Name = "label10";
            label10.Size = new Size(226, 41);
            label10.TabIndex = 25;
            label10.Text = "OCCUPATION :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(675, 213);
            label12.Name = "label12";
            label12.Size = new Size(86, 41);
            label12.TabIndex = 23;
            label12.Text = "PIN :";
            // 
            // Accnotb
            // 
            Accnotb.Font = new Font("Segoe UI", 12F);
            Accnotb.Location = new Point(313, 227);
            Accnotb.Name = "Accnotb";
            Accnotb.Size = new Size(250, 34);
            Accnotb.TabIndex = 28;
            // 
            // Nametb
            // 
            Nametb.Font = new Font("Segoe UI", 12F);
            Nametb.Location = new Point(313, 343);
            Nametb.Name = "Nametb";
            Nametb.Size = new Size(250, 34);
            Nametb.TabIndex = 29;
            // 
            // Fnametb
            // 
            Fnametb.Font = new Font("Segoe UI", 12F);
            Fnametb.Location = new Point(313, 446);
            Fnametb.Name = "Fnametb";
            Fnametb.Size = new Size(250, 34);
            Fnametb.TabIndex = 30;
            // 
            // Addresstb
            // 
            Addresstb.Location = new Point(313, 553);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(250, 86);
            Addresstb.TabIndex = 31;
            // 
            // Phonetb
            // 
            Phonetb.Font = new Font("Segoe UI", 12F);
            Phonetb.Location = new Point(936, 439);
            Phonetb.Name = "Phonetb";
            Phonetb.Size = new Size(250, 34);
            Phonetb.TabIndex = 32;
            // 
            // Pintb
            // 
            Pintb.Font = new Font("Segoe UI", 12F);
            Pintb.Location = new Point(927, 220);
            Pintb.Name = "Pintb";
            Pintb.Size = new Size(250, 34);
            Pintb.TabIndex = 33;
            Pintb.Text = " ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(579, 775);
            label13.Name = "label13";
            label13.Size = new Size(118, 41);
            label13.TabIndex = 38;
            label13.Text = "Signup";
            label13.Click += label13_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(544, 713);
            button1.Name = "button1";
            button1.Size = new Size(181, 49);
            button1.TabIndex = 39;
            button1.Text = " LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 861);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 14);
            panel2.TabIndex = 40;
            // 
            // Occupationtb
            // 
            Occupationtb.Font = new Font("Segoe UI", 12F);
            Occupationtb.Location = new Point(936, 517);
            Occupationtb.Name = "Occupationtb";
            Occupationtb.Size = new Size(250, 34);
            Occupationtb.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(675, 598);
            label7.Name = "label7";
            label7.Size = new Size(98, 41);
            label7.TabIndex = 42;
            label7.Text = "DOB :";
            // 
            // Dobtp
            // 
            Dobtp.CustomFormat = "yyyy/mm/dd";
            Dobtp.Font = new Font("Segoe UI", 12F);
            Dobtp.Format = DateTimePickerFormat.Short;
            Dobtp.Location = new Point(936, 598);
            Dobtp.Name = "Dobtp";
            Dobtp.Size = new Size(250, 34);
            Dobtp.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(675, 329);
            label9.Name = "label9";
            label9.Size = new Size(207, 41);
            label9.TabIndex = 44;
            label9.Text = "EDUCATION :";
            // 
            // Educationtb
            // 
            Educationtb.Font = new Font("Segoe UI", 12F);
            Educationtb.Location = new Point(927, 329);
            Educationtb.Name = "Educationtb";
            Educationtb.Size = new Size(250, 34);
            Educationtb.TabIndex = 29;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 875);
            Controls.Add(Educationtb);
            Controls.Add(label9);
            Controls.Add(Dobtp);
            Controls.Add(label7);
            Controls.Add(Occupationtb);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(Pintb);
            Controls.Add(Phonetb);
            Controls.Add(Addresstb);
            Controls.Add(Fnametb);
            Controls.Add(Nametb);
            Controls.Add(Accnotb);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            Load += account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Dobtp.Value;
            // Add your logic using selectedDate
            MessageBox.Show("Selected date: " + selectedDate.ToString("d"));
        
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private Label label10;
        private Label label12;
        private TextBox Accnotb;
        private TextBox Nametb;
        private TextBox Fnametb;
        private TextBox Addresstb;
        private TextBox Phonetb;
        private TextBox Pintb;
        private Label label13;
        private Button button1;
        private Panel panel2;
        private TextBox Occupationtb;
        private Label label7;
        private System.Windows.Forms.DateTimePicker Dobtp;

        private void InitializeComponent1()
        {
            this.Dobtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.Dobtp.Location = new System.Drawing.Point(20, 20);
            this.Dobtp.Name = "dateTimePicker1";
            this.Dobtp.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.Dobtp);
            // 
            // Other controls initialization...
            // 
            this.ResumeLayout(false);
        }

        private Label label9;
        private TextBox Educationtb;
    }
}