using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLDTDD_FPT.Database;

namespace QLDTDD_FPT
{
    public partial class SM_Add : Form
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

        public SM_Add()
        {
            InitializeComponent();

            // initialize combobox
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosition.Items.Add("Admin");
            cboPosition.Items.Add("User");
            //cboPosition.SelectedIndex = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            else if (rbFemale.Checked == false && rbMale.Checked == false)
            {
                MessageBox.Show(@"Gender must be chosen.");
            }
            else if (txtAddress.TextLength > 100)
            {
                MessageBox.Show(@"The Address must less than 100 characters.");
            }
            else if (cboPosition.Text == "")
            {
                MessageBox.Show(@"Position must be chosen.");
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
                        string staffId = Guid.NewGuid().ToString();
                        staffId = staffId.Replace("-", "");
                        int randomNumber = rand.Next(22);
                        staffId = staffId.Substring(randomNumber, 10);

                        // add to database
                        unitOfWork.StaffRepository.Insert(new Staff
                        {
                            StaffId = staffId,
                            Name = name,
                            BirthDate = birthday,
                            Gender = gender,
                            Address = address,
                            PhoneNum = phoneNumber,
                            UserRole = position,
                            MonthlySalary = salary
                        });
                        unitOfWork.Save();
                        MessageBox.Show(@"A staff's member have been added.");
                        Clear();
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

        public void Clear()
        {
            txtName.Text = "";
            dtpBirthday.ResetText();
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtSalary.Text = "";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString(CultureInfo.InvariantCulture) == " ")
            {
                MessageBox.Show(@"The name is incorrect.");
            }
            else
            {
                foreach (var t in _specialCharacters)
                {
                    if (e.KeyChar.ToString(CultureInfo.InvariantCulture).Contains(t))
                    {
                        MessageBox.Show(@"The name is incorrect.");        
                    }
                }
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // handle input field
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            //MessageBox.Show(@"The phone number is incorrect.");
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // handle input field
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
            MessageBox.Show(@"The salary is incorrect.");
        }

        private void SM_Add_Load(object sender, EventArgs e)
        {
            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.MouseEnter += (s, f) => b.Cursor = Cursors.Hand;
                b.MouseLeave += (s, f) => b.Cursor = Cursors.Arrow;
            }
        }
    }
}