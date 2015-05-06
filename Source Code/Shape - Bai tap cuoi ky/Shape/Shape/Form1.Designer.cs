namespace Shape
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSize1 = new System.Windows.Forms.Label();
            this.txtSize1 = new System.Windows.Forms.TextBox();
            this.txtSize2 = new System.Windows.Forms.TextBox();
            this.lblSize2 = new System.Windows.Forms.Label();
            this.txtSize3 = new System.Windows.Forms.TextBox();
            this.lblSize3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboShape3D = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtArea3D = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize3_3D = new System.Windows.Forms.TextBox();
            this.lblSize3_3D = new System.Windows.Forms.Label();
            this.txtSize2_3D = new System.Windows.Forms.TextBox();
            this.lblSize2_3D = new System.Windows.Forms.Label();
            this.txtSize1_3D = new System.Windows.Forms.TextBox();
            this.lblSize1_3D = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboShape);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSize3);
            this.tabPage1.Controls.Add(this.lblSize3);
            this.tabPage1.Controls.Add(this.txtSize2);
            this.tabPage1.Controls.Add(this.lblSize2);
            this.tabPage1.Controls.Add(this.txtSize1);
            this.tabPage1.Controls.Add(this.lblSize1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "2D Shapes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtVolume);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cboShape3D);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.txtArea3D);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSize3_3D);
            this.tabPage2.Controls.Add(this.lblSize3_3D);
            this.tabPage2.Controls.Add(this.txtSize2_3D);
            this.tabPage2.Controls.Add(this.lblSize2_3D);
            this.tabPage2.Controls.Add(this.txtSize1_3D);
            this.tabPage2.Controls.Add(this.lblSize1_3D);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "3D Shapes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSize1
            // 
            this.lblSize1.AutoSize = true;
            this.lblSize1.Location = new System.Drawing.Point(278, 12);
            this.lblSize1.Name = "lblSize1";
            this.lblSize1.Size = new System.Drawing.Size(67, 25);
            this.lblSize1.TabIndex = 4;
            this.lblSize1.Text = "Size 1";
            // 
            // txtSize1
            // 
            this.txtSize1.Location = new System.Drawing.Point(283, 40);
            this.txtSize1.Name = "txtSize1";
            this.txtSize1.Size = new System.Drawing.Size(247, 30);
            this.txtSize1.TabIndex = 5;
            // 
            // txtSize2
            // 
            this.txtSize2.Location = new System.Drawing.Point(283, 101);
            this.txtSize2.Name = "txtSize2";
            this.txtSize2.Size = new System.Drawing.Size(247, 30);
            this.txtSize2.TabIndex = 7;
            // 
            // lblSize2
            // 
            this.lblSize2.AutoSize = true;
            this.lblSize2.Location = new System.Drawing.Point(278, 73);
            this.lblSize2.Name = "lblSize2";
            this.lblSize2.Size = new System.Drawing.Size(67, 25);
            this.lblSize2.TabIndex = 6;
            this.lblSize2.Text = "Size 2";
            // 
            // txtSize3
            // 
            this.txtSize3.Location = new System.Drawing.Point(283, 162);
            this.txtSize3.Name = "txtSize3";
            this.txtSize3.Size = new System.Drawing.Size(247, 30);
            this.txtSize3.TabIndex = 9;
            // 
            // lblSize3
            // 
            this.lblSize3.AutoSize = true;
            this.lblSize3.Location = new System.Drawing.Point(278, 134);
            this.lblSize3.Name = "lblSize3";
            this.lblSize3.Size = new System.Drawing.Size(67, 25);
            this.lblSize3.TabIndex = 8;
            this.lblSize3.Text = "Size 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(20, 101);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(185, 30);
            this.txtArea.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(88, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 47);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 47);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(328, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 47);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboShape
            // 
            this.cboShape.FormattingEnabled = true;
            this.cboShape.Items.AddRange(new object[] {
            "Rectangle",
            "Triangle",
            "Circle"});
            this.cboShape.Location = new System.Drawing.Point(20, 40);
            this.cboShape.Name = "cboShape";
            this.cboShape.Size = new System.Drawing.Size(185, 33);
            this.cboShape.TabIndex = 15;
            this.cboShape.SelectedIndexChanged += new System.EventHandler(this.cboShape_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choose shapes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Choose shapes";
            // 
            // cboShape3D
            // 
            this.cboShape3D.FormattingEnabled = true;
            this.cboShape3D.Items.AddRange(new object[] {
            "Cylinder",
            "Sphere",
            "Cuboid"});
            this.cboShape3D.Location = new System.Drawing.Point(19, 41);
            this.cboShape3D.Name = "cboShape3D";
            this.cboShape3D.Size = new System.Drawing.Size(185, 33);
            this.cboShape3D.TabIndex = 28;
            this.cboShape3D.SelectedIndexChanged += new System.EventHandler(this.cboShape3D_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 47);
            this.button3.TabIndex = 25;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtArea3D
            // 
            this.txtArea3D.Enabled = false;
            this.txtArea3D.Location = new System.Drawing.Point(19, 102);
            this.txtArea3D.Name = "txtArea3D";
            this.txtArea3D.Size = new System.Drawing.Size(185, 30);
            this.txtArea3D.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Area";
            // 
            // txtSize3_3D
            // 
            this.txtSize3_3D.Location = new System.Drawing.Point(282, 163);
            this.txtSize3_3D.Name = "txtSize3_3D";
            this.txtSize3_3D.Size = new System.Drawing.Size(247, 30);
            this.txtSize3_3D.TabIndex = 22;
            // 
            // lblSize3_3D
            // 
            this.lblSize3_3D.AutoSize = true;
            this.lblSize3_3D.Location = new System.Drawing.Point(277, 135);
            this.lblSize3_3D.Name = "lblSize3_3D";
            this.lblSize3_3D.Size = new System.Drawing.Size(67, 25);
            this.lblSize3_3D.TabIndex = 21;
            this.lblSize3_3D.Text = "Size 3";
            // 
            // txtSize2_3D
            // 
            this.txtSize2_3D.Location = new System.Drawing.Point(282, 102);
            this.txtSize2_3D.Name = "txtSize2_3D";
            this.txtSize2_3D.Size = new System.Drawing.Size(247, 30);
            this.txtSize2_3D.TabIndex = 20;
            // 
            // lblSize2_3D
            // 
            this.lblSize2_3D.AutoSize = true;
            this.lblSize2_3D.Location = new System.Drawing.Point(277, 74);
            this.lblSize2_3D.Name = "lblSize2_3D";
            this.lblSize2_3D.Size = new System.Drawing.Size(67, 25);
            this.lblSize2_3D.TabIndex = 19;
            this.lblSize2_3D.Text = "Size 2";
            // 
            // txtSize1_3D
            // 
            this.txtSize1_3D.Location = new System.Drawing.Point(282, 41);
            this.txtSize1_3D.Name = "txtSize1_3D";
            this.txtSize1_3D.Size = new System.Drawing.Size(247, 30);
            this.txtSize1_3D.TabIndex = 18;
            // 
            // lblSize1_3D
            // 
            this.lblSize1_3D.AutoSize = true;
            this.lblSize1_3D.Location = new System.Drawing.Point(277, 13);
            this.lblSize1_3D.Name = "lblSize1_3D";
            this.lblSize1_3D.Size = new System.Drawing.Size(67, 25);
            this.lblSize1_3D.TabIndex = 17;
            this.lblSize1_3D.Text = "Size 1";
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Location = new System.Drawing.Point(19, 163);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(185, 30);
            this.txtVolume.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 333);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSize3;
        private System.Windows.Forms.Label lblSize3;
        private System.Windows.Forms.TextBox txtSize2;
        private System.Windows.Forms.Label lblSize2;
        private System.Windows.Forms.TextBox txtSize1;
        private System.Windows.Forms.Label lblSize1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboShape;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboShape3D;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtArea3D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize3_3D;
        private System.Windows.Forms.Label lblSize3_3D;
        private System.Windows.Forms.TextBox txtSize2_3D;
        private System.Windows.Forms.Label lblSize2_3D;
        private System.Windows.Forms.TextBox txtSize1_3D;
        private System.Windows.Forms.Label lblSize1_3D;
    }
}

