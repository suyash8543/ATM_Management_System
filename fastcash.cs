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
    public partial class fastcash : Form
    {
        public fastcash()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.Accnumber;
        int bal;

        private void addtrasaction1()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", 100);
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
        private void addtrasaction2()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", 200);
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

        private void addtrasaction3()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", 500);
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
        private void addtrasaction4()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", 1000);
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
        private void addtrasaction5()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", 1500);
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
        private void addtrasaction6()
        {
            string trType = "Withdraw";



            try
            {
                Con.Open();

                string query = "INSERT INTO TransactionTbl (Account, Type, Amount, Tdate) VALUES (@AccNo, @TrType, @withdraw, @date )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNo", Acc);
                cmd.Parameters.AddWithValue("@TrType", trType);
                cmd.Parameters.AddWithValue("@withdraw", 2000);
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
        private void fastcash_Load(object sender, EventArgs e)
        {
            getbalance();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                int newbalance = bal - 100;
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
                    addtrasaction1();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 200)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                int newbalance = bal - 200;
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
                    addtrasaction2();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                int newbalance = bal - 500;
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
                    addtrasaction3();   
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                int newbalance = bal - 1000;
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
                    addtrasaction4();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 1500)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                int newbalance = bal - 1500;
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
                    addtrasaction5();
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                int newbalance = bal - 2000;
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
                    addtrasaction6();   
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
    }
}
