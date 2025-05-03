namespace ATM_Management_System
{
    partial class Home
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            Accountlbl = new Label();
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
            panel1.Size = new Size(979, 80);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(923, 0);
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
            label1.Location = new Point(154, 18);
            label1.Name = "label1";
            label1.Size = new Size(670, 48);
            label1.TabIndex = 1;
            label1.Text = "Select Your Transaction Please";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(67, 150);
            button1.Name = "button1";
            button1.Size = new Size(325, 49);
            button1.TabIndex = 9;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(585, 150);
            button2.Name = "button2";
            button2.Size = new Size(325, 49);
            button2.TabIndex = 10;
            button2.Text = "WITHDRAW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(67, 265);
            button3.Name = "button3";
            button3.Size = new Size(325, 49);
            button3.TabIndex = 11;
            button3.Text = "FASTCASH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(67, 384);
            button4.Name = "button4";
            button4.Size = new Size(325, 49);
            button4.TabIndex = 12;
            button4.Text = "CHANGE PIN";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(585, 265);
            button6.Name = "button6";
            button6.Size = new Size(325, 49);
            button6.TabIndex = 14;
            button6.Text = "MINI STATEMENT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkSlateGray;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(585, 384);
            button7.Name = "button7";
            button7.Size = new Size(325, 49);
            button7.TabIndex = 15;
            button7.Text = "BALANCE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 530);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 13);
            panel2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(427, 470);
            label5.Name = "label5";
            label5.Size = new Size(139, 41);
            label5.TabIndex = 17;
            label5.Text = "LOGOUT";
            label5.Click += label5_Click;
            // 
            // Accountlbl
            // 
            Accountlbl.AutoSize = true;
            Accountlbl.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            Accountlbl.ForeColor = Color.DarkSlateGray;
            Accountlbl.Location = new Point(309, 83);
            Accountlbl.Name = "Accountlbl";
            Accountlbl.Size = new Size(378, 48);
            Accountlbl.TabIndex = 3;
            Accountlbl.Text = "Account Number";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 543);
            Controls.Add(Accountlbl);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Panel panel2;
        private Label label5;
        private Label Accountlbl;
    }
}