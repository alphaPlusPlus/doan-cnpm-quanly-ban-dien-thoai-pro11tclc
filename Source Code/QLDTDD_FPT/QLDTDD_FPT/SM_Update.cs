using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLDTDD_FPT.Database;

namespace QLDTDD_FPT
{
    public partial class SM_Update : Form
    {
        private readonly string[] _specialCharacters =
        {
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "-",
            "=",
            "+",
            "`",
            "~",
            "/",
            "?",
            "\\",
            "<",
            ">",
            ",",
            "{",
            "}",
            "[",
            "]",
            "|"
        };

        public string StaffId;
        public SM_Update()
        {
            InitializeComponent();

            // initialize combobox
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var year = DateTime.Today.Year - dtpBirthday.Value.Year;
            if (txtName.Text == "")
            {
                MessageBox.Show(@"The name is incorrect.");
            }
            else if (Regex.IsMatch(txtName.Text, @"^\d+$"))
            {
                MessageBox.Show(@"The Name is incorrect.");
                txtName.Text = "";
            }
            else if (year > 100 || year < 0)
            {
                MessageBox.Show(
                    @"You need to choose another year of birth to ensure that your age between 1 and 100.");
            }
            else if (txtAddress.TextLength > 100)
            {
                MessageBox.Show(@"The Address must less than 100 characters.");
            }
            else if (txtPhoneNumber.TextLength > 20)
            {
                MessageBox.Show(@"The phone number must less than 20 characters.");
                txtPhoneNumber.Text = "";
            }
            else if (txtPhoneNumber.TextLength == 0)
            {
                MessageBox.Show(@"The phone number must be entered.");
            }
            else if (txtSalary.TextLength == 0)
            {
                MessageBox.Show(@"The salary must be entered.");
            }

            else
            {
                try
                {
                    UnitOfWork unitOfWork = UnitOfWork.Instance;
                    bool gender = false;
                    var rand = new Random();

                    // initialize variables
                    string name = txtName.Text.Trim();
                    DateTime birthday = dtpBirthday.Value;
                    if (rbMale.Checked)
                    {
                        gender = true;
                    }
                    if (rbFemale.Checked)
                    {
                        gender = false;
                    }
                    string address = txtAddress.Text.Trim();
                    string phoneNumber = txtPhoneNumber.Text.Trim();
                    string position = cboPosition.SelectedItem.ToString();
                    int salary = Int32.Parse(txtSalary.Text.Trim());

                    if (!CheckFailure(name))
                    {
                        // update to database
                        Staff staff = unitOfWork.StaffRepository.GetByID(StaffId);
                        unitOfWork.StaffRepository.Update(staff);
                        unitOfWork.Save();
                        MessageBox.Show(@"A staff's member have been updated.");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(@"Database connection error.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        public bool CheckFailure(string name)
        {
            try
            {
                // check name
                if (name.Length > 0)
                {
                    if (Regex.IsMatch(name, @"^[a-zA-Z0-9_\s]$"))
                    {
                        MessageBox.Show(@"The Name is incorrect.");
                        txtName.Text = "";
                        return true;
                    }
                    if (name.Length > 50)
                    {
                        MessageBox.Show(@"The Name must less than 50 characters.");
                        txtName.Text = "";
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show(@"The name must be entered.");
                    txtName.Text = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            return false;
        }
    }
}