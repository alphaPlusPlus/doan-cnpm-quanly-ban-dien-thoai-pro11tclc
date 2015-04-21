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
    public partial class SM_Update : Form
    {
        public SM_Update()
        {
            InitializeComponent();

            // initialize combobox
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                cboPosition.Items.Add("Admin");
                cboPosition.Items.Add("User");

                var unitOfWork = UnitOfWork.Instance;
                Staff staff = unitOfWork.StaffRepository.GetByID("StaffId");
                cboPosition.Items.Add(staff.UserRole);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
                else
                {
                    MessageBox.Show("The name must be entered.");
                    txtName.Text = "";
                    return true;
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
                else
                {
                    MessageBox.Show("The phone number must be entered.");
                    txtPhoneNumber.Text = "";
                    return true;
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
                else
                {
                    MessageBox.Show("The salary must be entered.");
                    txtSalary.Text = "";
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
