using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagmentSystem
{
    public partial class admin_page : Form
    {
        OracleConnection connection;
        string connectionString = $"User Id=" + Environment.GetEnvironmentVariable("USER_NAME") + ";Password=" + Environment.GetEnvironmentVariable("PASSWORD") + ";Data Source=localhost:1521/xepdb1;";
        public static admin_page Instance = new admin_page();
        public admin_page()
        {
            InitializeComponent();
            Instance = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_page_Load(object sender, EventArgs e)
        {
            customer_info();
        }

        private void Btntransaction_Click(object sender, EventArgs e)
        {
            using (connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT amount,transferred_from,transferred_to,transaction_date FROM TRANSACTION";
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            display.DataSource = dataTable;
                            display.ReadOnly = true;
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Btnexit_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Close();
            Instance = new admin_page();
        }
        private void customer_info()
        {
            using (connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT a.account_number,c.* FROM customer c LEFT JOIN account a ON c.user_name=a.USER_NAME";
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataTable.Columns[0].ReadOnly = true;
                            dataTable.Columns[1].ReadOnly = true;
                            dataTable.Columns[6].ReadOnly = true;
                            display.DataSource = dataTable;
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Btninfo_Click(object sender, EventArgs e)
        {
            customer_info();
        }

        List<int> row = new List<int>();
        private void display_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            row.Add(e.RowIndex);
            //MessageBox.Show(display.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            bool x = true;
            List<int> uniqNum = row.Distinct().ToList();

            foreach (var i in uniqNum)
            {
                if (display.Rows[i].Cells[2].Value.ToString() == "" || display.Rows[i].Cells[4].Value.ToString() == "" || display.Rows[i].Cells[3].Value.ToString() == "" || display.Rows[i].Cells[5].Value.ToString() == "")
                {
                    MessageBox.Show("Please enter proper input!!");
                    x = false;
                }
            }
            if (x)
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string sqlQuery = "UPDATE customer SET first_name = :fname, last_name = :lname, phone_number = :pnum,address = :adr WHERE user_name = :uname";
                    try
                    {
                        connection.Open();
                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            //for loop for different rows x
                            foreach (var i in uniqNum)
                            {
                                command.Parameters.Add(":fname", OracleDbType.Varchar2).Value = display.Rows[i].Cells[2].Value.ToString();
                                command.Parameters.Add(":lname", OracleDbType.Varchar2).Value = display.Rows[i].Cells[3].Value.ToString();
                                command.Parameters.Add(":pnum", OracleDbType.Varchar2).Value = display.Rows[i].Cells[4].Value.ToString();
                                command.Parameters.Add(":adr", OracleDbType.Varchar2).Value = display.Rows[i].Cells[5].Value.ToString();
                                command.Parameters.Add(":uname", OracleDbType.Varchar2).Value = display.Rows[i].Cells[1].Value.ToString();
                                command.ExecuteNonQuery();
                                command.Parameters.Clear();
                                MessageBox.Show("Great Success");
                            }
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    row.Clear();
                }
            }
        }
    }
}

