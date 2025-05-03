using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management_System
{
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");

        public void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from  AccountTbl Where Accno ='"+Accnumlbl.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void balance_Load(object sender, EventArgs e)
        {
            Accnumlbl.Text = Home.Accnumber;
            getbalance();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
