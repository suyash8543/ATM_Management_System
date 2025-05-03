namespace ATM_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            Myprogress.Value = starting;
            percentage.Text = "" + starting;
            if (Myprogress.Value == 100)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
                Myprogress.Value = 0;
                timer1.Stop();

            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
