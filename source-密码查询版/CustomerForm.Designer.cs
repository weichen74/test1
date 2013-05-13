namespace 书店零售系统
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.lblID = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScore = new System.Windows.Forms.NumericUpDown();
            this.lblLevels = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblTelphone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.rdbGirl = new System.Windows.Forms.RadioButton();
            this.rdbBoy = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 12);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "会员号：";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(75, 16);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(112, 20);
            this.cmbID.TabIndex = 1;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.dtpBirthday);
            this.grpInformation.Controls.Add(this.numericUpDownLevel);
            this.grpInformation.Controls.Add(this.numericUpDownScore);
            this.grpInformation.Controls.Add(this.lblLevels);
            this.grpInformation.Controls.Add(this.lblScore);
            this.grpInformation.Controls.Add(this.txtEmail);
            this.grpInformation.Controls.Add(this.lblEmail);
            this.grpInformation.Controls.Add(this.txtPhone);
            this.grpInformation.Controls.Add(this.lblTelphone);
            this.grpInformation.Controls.Add(this.txtAddress);
            this.grpInformation.Controls.Add(this.lblAddress);
            this.grpInformation.Controls.Add(this.cmbGender);
            this.grpInformation.Controls.Add(this.lblGender);
            this.grpInformation.Controls.Add(this.lblBirthday);
            this.grpInformation.Controls.Add(this.rdbGirl);
            this.grpInformation.Controls.Add(this.rdbBoy);
            this.grpInformation.Controls.Add(this.txtName);
            this.grpInformation.Controls.Add(this.lblName);
            this.grpInformation.Location = new System.Drawing.Point(12, 56);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(382, 330);
            this.grpInformation.TabIndex = 3;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "会员信息";
            this.grpInformation.Enter += new System.EventHandler(this.grpInformation_Enter);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(88, 77);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(171, 21);
            this.dtpBirthday.TabIndex = 9;
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(238, 291);
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(88, 21);
            this.numericUpDownLevel.TabIndex = 8;
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Location = new System.Drawing.Point(78, 291);
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
            this.lblLevels.Location = new System.Drawing.Point(191, 293);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(41, 12);
            this.lblLevels.TabIndex = 7;
            this.lblLevels.Text = "级别：";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(17, 293);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 12);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "积分：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 239);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 242);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 12);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email地址：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(90, 200);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 21);
            this.txtPhone.TabIndex = 6;
            // 
            // lblTelphone
            // 
            this.lblTelphone.AutoSize = true;
            this.lblTelphone.Location = new System.Drawing.Point(17, 203);
            this.lblTelphone.Name = "lblTelphone";
            this.lblTelphone.Size = new System.Drawing.Size(65, 12);
            this.lblTelphone.TabIndex = 5;
            this.lblTelphone.Text = "联系电话：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 163);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 166);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "通信地址：";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(90, 120);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(175, 20);
            this.cmbGender.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 12);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "学历：";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(17, 83);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(65, 12);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "出生日期：";
            // 
            // rdbGirl
            // 
            this.rdbGirl.AutoSize = true;
            this.rdbGirl.Location = new System.Drawing.Point(256, 32);
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
            this.rdbBoy.Location = new System.Drawing.Point(193, 32);
            this.rdbBoy.Name = "rdbBoy";
            this.rdbBoy.Size = new System.Drawing.Size(35, 16);
            this.rdbBoy.TabIndex = 2;
            this.rdbBoy.TabStop = true;
            this.rdbBoy.Text = "男";
            this.rdbBoy.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 21);
            this.txtName.TabIndex = 1;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(211, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增会员";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 429);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "会员管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownScore;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTelphone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.RadioButton rdbGirl;
        private System.Windows.Forms.RadioButton rdbBoy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}