namespace bartool
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.cblocked = new System.Windows.Forms.CheckBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRecruit = new System.Windows.Forms.DateTimePicker();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScore = new System.Windows.Forms.NumericUpDown();
            this.lblLevels = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.lblTelphone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.rdbGirl = new System.Windows.Forms.RadioButton();
            this.rdbBoy = new System.Windows.Forms.RadioButton();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchExt = new System.Windows.Forms.TextBox();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.cblocked);
            this.grpInformation.Controls.Add(this.cmbDepartment);
            this.grpInformation.Controls.Add(this.label8);
            this.grpInformation.Controls.Add(this.txtPassword);
            this.grpInformation.Controls.Add(this.label7);
            this.grpInformation.Controls.Add(this.txtCustomerID);
            this.grpInformation.Controls.Add(this.label6);
            this.grpInformation.Controls.Add(this.label5);
            this.grpInformation.Controls.Add(this.dtpRecruit);
            this.grpInformation.Controls.Add(this.txtExt);
            this.grpInformation.Controls.Add(this.label4);
            this.grpInformation.Controls.Add(this.txtTelephone);
            this.grpInformation.Controls.Add(this.label3);
            this.grpInformation.Controls.Add(this.txtCustomerCode);
            this.grpInformation.Controls.Add(this.label2);
            this.grpInformation.Controls.Add(this.dtpBirthday);
            this.grpInformation.Controls.Add(this.numericUpDownLevel);
            this.grpInformation.Controls.Add(this.numericUpDownScore);
            this.grpInformation.Controls.Add(this.lblLevels);
            this.grpInformation.Controls.Add(this.lblScore);
            this.grpInformation.Controls.Add(this.txtEmail);
            this.grpInformation.Controls.Add(this.lblEmail);
            this.grpInformation.Controls.Add(this.txtMobilePhone);
            this.grpInformation.Controls.Add(this.lblTelphone);
            this.grpInformation.Controls.Add(this.txtAddress);
            this.grpInformation.Controls.Add(this.lblAddress);
            this.grpInformation.Controls.Add(this.cmbDegree);
            this.grpInformation.Controls.Add(this.lblGender);
            this.grpInformation.Controls.Add(this.lblBirthday);
            this.grpInformation.Controls.Add(this.rdbGirl);
            this.grpInformation.Controls.Add(this.rdbBoy);
            this.grpInformation.Controls.Add(this.txtCustomerName);
            this.grpInformation.Controls.Add(this.lblName);
            this.grpInformation.Location = new System.Drawing.Point(45, 138);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(382, 464);
            this.grpInformation.TabIndex = 4;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "员工信息";
            this.grpInformation.Enter += new System.EventHandler(this.grpInformation_Enter);
            // 
            // cblocked
            // 
            this.cblocked.AutoSize = true;
            this.cblocked.Location = new System.Drawing.Point(259, 428);
            this.cblocked.Name = "cblocked";
            this.cblocked.Size = new System.Drawing.Size(72, 16);
            this.cblocked.TabIndex = 24;
            this.cblocked.Text = "是否离职";
            this.cblocked.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "营业部",
            "业务管理部",
            "R&D",
            "媒介部",
            "财务部",
            "管理本部",
            "行政部"});
            this.cmbDepartment.Location = new System.Drawing.Point(80, 424);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cmbDepartment.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "部门：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(259, 258);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(117, 21);
            this.txtPassword.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "密码：";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(249, 66);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(95, 21);
            this.txtCustomerID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "员工ID：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "入职日期：";
            // 
            // dtpRecruit
            // 
            this.dtpRecruit.Location = new System.Drawing.Point(84, 370);
            this.dtpRecruit.Name = "dtpRecruit";
            this.dtpRecruit.Size = new System.Drawing.Size(171, 21);
            this.dtpRecruit.TabIndex = 16;
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(259, 223);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(117, 21);
            this.txtExt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "分机号：";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(84, 223);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(117, 21);
            this.txtTelephone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "座机：";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(86, 66);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(95, 21);
            this.txtCustomerCode.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "员工号：";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(86, 104);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(171, 21);
            this.dtpBirthday.TabIndex = 9;
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(237, 333);
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(88, 21);
            this.numericUpDownLevel.TabIndex = 8;
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Location = new System.Drawing.Point(84, 333);
            this.numericUpDownScore.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(88, 21);
            this.numericUpDownScore.TabIndex = 8;
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.Location = new System.Drawing.Point(190, 335);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(41, 12);
            this.lblLevels.TabIndex = 7;
            this.lblLevels.Text = "级别：";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(17, 335);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 12);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "积分：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 12);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email地址：";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(84, 258);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(117, 21);
            this.txtMobilePhone.TabIndex = 6;
            // 
            // lblTelphone
            // 
            this.lblTelphone.AutoSize = true;
            this.lblTelphone.Location = new System.Drawing.Point(17, 258);
            this.lblTelphone.Name = "lblTelphone";
            this.lblTelphone.Size = new System.Drawing.Size(41, 12);
            this.lblTelphone.TabIndex = 5;
            this.lblTelphone.Text = "手机：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 181);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "通信地址：";
            // 
            // cmbDegree
            // 
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "初中/小学",
            "高中/中专",
            "本科/专科",
            "研究生以上"});
            this.cmbDegree.Location = new System.Drawing.Point(86, 141);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(175, 20);
            this.cmbDegree.TabIndex = 4;
            this.cmbDegree.SelectedIndexChanged += new System.EventHandler(this.cmbDegree_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 144);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 12);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "学历：";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(13, 104);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(65, 12);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "出生日期：";
            // 
            // rdbGirl
            // 
            this.rdbGirl.AutoSize = true;
            this.rdbGirl.Checked = true;
            this.rdbGirl.Location = new System.Drawing.Point(274, 30);
            this.rdbGirl.Name = "rdbGirl";
            this.rdbGirl.Size = new System.Drawing.Size(35, 16);
            this.rdbGirl.TabIndex = 2;
            this.rdbGirl.TabStop = true;
            this.rdbGirl.Text = "女";
            this.rdbGirl.UseVisualStyleBackColor = true;
            // 
            // rdbBoy
            // 
            this.rdbBoy.AutoSize = true;
            this.rdbBoy.Location = new System.Drawing.Point(215, 31);
            this.rdbBoy.Name = "rdbBoy";
            this.rdbBoy.Size = new System.Drawing.Size(35, 16);
            this.rdbBoy.TabIndex = 2;
            this.rdbBoy.Text = "男";
            this.rdbBoy.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(86, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(95, 21);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(260, 76);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(101, 33);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "查询";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(114, 37);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 20);
            this.cmbCustomerID.TabIndex = 6;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbcustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "员工号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(45, 628);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(101, 33);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 628);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "分机号";
            // 
            // txtSearchExt
            // 
            this.txtSearchExt.Location = new System.Drawing.Point(114, 83);
            this.txtSearchExt.Name = "txtSearchExt";
            this.txtSearchExt.Size = new System.Drawing.Size(121, 21);
            this.txtSearchExt.TabIndex = 11;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 695);
            this.Controls.Add(this.txtSearchExt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.grpInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownScore;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label lblTelphone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.RadioButton rdbGirl;
        private System.Windows.Forms.RadioButton rdbBoy;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRecruit;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cblocked;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchExt;

    }
}