namespace ATM_Management_System
{
    partial class balance
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
            Accnumlbl = new Label();
            balancelbl = new Label();
            panel2 = new Panel();
            label7 = new Label();
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
            panel1.Size = new Size(712, 125);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(666, 0);
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
            label1.Location = new Point(74, 35);
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
            label5.Location = new Point(42, 280);
            label5.Name = "label5";
            label5.Size = new Size(213, 41);
            label5.TabIndex = 19;
            label5.Text = "Your Balance :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(42, 188);
            label3.Name = "label3";
            label3.Size = new Size(267, 41);
            label3.TabIndex = 20;
            label3.Text = "Account number :";
            // 
            // Accnumlbl
            // 
            Accnumlbl.AutoSize = true;
            Accnumlbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Accnumlbl.ForeColor = Color.DarkSlateGray;
            Accnumlbl.Location = new Point(363, 188);
            Accnumlbl.Name = "Accnumlbl";
            Accnumlbl.Size = new Size(127, 41);
            Accnumlbl.TabIndex = 21;
            Accnumlbl.Text = "Acc no. ";
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            balancelbl.ForeColor = Color.DarkSlateGray;
            balancelbl.Location = new Point(363, 280);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(186, 41);
            balancelbl.TabIndex = 22;
            balancelbl.Text = "BalanceinRs";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 17);
            panel2.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(314, 385);
            label7.Name = "label7";
            label7.Size = new Size(67, 32);
            label7.TabIndex = 24;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(balancelbl);
            Controls.Add(Accnumlbl);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "balance";
            Load += balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label Accnumlbl;
        private Label balancelbl;
        private Panel panel2;
        private Label label7;
    }
}