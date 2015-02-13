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
    public partial class PhoneManangementForm : Form
    {
        public PhoneManangementForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("-Filter-");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PM_Import myform = new PM_Import();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PM_Export myform = new PM_Export();
            myform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PM_Edit myform = new PM_Edit();
            myform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PM_Order myform = new PM_Order();
            myform.Show();
        }
    }
}
