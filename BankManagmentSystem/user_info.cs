using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem
{
    public partial class user_info : Form
    {
        bool balanceVisible;
        public static user_info Instance = new user_info() ;
        public user_info()
        {
            InitializeComponent();
            Instance = this;
        }

        private void user_info_Load(object sender, EventArgs e)
        {
            Lname.Text = "Nahom Kiflu";
            Ldisplayaccount.Text = "10002";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Hide();
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
                Ldispalybalance.Text = "1234";
            else
                Ldispalybalance.Text = "*****";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
 
}
