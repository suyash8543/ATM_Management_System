namespace ATM_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            Accnumtb = new TextBox();
            pintb = new TextBox();
            button1 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 80);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(688, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 42);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(563, 48);
            label1.TabIndex = 1;
            label1.Text = "ATM Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(337, 83);
            label2.Name = "label2";
            label2.Size = new Size(113, 42);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(193, 180);
            label3.Name = "label3";
            label3.Size = new Size(213, 31);
            label3.TabIndex = 4;
            label3.Text = "ACC Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(193, 263);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 5;
            label4.Text = "Password :";
            // 
            // Accnumtb
            // 
            Accnumtb.Location = new Point(445, 180);
            Accnumtb.Name = "Accnumtb";
            Accnumtb.Size = new Size(262, 27);
            Accnumtb.TabIndex = 6;
            // 
            // pintb
            // 
            pintb.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pintb.Location = new Point(445, 263);
            pintb.Name = "pintb";
            pintb.PasswordChar = '*';
            pintb.Size = new Size(262, 25);
            pintb.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(445, 336);
            button1.Name = "button1";
            button1.Size = new Size(262, 49);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(519, 388);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 9;
            label5.Text = "Signup";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 16);
            panel2.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(734, 447);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pintb);
            Controls.Add(Accnumtb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox Accnumtb;
        private TextBox pintb;
        private Button button1;
        private Label label5;
        private Label label6;
        private Panel panel2;
    }
}