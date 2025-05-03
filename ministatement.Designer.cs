namespace ATM_Management_System
{
    partial class ministatement
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
            panel2 = new Panel();
            label7 = new Label();
            MinistatementDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementDGV).BeginInit();
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
            panel1.Size = new Size(920, 125);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(864, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 48);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateGray;
            label4.Font = new Font("Gill Sans Ultra Bold", 19.8000011F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(142, 39);
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
            label1.Location = new Point(246, 128);
            label1.Name = "label1";
            label1.Size = new Size(374, 48);
            label1.TabIndex = 40;
            label1.Text = "MINI STATEMENT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 17);
            panel2.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(414, 495);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 43;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // MinistatementDGV
            // 
            MinistatementDGV.BackgroundColor = SystemColors.Control;
            MinistatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MinistatementDGV.Location = new Point(0, 168);
            MinistatementDGV.Name = "MinistatementDGV";
            MinistatementDGV.RowHeadersWidth = 51;
            MinistatementDGV.Size = new Size(920, 324);
            MinistatementDGV.TabIndex = 45;
            MinistatementDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ministatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 545);
            Controls.Add(MinistatementDGV);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ministatement";
            Text = "ministatement";
            Load += ministatement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private DataGridView MinistatementDGV;
    }
}