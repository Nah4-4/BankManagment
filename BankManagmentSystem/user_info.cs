using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagmentSystem
{
    public partial class user_info : Form
    {
        
        string name, balance, accnum;
        string connectionString = $"User Id=" + Environment.GetEnvironmentVariable("USER_NAME") + ";Password=" + Environment.GetEnvironmentVariable("PASSWORD") + ";Data Source=localhost:1521/XEPDB1;";
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void username_Click(object sender, EventArgs e)
        {

        }
        private void Ldispalybalance_Click(object sender, EventArgs e)
        {

        }
        private void Ldisplayaccount_Click(object sender, EventArgs e)
        {

        }
        private void BseeBalance_Click(object sender, EventArgs e)
        {
            balanceVisible = !balanceVisible;
            if(balanceVisible)
                Ldispalybalance.Text = balance;
            else
                Ldispalybalance.Text = "*****";
        }

        private void Btransfer_Click(object sender, EventArgs e)
        {
            Ptransfer.Visible = true;
            Blogout.BringToFront();
        }

        private void Blogout_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Close();
            Instance = new user_info();
            Ptransfer.Visible = false;
        }

        private void TBaccountNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBaccountNum_Click(object sender, EventArgs e)
        {
            TBaccountNum.Text = "";
        }
        private void tabTransaction_Enter(object sender, EventArgs e)
        {
           using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM TRANSACTION WHERE ACCOUNT_NUMBER = (SELECT ACCOUNT_NUMBER FROM Account WHERE USER_NAME = :userName)";
                string username = Form1.username;
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            DGtransactions.DataSource = dt;
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Ltransferfrom_Click(object sender, EventArgs e)
        {

        }

        private void Ptransfer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void available_Click(object sender, EventArgs e)
        {

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
            if (int.Parse(balance) < int.Parse(TBamount.Text))
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

                                if (count > 0)
                                {
                                    //do transaction here
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

        private void DGtransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Phome_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
