using QLDTDD_FPT.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDTDD_FPT
{
    public partial class SM_Add : Form
    {
        public SM_Add()
        {
            InitializeComponent();

            // initialize combobox
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosition.Items.Add("Admin");
            cboPosition.Items.Add("User");
            cboPosition.SelectedIndex = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtpBirthday.ResetText();
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtSalary.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var unitOfWork = UnitOfWork.Instance;
                string staffId;
                string name;
                DateTime birthday;
                bool gender = false;
                string address;
                string phoneNumber;
                string position="";
                int salary;
                Random rand = new Random();
                int randomNumber = 0;

                // initialize variables
                name = txtName.Text.Trim();
                birthday = dtpBirthday.Value;
                if (rbMale.Checked)
                {
                    gender = true;
                }
                if (rbFemale.Checked)
                {
                    gender = false;
                }
                address = txtAddress.Text.Trim();
                phoneNumber = txtPhoneNumber.Text.Trim();
                position = cboPosition.SelectedItem.ToString();
                salary = Int32.Parse(txtSalary.Text.Trim());

                if (!checkFailure(name, birthday, address, phoneNumber, position, salary))
                {
                    staffId = Guid.NewGuid().ToString();
                    staffId = staffId.Replace("-", "");
                    randomNumber = rand.Next(22);
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
                    MessageBox.Show("Mission Accomplished.");
                }                
            }
            catch (SqlException)
            {
                MessageBox.Show("Database connection error.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public bool checkFailure(string name, DateTime birthday, string address, string phoneNumber, string position, int salary)
        {
            try
            {
                // check name
                if (name.Length > 0)
                {
                    if (Regex.IsMatch(name, @"^\d+$") || Regex.IsMatch(name, @"^[a-zA-Z0-9_\s]$"))
                    {
                        MessageBox.Show("The Name is incorrect.");
                        txtName.Text = "";
                        return true;
                    }
                    else if (name.Length > 50)
                    {
                        MessageBox.Show("The Name must less than 50 characters.");
                        txtName.Text = "";
                        return true;
                    }
                }

                // check date of birth
                int year = DateTime.Today.Year - birthday.Year;
                if (year > 100 && year < 1)
                {
                    MessageBox.Show("You need to choose another year of birth to ensure that your age between 1 and 100.");
                    return true;
                }

                // check address
                if (address.Length > 100)
                {
                    MessageBox.Show("The Address must less than 100 characters.");
                    return true;
                }

                // check the phone number
                if (phoneNumber.Length > 0)
                {
                    if (!Regex.IsMatch(phoneNumber, @"^\d+$"))
                    {
                        MessageBox.Show("The phone number is incorrect.");
                        txtPhoneNumber.Text = "";
                        return true;
                    }
                    else if (phoneNumber.Length > 20)
                    {
                        MessageBox.Show("The phone number must less than 20 characters.");
                        txtPhoneNumber.Text = "";
                        return true;
                    }
                }

                // check salary
                if (salary.ToString().Trim().Length > 0)
                {
                    if (!Regex.IsMatch(salary.ToString().Trim(), @"^\d+$"))
                    {
                        MessageBox.Show("The salary is incorrect.");
                        txtSalary.Text = "";
                        return true;
                    }
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
