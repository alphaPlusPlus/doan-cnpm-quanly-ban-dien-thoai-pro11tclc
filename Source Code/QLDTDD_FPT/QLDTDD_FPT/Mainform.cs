﻿using QLDTDD_FPT.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDTDD_FPT
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            var s = SysDbContext.Instance; // create context for the first time
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneManangementForm myform = new PhoneManangementForm();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssetManagementForm myform = new AssetManagementForm();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffManagementForm myform = new StaffManagementForm();
            myform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportManagementForm myform = new ReportManagementForm();
            myform.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login myform = new Login();
            myform.Show();
        }
    }
}
