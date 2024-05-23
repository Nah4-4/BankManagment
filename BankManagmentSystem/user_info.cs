using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagmentSystem
{
    public partial class user_info : Form
    {
        const string storedProcedureName = "PROCESSTRANSACTION";
        string name, balance, accnum;
        string connectionString = $"User Id=" + Environment.GetEnvironmentVariable("USER_NAME") + ";Password=" + Environment.GetEnvironmentVariable("PASSWORD") + ";Data Source=localhost:1521/xepdb1;";
        string accQuary = "select * from ACCOUNT WHERE USER_NAME = :user_name";
        string custQuary = "select * from CUSTOMER WHERE USER_NAME = :user_name";
        bool balanceVisible;
        public static user_info Instance = new user_info();
        public user_info()
        {
            InitializeComponent();
            Instance = this;
        }

        private void user_info_Load(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand accCommand = new OracleCommand(accQuary, connection))
                    {
                        using (OracleCommand custCommand = new OracleCommand(custQuary, connection))
                        {


                            accCommand.Parameters.Add(":username", OracleDbType.Varchar2).Value = Form1.username;
                            custCommand.Parameters.Add(":username", OracleDbType.Varchar2).Value = Form1.username;
                            using (OracleDataReader accountReader = accCommand.ExecuteReader())
                            using (OracleDataReader customerReader = custCommand.ExecuteReader())
                            {
                                if (accountReader.Read()) // Check if there is data available
                                {
                                    accnum = accountReader.GetString(accountReader.GetOrdinal("ACCOUNT_NUMBER"));
                                    balance = accountReader.GetString(accountReader.GetOrdinal("BALANCE"));
                                }

                                if (customerReader.Read()) // Check if there is data available
                                {
                                    name = customerReader.GetString(customerReader.GetOrdinal("FIRST_NAME")) + " " + customerReader.GetString(customerReader.GetOrdinal("LAST_NAME"));
                                }

                            }
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Lname.Text = name;
            Ldisplayaccount.Text = accnum;
            Ltransferfrom.Text = accnum;
            available.Text = balance;
            Ldate.Text = DateTime.Today.ToString("ddd MMM dd,yyy");
        }
        private void BseeBalance_Click(object sender, EventArgs e)
        {
            balanceVisible = !balanceVisible;
            if (balanceVisible)
                Ldispalybalance.Text = balance;
            else
                Ldispalybalance.Text = "*****";
        }

        private void Btransfer_Click(object sender, EventArgs e)
        {
            Ptransfer.Visible = true;
            Btransfer.TabStop = false;
            BseeBalance.TabStop = false;
            Blogout.TabStop = false;
            TBamount.TabStop =true;
            TBaccountNum.TabStop = true;
        }

        private void Blogout_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Close();
            Instance = new user_info();
            Ptransfer.Visible = false;
        }

        private void TBaccountNum_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
        private void tabTransaction_Enter(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT amount,transferred_from,transferred_to,transaction_date FROM TRANSACTION WHERE transferred_to = (SELECT ACCOUNT_NUMBER FROM Account WHERE USER_NAME = :userName) OR TRANSFERRED_FROM = (SELECT ACCOUNT_NUMBER FROM Account WHERE USER_NAME = :userName) order by transaction_date desc";
                string username = Form1.username;
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("Transaction",typeof(string));
                            dataTable.Load(reader);
                            foreach (DataRow row in dataTable.Rows)
                            {
                                if (row["transferred_from"].ToString() == accnum)
                                    row["Transaction"] = "Debited";
                                else if (row["transferred_to"].ToString() == accnum)
                                    row["Transaction"] = "Credited";
                            }
                            DGtransactions.DataSource = dataTable;
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TBamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.')//8 is backspace and 46 is delete
            {
                e.Handled = true;
            }
        }

        private void TBaccountNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 )//8 is backspace and 46 is delete
            {
                e.Handled = true;
            }
        }

        private void BConfirmTransfer_Click(object sender, EventArgs e)
        {
            if (TBamount.Text == "" || int.Parse(balance) < int.Parse(TBamount.Text))
            {
                MessageBox.Show("INSUFFICIENT BALANCE!!");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string sqlQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE ACCOUNT_NUMBER = :accnum";

                    try
                    {
                        connection.Open();
                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = TBaccountNum.Text;
                            using (OracleDataReader reader = command.ExecuteReader())
                            {
                                int count = Convert.ToInt32(command.ExecuteScalar());

                                if (count > 0 && TBaccountNum.Text!=accnum)
                                {
                                    using (OracleConnection conne = new OracleConnection(connectionString))
                                    {
                                        try
                                        {
                                            conne.Open();
                                            using (OracleCommand commands = new OracleCommand($"Select first_name,last_name from customer where user_name=(select user_name from account where account.account_number =:TBaccountNum)", connection))
                                            {
                                                commands.Parameters.Add(":TBaccountNum", OracleDbType.Varchar2).Value = TBaccountNum.Text;

                                                using (OracleDataReader readers = commands.ExecuteReader())
                                                {
                                                    readers.Read();
                                                    string fName = readers["first_name"].ToString();
                                                    string lName = readers["last_name"].ToString();
                                                    MessageBox.Show($"      Transaction successful!!\nETB {TBamount.Text} transferred to {fName+" "+lName}");
                                                }
                                            }

                                            using (OracleCommand comm = new OracleCommand(storedProcedureName, conne))
                                            {
                                                // Specify that the command is a stored procedure
                                                comm.CommandType = System.Data.CommandType.StoredProcedure;

                                                // Add parameters to the stored procedure
                                                comm.Parameters.Add("p_account_number_from", OracleDbType.Varchar2).Value = accnum;
                                                comm.Parameters.Add("p_account_number_to", OracleDbType.Varchar2).Value = TBaccountNum.Text;
                                                comm.Parameters.Add("p_amount", OracleDbType.Varchar2).Value = TBamount.Text;
                                                balance = int.Parse(balance) - int.Parse(TBamount.Text) + "";

                                                // Execute the stored procedure
                                                comm.ExecuteNonQuery();
                                            }

                                            // Close the connection
                                            conne.Close();
                                            connection.Close();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                    Ptransfer.Visible = false;
                                    BseeBalance.TabStop = true;
                                    Btransfer.TabStop = true;
                                    Blogout.TabStop = true;
                                }
                                else
                                {
                                    MessageBox.Show("Account number doesn't exist");
                                }
                            }
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Butility_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void Btopup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void Ltransferfrom_Click(object sender, EventArgs e)
        {

        }

        private void Ldispalybalance_Click(object sender, EventArgs e)
        {

        }

        private void DGtransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabTransaction_Click(object sender, EventArgs e)
        {

        }

        private void TBaccountNum_Enter(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void Bback_Click(object sender, EventArgs e)
        {
            Ptransfer.Visible = false;
            BseeBalance.TabStop = true;
            Btransfer.TabStop = true;
            Blogout.TabStop = true;
        }
    }
}