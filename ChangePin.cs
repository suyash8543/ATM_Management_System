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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {








        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

            if (pin1tb.Text == " " || pin2tb.Text=="")
            {
                MessageBox.Show("Enter the new pin");

            }
            else if(pin1tb.Text!= pin2tb.Text)
            {
                MessageBox.Show("New Pin and Confirm Pin does not match");
            }
            
            else
            {
                //newbalance = oldbalance + Convert.ToInt32(depoamttb.Text);
                string Acc = Login.Accnumber;
                try
                {

                    Con.Open();
                    // Use parameterized query to prevent SQL injection
                    string query = "UPDATE Accounttbl SET Pin = @Pin WHERE Accno = @Accno";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Pin",pin1tb.Text);
                        cmd.Parameters.AddWithValue("@Accno", Acc);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Pin Successfully Updated");


                    }
                    Con.Close();
                    Login log= new Login();
                    log.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
