namespace 书店零售系统
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkByName = new System.Windows.Forms.CheckBox();
            this.txtByName = new System.Windows.Forms.TextBox();
            this.chkByAuthor = new System.Windows.Forms.CheckBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.chkByPuslish = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.cmbBookCode = new System.Windows.Forms.ComboBox();
            this.btnLocate = new System.Windows.Forms.Button();
            this.btnSaveModify = new System.Windows.Forms.Button();
            this.btnQuitSave = new System.Windows.Forms.Button();
            this.cmbPublish = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dgvBook.DataMember = "Book";
            this.dgvBook.Location = new System.Drawing.Point(3, 75);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(747, 319);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            this.dgvBook.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBook_DataError);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // chkByName
            // 
            this.chkByName.AutoSize = true;
            this.chkByName.Location = new System.Drawing.Point(12, 12);
            this.chkByName.Name = "chkByName";
            this.chkByName.Size = new System.Drawing.Size(72, 16);
            this.chkByName.TabIndex = 1;
            this.chkByName.Text = "按书名：";
            this.chkByName.UseVisualStyleBackColor = true;
            // 
            // txtByName
            // 
            this.txtByName.Location = new System.Drawing.Point(87, 10);
            this.txtByName.Name = "txtByName";
            this.txtByName.Size = new System.Drawing.Size(103, 21);
            this.txtByName.TabIndex = 2;
            // 
            // chkByAuthor
            // 
            this.chkByAuthor.AutoSize = true;
            this.chkByAuthor.Location = new System.Drawing.Point(436, 14);
            this.chkByAuthor.Name = "chkByAuthor";
            this.chkByAuthor.Size = new System.Drawing.Size(72, 16);
            this.chkByAuthor.TabIndex = 1;
            this.chkByAuthor.Text = "按作者：";
            this.chkByAuthor.UseVisualStyleBackColor = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(511, 12);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(103, 21);
            this.txtAuthor.TabIndex = 2;
            // 
            // chkByPuslish
            // 
            this.chkByPuslish.AutoSize = true;
            this.chkByPuslish.Location = new System.Drawing.Point(217, 12);
            this.chkByPuslish.Name = "chkByPuslish";
            this.chkByPuslish.Size = new System.Drawing.Size(84, 16);
            this.chkByPuslish.TabIndex = 1;
            this.chkByPuslish.Text = "按出版社：";
            this.chkByPuslish.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(12, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(140, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 27);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAll.Location = new System.Drawing.Point(274, 39);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(102, 27);
            this.btnListAll.TabIndex = 3;
            this.btnListAll.Text = "显示所有";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(21, 417);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(53, 12);
            this.lblBookCode.TabIndex = 4;
            this.lblBookCode.Text = "图书条码";
            // 
            // cmbBookCode
            // 
            this.cmbBookCode.FormattingEnabled = true;
            this.cmbBookCode.Location = new System.Drawing.Point(75, 415);
            this.cmbBookCode.Name = "cmbBookCode";
            this.cmbBookCode.Size = new System.Drawing.Size(131, 20);
            this.cmbBookCode.TabIndex = 5;
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(219, 410);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(66, 29);
            this.btnLocate.TabIndex = 6;
            this.btnLocate.Text = "定位";
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // btnSaveModify
            // 
            this.btnSaveModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModify.Location = new System.Drawing.Point(413, 410);
            this.btnSaveModify.Name = "btnSaveModify";
            this.btnSaveModify.Size = new System.Drawing.Size(95, 29);
            this.btnSaveModify.TabIndex = 7;
            this.btnSaveModify.Text = "保存修改";
            this.btnSaveModify.UseVisualStyleBackColor = true;
            this.btnSaveModify.Click += new System.EventHandler(this.btnSaveModify_Click);
            // 
            // btnQuitSave
            // 
            this.btnQuitSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitSave.Location = new System.Drawing.Point(544, 409);
            this.btnQuitSave.Name = "btnQuitSave";
            this.btnQuitSave.Size = new System.Drawing.Size(95, 29);
            this.btnQuitSave.TabIndex = 7;
            this.btnQuitSave.Text = "放弃修改";
            this.btnQuitSave.UseVisualStyleBackColor = true;
            this.btnQuitSave.Click += new System.EventHandler(this.btnQuitSave_Click);
            // 
            // cmbPublish
            // 
            this.cmbPublish.FormattingEnabled = true;
            this.cmbPublish.Location = new System.Drawing.Point(295, 12);
            this.cmbPublish.Name = "cmbPublish";
            this.cmbPublish.Size = new System.Drawing.Size(119, 20);
            this.cmbPublish.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(658, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 453);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbPublish);
            this.Controls.Add(this.btnQuitSave);
            this.Controls.Add(this.btnSaveModify);
            this.Controls.Add(this.btnLocate);
            this.Controls.Add(this.cmbBookCode);
            this.Controls.Add(this.lblBookCode);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkByPuslish);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.chkByAuthor);
            this.Controls.Add(this.txtByName);
            this.Controls.Add(this.chkByName);
            this.Controls.Add(this.dgvBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.CheckBox chkByName;
        private System.Windows.Forms.TextBox txtByName;
        private System.Windows.Forms.CheckBox chkByAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.CheckBox chkByPuslish;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.ComboBox cmbBookCode;
        private System.Windows.Forms.Button btnLocate;
        private System.Windows.Forms.Button btnSaveModify;
        private System.Windows.Forms.Button btnQuitSave;
        private BookStoreDataSet bookStoreDataSet1;
        private System.Windows.Forms.ComboBox cmbPublish;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageDataGridViewTextBoxColumn;
    }
}