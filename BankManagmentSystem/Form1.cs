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
        public static string username="BM-06";
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
            this.Hide();
            user_info.Instance.Show();
            
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
    }
}
