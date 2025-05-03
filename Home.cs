using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit Depo = new Deposit();
            Depo.Show();
            this.Hide();
        }
        public static string Accnumber;
        private void Home_Load(object sender, EventArgs e)
        {
            Accountlbl.Text = "Account Number :" + Login.Accnumber;
            Accnumber = Login.Accnumber;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            balance bl = new balance();
            this.Hide();
            bl.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdrawal wt = new Withdrawal();
            wt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fastcash fcash = new fastcash();
            fcash.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ministatement mini = new ministatement();
            mini.Show();
            this.Hide();
        }
    }
}
