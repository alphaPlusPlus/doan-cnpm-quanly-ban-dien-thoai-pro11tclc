using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboShape.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShape3D.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSize1.Text = @"Size 1";
            lblSize2.Text = @"Size 2";
            lblSize3.Text = @"Size 3";
            txtArea.Text = @"";
        }

        private void cboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShape.SelectedIndex == 0)
            {
                lblSize1.Text = @"Width";
                lblSize2.Text = @"Height";
                txtSize2.Enabled = true;
                txtSize3.Enabled = false;
            }

            if (cboShape.SelectedIndex == 1)
            {
                lblSize1.Text = @"Side 1";
                lblSize2.Text = @"Side 2";
                lblSize3.Text = @"Side 3";
                txtSize2.Enabled = true;
                txtSize3.Enabled = true;
            }

            if (cboShape.SelectedIndex == 2)
            {
                lblSize1.Text = @"Radius";
                txtSize2.Enabled = false;
                txtSize3.Enabled = false;
            }
        }

        private void cboShape3D_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShape3D.SelectedIndex == 0)
            {
                lblSize1_3D.Text = @"Radius";
                lblSize2_3D.Text = @"Height";
                txtSize2_3D.Enabled = true;
                txtSize3_3D.Enabled = false;
            }

            if (cboShape3D.SelectedIndex == 1)
            {
                lblSize1_3D.Text = @"Radius";
                txtSize2_3D.Enabled = false;
                txtSize3_3D.Enabled = false;
            }

            if (cboShape3D.SelectedIndex == 2)
            {
                lblSize1_3D.Text = @"Width";
                lblSize2_3D.Text = @"Height";
                lblSize3_3D.Text = @"Depth";
                txtSize2_3D.Enabled = true;
                txtSize3_3D.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSize1_3D.Text = @"Size 1";
            lblSize2_3D.Text = @"Size 2";
            lblSize3_3D.Text = @"Size 3";
            txtArea3D.Text = @"";
            txtVolume.Text = @"";
        }
    }
}
