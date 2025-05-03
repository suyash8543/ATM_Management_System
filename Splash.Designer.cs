namespace ATM_Management_System
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(563, 48);
            label1.TabIndex = 0;
            label1.Text = "ATM Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(-10, 497);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(832, 29);
            Myprogress.TabIndex = 2;
            // 
            // percentage
            // 
            percentage.AutoSize = true;
            percentage.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentage.ForeColor = SystemColors.Control;
            percentage.Location = new Point(411, 434);
            percentage.Name = "percentage";
            percentage.Size = new Size(56, 48);
            percentage.TabIndex = 3;
            percentage.Text = "%";
            percentage.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(824, 525);
            Controls.Add(percentage);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private Label percentage;
        private System.Windows.Forms.Timer timer1;
    }
}
