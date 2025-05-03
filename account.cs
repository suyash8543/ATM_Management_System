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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {

        }
         SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (Accnotb.Text == "" || Nametb.Text == "" || Fnametb.Text == "" || Phonetb.Text == "" || Addresstb.Text == "" || Occupationtb.Text == "" || Pintb.Text == "" || Dobtp.Text == "" || Educationtb.Text == "")

            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO AccountTbl (AccNo, Name, FName, Phone, Address, Occupation, Pin,Education, Dob) VALUES (@AccNo, @Name, @FName, @Phone, @Address, @Occupation, @Pin, @Education, @Dob)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@AccNo", Accnotb.Text);
                    cmd.Parameters.AddWithValue("@Name", Nametb.Text);
                    cmd.Parameters.AddWithValue("@FName", Fnametb.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phonetb.Text);
                    cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                    cmd.Parameters.AddWithValue("@Occupation", Occupationtb.Text);
                    cmd.Parameters.AddWithValue("@Pin", Pintb.Text);
                    // Ensure this is of numeric type
                    cmd.Parameters.AddWithValue("@Education", Educationtb.Text);
                    cmd.Parameters.AddWithValue("@Dob", Dobtp.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successsfully");
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();


        }
    }
}
