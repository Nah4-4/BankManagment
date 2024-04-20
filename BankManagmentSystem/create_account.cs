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
    public partial class create_account : Form
    {
        public static create_account Instance = new create_account();
        public create_account()
        {
            InitializeComponent();
            Instance = this;
        }
        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Hide();
        }
    }
}
