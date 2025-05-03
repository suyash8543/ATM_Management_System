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
using System.Linq.Expressions;

namespace ATM_Management_System
{
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.Accnumber;
        int bal;
        private void addtrasaction()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", wtamttb.Text);
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
        public void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Balance from  AccountTbl Where Accno ='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = " Balance Rs: " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Withdrawal_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int newbalance, oldname;
        private void button1_Click(object sender, EventArgs e)
        {
            if(bal <= Convert.ToInt32(wtamttb.Text))
            {
                MessageBox.Show("Unavailable balance");
            }
            else if(wtamttb.Text=="")
            {
                MessageBox.Show("Enter the amount to withdraw");

            }
            else if (Convert.ToInt32(wtamttb.Text) <= 0)
            {
                MessageBox.Show("Enter the valid amount");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wtamttb.Text);

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
                            MessageBox.Show(" Withdraw Successful");


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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
