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
    public partial class ministatement : Form
    {
        public ministatement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.Accnumber;
        private void populate()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive\文档\ATMdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TransactionTbl Where Account= '" + Acc + "'", con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    // Check if the DataSet has tables
                    if (ds.Tables.Count > 0)
                    {
                        MinistatementDGV.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Handle case when no tables are returned
                        MessageBox.Show("No data found.");
                    }
                }
            }
        }
        private void ministatement_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home= new Home();
            home.Show();
            this.Hide();
        }
    }
}
