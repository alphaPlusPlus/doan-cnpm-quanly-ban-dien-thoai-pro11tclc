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
    public partial class AssetManagementForm : Form
    {
        public AssetManagementForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("-Filter-");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AM_Import myform = new AM_Import();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AM_Export myform = new AM_Export();
            myform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AM_Edit myform = new AM_Edit();
            myform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AM_Order myform = new AM_Order();
            myform.Show();
        }
    }
}
