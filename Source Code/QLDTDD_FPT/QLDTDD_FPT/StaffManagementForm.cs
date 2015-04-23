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
            // MessageBox.Show(@"Database connection error.");
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
            var myUpdate = new SM_Update();
            var dataGridViewRow = dataGridView1.CurrentRow;
            if (dataGridViewRow != null)
            {
                myUpdate.StaffId = dataGridViewRow.Cells[0].Value.ToString();
                myUpdate.txtName.Text = dataGridViewRow.Cells[1].Value.ToString();
                myUpdate.dtpBirthday.Value = (DateTime)dataGridViewRow.Cells[2].Value;
                if ((bool) dataGridViewRow.Cells[3].Value)
                {
                    myUpdate.rbMale.Checked = true;
                }
                else
                {
                    myUpdate.rbFemale.Checked = true;
                }
                myUpdate.txtAddress.Text = dataGridViewRow.Cells[4].Value.ToString();
                myUpdate.txtPhoneNumber.Text = dataGridViewRow.Cells[5].Value.ToString();
                myUpdate.txtSalary.Text = dataGridViewRow.Cells[7].Value.ToString();
                myUpdate.cboPosition.Items.Add(dataGridViewRow.Cells[6].Value.ToString());
                if (myUpdate.cboPosition.Items[0].ToString() == "Admin")
                {
                    myUpdate.cboPosition.Items.Add("User");
                    myUpdate.cboPosition.SelectedItem = "Admin";
                }
                else
                {
                    myUpdate.cboPosition.Items.Add("Admin");
                    myUpdate.cboPosition.SelectedItem = "User";
                }
            }
            var result = myUpdate.ShowDialog();
            if (result != DialogResult.Cancel) return;
            dataGridView1.DataSource = null;
            GetDataFromDb();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
        } 
    }
}