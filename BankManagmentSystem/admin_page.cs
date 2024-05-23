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

namespace BankManagmentSystem
{
    public partial class admin_page : Form
    {
        string connectionString = $"User Id=" + Environment.GetEnvironmentVariable("USER_NAME") + ";Password=" + Environment.GetEnvironmentVariable("PASSWORD") + ";Data Source=localhost:1521/xe;";
        public static admin_page Instance = new admin_page();
        int index;
        string acc;
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
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (freeze_btn.Text == "FREEZE")
                    {
                        string sqlQuery = "UPDATE ACCOUNT SET freeze = 1 WHERE account_number = :account_number";

                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            // Add parameter to the command
                            command.Parameters.Add(new OracleParameter("account_number", acc));

                            // Execute the command
                            int rowsUpdated = command.ExecuteNonQuery();

                            if (rowsUpdated > 0)
                            {
                                MessageBox.Show("Account frozen successfully.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else if(freeze_btn.Text == "UNFREEZE")
                    {
                        string sqlQuery = "UPDATE ACCOUNT SET freeze = 0 WHERE account_number = :account_number";

                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            // Add parameter to the command
                            command.Parameters.Add(new OracleParameter("account_number", acc));

                            // Execute the command
                            int rowsUpdated = command.ExecuteNonQuery();

                            if (rowsUpdated > 0)
                            {
                                MessageBox.Show("Account unfrozen successfully.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_page_Load(object sender, EventArgs e)
        {
        }

        private void Btntransaction_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
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
            this.Hide();
        }

        private void Btninfo_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT a.account_number,c.*\r\nFROM customer c\r\nLEFT JOIN account a ON c.user_name=a.USER_NAME";
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
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = display.Rows[index];
            acc = row.Cells[0].Value.ToString();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "SELECT FREEZE FROM ACCOUNT WHERE ACCOUNT_NUMBER = :accnum";
                    OracleCommand command = new OracleCommand(sqlQuery, connection);
                    command.Parameters.Add(new OracleParameter("accnum", acc));

                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int freezeValue = Convert.ToInt32(reader["FREEZE"]);
                        if (freezeValue == 1)
                        {
                            freeze_btn.Text = "UNFREEZE";
                        }
                        else
                        {
                            freeze_btn.Text = "FREEZE";
                        }
                    }
 

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    
                }
            }


        }
    }
}

