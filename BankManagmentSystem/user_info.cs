﻿using System;
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
        public static user_info Instance = new user_info() ;
        public user_info()
        {
            InitializeComponent();
            Instance = this;
        }

        private void user_info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
            Instance.Hide();
        }
    }
}
