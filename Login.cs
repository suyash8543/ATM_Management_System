using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            account ac = new account();
            ac.Show();
            this.Hide();
        }
        public static string Accnumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accno = '"+Accnumtb.Text+"' and Pin ="+pintb.Text+"",Con);
            DataTable dta= new DataTable();
            sda.Fill(dta);
            if (dta.Rows[0][0].ToString() == "1")
            {
                Accnumber = Accnumtb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                Con.Close();


            }
            else
            {
                MessageBox.Show("Invalid Account number or pin");
            }
            Con.Close();
        }
    }
}
