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
        string connectionString = $"User Id=" + Environment.GetEnvironmentVariable("USER_NAME") + ";Password=" + Environment.GetEnvironmentVariable("PASSWORD") + ";Data Source=localhost:1521/xe;";
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
            date.MinDate = DateTime.Now;
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
            available.Text = balance;
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
                    int freezeValue=0;
                    connection.Open();
                    string sql = "SELECT FREEZE FROM ACCOUNT WHERE ACCOUNT_NUMBER = :accnum";
                    using (OracleCommand com = new OracleCommand(sql, connection))
                    {
                        com.Parameters.Add(new OracleParameter("accnum", accnum));
                        using (OracleDataReader re = com.ExecuteReader())
                        {
                            if (re.Read())
                            {
                                    freezeValue = re.GetInt32(re.GetOrdinal("FREEZE"));
                            }
                            re.Close();
                        }
                    }
                    if (freezeValue == 1)
                    {
                        MessageBox.Show("Your Account is frozen.", "Freeze Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sqlQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE ACCOUNT_NUMBER = :accnum";

                        try
                        {
                            
                            using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                            {
                                command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = TBaccountNum.Text;
                                using (OracleDataReader reader = command.ExecuteReader())
                                {
                                    int count = Convert.ToInt32(command.ExecuteScalar());

                                    if (count > 0 && TBaccountNum.Text != accnum)
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
                                                        MessageBox.Show($"      Transaction successful!!\nETB {TBamount.Text} transferred to {fName + " " + lName}");
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
        private void Btnpay_Click(object sender, EventArgs e)
        {
            if (TBpay.Text == "" || int.Parse(balance) < int.Parse(TBpay.Text))           
                MessageBox.Show("INSUFFICIENT BALANCE!!");           
            else
            {
                int payed = int.Parse(LremainLoan.Text) - int.Parse(TBpay.Text);
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        if (payed > 0)
                        {
                            string sqlQuery = "update loan set amount= :payed where account_number= :accnum";
                            using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                            {
                                command.Parameters.Add(":payed", OracleDbType.Varchar2).Value = payed;
                                command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                                command.ExecuteNonQuery();
                            }
                            string sqlQuer = "update account set balance= :sub where account_number = :accnum";
                            using (OracleCommand command = new OracleCommand(sqlQuer, connection))
                            {
                                command.Parameters.Add(":sub", OracleDbType.Varchar2).Value = (int.Parse(balance) - int.Parse(TBpay.Text));
                                command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                                command.ExecuteNonQuery();
                            }
                            balance = (int.Parse(balance) - int.Parse(TBpay.Text)).ToString();
                            MessageBox.Show(TBpay.Text+" ETB Payed");
                        }
                        else if (payed == 0)
                        {
                            string sqlQuery = "update loan set status= 'payed' where account_number= :accnum";
                            using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                            {
                                command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                                command.ExecuteNonQuery();
                            }
                            string sqlQuer = "update account set balance= :sub where account_number = :accnum";
                            using (OracleCommand command = new OracleCommand(sqlQuer, connection))
                            {
                                command.Parameters.Add(":sub", OracleDbType.Varchar2).Value = (int.Parse(balance) - int.Parse(TBpay.Text));
                                command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                                command.ExecuteNonQuery();
                            }
                            balance = (int.Parse(balance) - int.Parse(TBpay.Text)).ToString();
                            MessageBox.Show(TBpay.Text + " ETB Payed");
                        }
                        else
                            MessageBox.Show("Invalid Loan Payment"); 
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            PpayLoan.Visible = false;
        }

        private void Btnloan_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "Select status from loan Where account_number= :accnum ";
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                        if (command.ExecuteScalar() == null || command.ExecuteScalar().ToString() == "payed" )
                            MessageBox.Show("No Loans Available");
                        else
                        {
                            PpayLoan.Visible = true;
                            string sqlQuer = "Select amount from loan Where account_number= :accnum ";
                            using (OracleCommand comman = new OracleCommand(sqlQuer, connection))
                            {
                                comman.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                                LremainLoan.Text = comman.ExecuteScalar().ToString();

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

        private void Btnback_Click(object sender, EventArgs e)
        {
            PpayLoan.Visible = false;
        }

        private void BtnpayFull_Click(object sender, EventArgs e)
        {
            if(int.Parse(balance) > int.Parse(LremainLoan.Text))
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string sqlQuery = "update loan set status= 'payed' where account_number= :accnum";
                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                            command.ExecuteNonQuery();
                        }
                        string sqlQuer = "update account set balance= :sub where account_number = :accnum";
                        using (OracleCommand command = new OracleCommand(sqlQuer, connection))
                        {
                            command.Parameters.Add(":sub", OracleDbType.Varchar2).Value = (int.Parse(balance) - int.Parse(LremainLoan.Text));
                            command.Parameters.Add(":accnum", OracleDbType.Varchar2).Value = accnum;
                            command.ExecuteNonQuery();
                        }
                        balance = (int.Parse(balance) - int.Parse(LremainLoan.Text)).ToString();
                        MessageBox.Show(LremainLoan.Text + " ETB Payed");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("INSUFFICIENT BALANCE!!");
            PpayLoan.Visible = false;
        }

        private void Ptransfer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void GetL_Click(object sender, EventArgs e)
        {
            if(IsNumber(amount.Text))
            {
                if (!AccountNumberOnLoan(int.Parse(accnum))){
                    DateTime selectedDate = date.Value;
                    IssueLoan(int.Parse(accnum), int.Parse(amount.Text),selectedDate);
                    balance = (int.Parse(balance) + int.Parse(amount.Text)) + "";
                    UpdateAccountBalance(int.Parse(accnum),int.Parse(balance));
                }
                else
                {
                    MessageBox.Show("Please Pay Your Loan First.");
                }
            }
            else
            {
                MessageBox.Show("The amount is not a valid number.");
            }
        }

        private bool AccountNumberOnLoan(int accountNumber)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Loan WHERE account_number = :accountNumber AND status = 'active'";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("accountNumber", accountNumber));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private void IssueLoan(int accountNumber, decimal amount, DateTime endDate)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("IssueLoan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters
                    cmd.Parameters.Add("p_account_number", OracleDbType.Int32).Value = accountNumber;
                    cmd.Parameters.Add("p_amount", OracleDbType.Decimal).Value = amount;
                    cmd.Parameters.Add("p_end_date", OracleDbType.Date).Value = endDate;
                    

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Loan issued successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool UpdateAccountBalance(int accountNumber, decimal newBalance)
        {
            

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Account SET balance = :newBalance WHERE account_number = :accountNumber";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("newBalance", newBalance));
                    cmd.Parameters.Add(new OracleParameter("accountNumber", accountNumber));

                    // Execute the update command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // If one or more rows were affected, the update was successful
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private void TBaccountNum_Enter(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void available_Click(object sender, EventArgs e)
        {

        }

        private void Bback_Click(object sender, EventArgs e)
        {
            Ptransfer.Visible = false;
            BseeBalance.TabStop = true;
            Btransfer.TabStop = true;
            Blogout.TabStop = true;
        }
        private bool IsNumber(string text)
        {
            int intResult;
            decimal decimalResult;
            // Check if the text is a valid integer or a valid decimal
            return int.TryParse(text, out intResult) || decimal.TryParse(text, out decimalResult);
        }
    }
}