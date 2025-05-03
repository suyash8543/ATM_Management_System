namespace ATM_Management_System
{
    partial class Deposit
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
            label3 = new Label();
            depoamttb = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label4 = new Label();
            panel2 = new Panel();
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
            panel1.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(84, 246);
            label3.Name = "label3";
            label3.Size = new Size(171, 41);
            label3.TabIndex = 27;
            label3.Text = "AMOUNT :";
            // 
            // depoamttb
            // 
            depoamttb.Font = new Font("Segoe UI", 14F);
            depoamttb.Location = new Point(310, 246);
            depoamttb.Name = "depoamttb";
            depoamttb.Size = new Size(262, 39);
            depoamttb.TabIndex = 28;
            depoamttb.Text = "Enter the Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(391, 394);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 32;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(310, 342);
            button1.Name = "button1";
            button1.Size = new Size(262, 39);
            button1.TabIndex = 31;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(229, 140);
            label4.Name = "label4";
            label4.Size = new Size(196, 48);
            label4.TabIndex = 33;
            label4.Text = "DEPOSIT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 17);
            panel2.TabIndex = 34;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(depoamttb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox depoamttb;
        private Label label7;
        private Button button1;
        private Label label4;
        private Panel panel2;
    }
}