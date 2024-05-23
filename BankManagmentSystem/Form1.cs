using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BankManagmentSystem
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public static string username="";
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Close(object sender, EventArgs e)
        {
            user_info.Instance.Close();
            create_account.Instance.Close();
        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            string user = TBname.Text;
            string pass = create_account.HashPassword(TBpassword.Text);
            string query = "SELECT COUNT(*) FROM SECURITY WHERE USER_NAME = :user_name AND PASSWORD = :pass";
            if (TBname.Text == "admin" && TBpassword.Text == "admin")
            {
                this.Hide();
                admin_page.Instance.Show();
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(create_account.connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {

                        command.Parameters.Add(":user_name", OracleDbType.Varchar2).Value = user;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = pass;

                        try
                        {
                            connection.Open();


                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {
                                username = TBname.Text;
                                TBname.Text = "";
                                TBpassword.Text = "";
                                this.Hide();
                                user_info.Instance.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error :\n          Wrong Password or User Name");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            MessageBox.Show("Error : \n            An Error Occured please try again");
                        }
                    }
                }
            }
                      
        }

        private void TBname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LLcreateaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Instance.Hide();
            create_account.Instance.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            TBname.Text = "BM-";
        }
    }
}
