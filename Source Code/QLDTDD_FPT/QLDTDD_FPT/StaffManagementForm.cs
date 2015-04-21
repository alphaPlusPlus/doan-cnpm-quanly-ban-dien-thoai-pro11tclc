using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using QLDTDD_FPT.Database;

namespace QLDTDD_FPT
{
    public partial class StaffManagementForm : Form
    {
        public StaffManagementForm()
        {
            InitializeComponent();

            btnUpdate.Enabled = false;
            cboFilter.Items.Add("-Filter-");
            GetDataFromDb();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myform = new SM_Add();
            var result = myform.ShowDialog();
            if (result != DialogResult.Cancel) return;
            dataGridView1.DataSource = null;
            GetDataFromDb();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var myform = new SM_Update();
            myform.Show();
        }

        private void btnTimebook_Click(object sender, EventArgs e)
        {
            var myform = new SM_Timebook();
            myform.Show();
        }

        public void GetDataFromDb()
        {
            try
            {
                var unitOfWork = UnitOfWork.Instance;
                var staffsQuery2 = unitOfWork.StaffRepository.Get();

                var staffLst = staffsQuery2.Select(stf => new // select just StaffId and Address column
                {
                    stf.StaffId,
                    stf.Name,
                    stf.BirthDate,
                    stf.Gender,
                    stf.Address,
                    stf.PhoneNum,
                    Position = stf.UserRole,
                    Salary = stf.MonthlySalary
                }).ToList();
                dataGridView1.DataSource = staffLst;
            }
            catch (SqlException)
            {
                MessageBox.Show(@"Database connetion error.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}