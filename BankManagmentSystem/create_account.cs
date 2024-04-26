using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem
{
    public partial class create_account : Form
    {
        public static create_account Instance = new create_account();
        
        public static string connectionString = $"User Id="+ Environment.GetEnvironmentVariable("USER_NAME")+";Password="+ Environment.GetEnvironmentVariable("PASSWORD") + ";Data Source=localhost:1521/XEPDB1;";
        const string  storedProcedureName = "CreateCustomer";
        public create_account()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Instance.Show();
        }

        private void register_field_Click(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Fname_field.Text = "";
            Lname_field.Text = "";
            Pnum_field.Text = "+251-9";
            Add_field.Text = "";
            this.Hide();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (Fname_field.Text == "" || Lname_field.Text == "" || Pnum_field.Text == "+251-9" || Add_field.Text == "" || password_field.Text == "")
            {
                MessageBox.Show("Please enter proper input!!");
            }

            else
            {
                string Fname= char.ToUpper(Fname_field.Text[0]) + Fname_field.Text.Substring(1);
                string Lname= char.ToUpper(Lname_field.Text[0]) + Lname_field.Text.Substring(1);
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                     
                        connection.Open();
                        using (OracleCommand command = new OracleCommand(storedProcedureName, connection))
                        {
                            // Specify that the command is a stored procedure
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            // Add parameters to the stored procedure
                            command.Parameters.Add("p_first_name", OracleDbType.Varchar2).Value = Fname;
                            command.Parameters.Add("p_last_name", OracleDbType.Varchar2).Value = Lname;
                            command.Parameters.Add("p_phone_number", OracleDbType.Varchar2).Value = Pnum_field.Text;
                            command.Parameters.Add("p_address", OracleDbType.Varchar2).Value = Add_field.Text;
                            command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = HashPassword(password_field.Text);
                            command.Parameters.Add("p_balance", OracleDbType.Decimal).Value = 50;

                            // Execute the stored procedure
                            command.ExecuteNonQuery();


                            string query = "SELECT user_name FROM Customer";
                            using (OracleCommand queryCommand = new OracleCommand(query, connection))
                            {
                                using (OracleDataReader reader = queryCommand.ExecuteReader())
                                {
                                    string lastUserName = null;
                                    while (reader.Read())
                                    {
                                        lastUserName = reader.GetString(0);
                                    }

                                    // Show message box with the last user_name and password
                                    // Show message box with the last user_name and password
                                    MessageBox.Show($"Account Created successfully\n\u2713 Last User Name: {lastUserName}\n\tYour password is: {password_field.Text}");

                                }
                            }
                            
                        }

                        // Close the connection
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Fname_field.Text = "";
                Lname_field.Text = "";
                Pnum_field.Text = "+251-9";
                Add_field.Text = "";
                password_field.Text = "";
               
            }
                
        }
        public static string HashPassword(string password)//encrypting the password
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                
                byte[] hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void password_field_TextChanged(object sender, EventArgs e)
        {

        }
        //public static bool VerifyPassword(string enteredPassword, string storedHash)//checking if the password entered is same as the hashed password
        //{
        //    // Hash the entered password
        //    string hashedPassword = HashPassword(enteredPassword);

        //    // Compare the hashed password with the stored hash
        //    return hashedPassword == storedHash;
        //}
    }
}
