using QLDTDD_FPT.Database;
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
    public partial class StaffManagementForm : Form
    {
        public StaffManagementForm()
        {
            InitializeComponent();

            cboFilter.Items.Add("-Filter-");
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SM_Add myform = new SM_Add();
            myform.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SM_Update myform = new SM_Update();
            myform.Show();
        }

        private void btnTimebook_Click(object sender, EventArgs e)
        {
            SM_Timebook myform = new SM_Timebook();
            myform.Show();
        }

        public static void getDataFromDB()
        {

        }
    }
}
