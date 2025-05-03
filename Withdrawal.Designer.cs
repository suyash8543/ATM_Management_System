namespace ATM_Management_System
{
    partial class Withdrawal
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
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label7 = new Label();
            button1 = new Button();
            wtamttb = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            balancelbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 125);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(666, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 48);
            label3.TabIndex = 2;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateGray;
            label4.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(74, 35);
            label4.Name = "label4";
            label4.Size = new Size(563, 48);
            label4.TabIndex = 2;
            label4.Text = "ATM Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(246, 139);
            label1.Name = "label1";
            label1.Size = new Size(271, 48);
            label1.TabIndex = 38;
            label1.Text = "WITHDRAW";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(408, 393);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 37;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(327, 341);
            button1.Name = "button1";
            button1.Size = new Size(262, 39);
            button1.TabIndex = 36;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // wtamttb
            // 
            wtamttb.Font = new Font("Segoe UI", 14F);
            wtamttb.Location = new Point(327, 267);
            wtamttb.Name = "wtamttb";
            wtamttb.Size = new Size(262, 39);
            wtamttb.TabIndex = 35;
            wtamttb.Text = "Enter the Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(95, 267);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 34;
            label2.Text = "AMOUNT :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 17);
            panel2.TabIndex = 39;
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            balancelbl.ForeColor = Color.DarkSlateGray;
            balancelbl.Location = new Point(281, 201);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(264, 41);
            balancelbl.TabIndex = 40;
            balancelbl.Text = "Available Balance";
            // 
            // Withdrawal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(balancelbl);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(wtamttb);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Withdrawal";
            Text = "Withdrawal";
            Load += Withdrawal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label7;
        private Button button1;
        private TextBox wtamttb;
        private Label label2;
        private Panel panel2;
        private Label balancelbl;
    }
}