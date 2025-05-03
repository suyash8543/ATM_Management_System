using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace ATM_Management_System
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.Accnumber;
       

        private void addtrasaction()
        {
            string trType = "Deposit";
         


            try
            {
                Con.Open();
             
                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @Depo, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@Depo", depoamttb.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
              



                cmd.ExecuteNonQuery();
               
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (depoamttb.Text == " " || Convert.ToInt32(depoamttb.Text) <= 0)
            {
                MessageBox.Show("enter the amount to deposit");

            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(depoamttb.Text);
                
                try
                {
                    
                        Con.Open();
                        // Use parameterized query to prevent SQL injection
                        string query = "UPDATE Accounttbl SET Balance = @Balance WHERE Accno = @Accno";

                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            // Add parameters to the command
                            cmd.Parameters.AddWithValue("@Balance", newbalance);
                            cmd.Parameters.AddWithValue("@Accno", Acc);

                            // Execute the command
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" Deposit Successful");


                        }
                        Con.Close();
                    addtrasaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int oldbalance, newbalance;
        public void getbalance()
        {
            Con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT Balance FROM AccountTbl WHERE Accno = @AccNo", Con))
            {
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0 && !string.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                {
                    oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
                else
                {
                    // Handle case where there are no rows returned
                    oldbalance = 0; // or another default value
                }
            }
            Con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
           
        }
    }
}
