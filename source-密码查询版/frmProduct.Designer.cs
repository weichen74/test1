namespace bartool
{
    partial class frmProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnQuitSave = new System.Windows.Forms.Button();
            this.btnSaveModify = new System.Windows.Forms.Button();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.chkByName = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new bartool.DataSet1();
            this.tbl_productTableAdapter = new bartool.DataSet1TableAdapters.tbl_productTableAdapter();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 27);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(84, 66);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(119, 20);
            this.cmbCategory.TabIndex = 24;
            // 
            // btnQuitSave
            // 
            this.btnQuitSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitSave.Location = new System.Drawing.Point(459, 487);
            this.btnQuitSave.Name = "btnQuitSave";
            this.btnQuitSave.Size = new System.Drawing.Size(95, 29);
            this.btnQuitSave.TabIndex = 22;
            this.btnQuitSave.Text = "放弃修改";
            this.btnQuitSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveModify
            // 
            this.btnSaveModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModify.Location = new System.Drawing.Point(329, 487);
            this.btnSaveModify.Name = "btnSaveModify";
            this.btnSaveModify.Size = new System.Drawing.Size(95, 29);
            this.btnSaveModify.TabIndex = 23;
            this.btnSaveModify.Text = "保存修改";
            this.btnSaveModify.UseVisualStyleBackColor = true;
            this.btnSaveModify.Click += new System.EventHandler(this.btnSaveModify_Click);
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(-63, 474);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(53, 12);
            this.lblBookCode.TabIndex = 19;
            this.lblBookCode.Text = "图书条码";
            // 
            // btnListAll
            // 
            this.btnListAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAll.Location = new System.Drawing.Point(352, 96);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(102, 27);
            this.btnListAll.TabIndex = 16;
            this.btnListAll.Text = "显示所有";
            this.btnListAll.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(228, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 27);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(84, 19);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(103, 21);
            this.txtProductName.TabIndex = 15;
            // 
            // chkByName
            // 
            this.chkByName.AutoSize = true;
            this.chkByName.Location = new System.Drawing.Point(-72, 69);
            this.chkByName.Name = "chkByName";
            this.chkByName.Size = new System.Drawing.Size(72, 16);
            this.chkByName.TabIndex = 13;
            this.chkByName.Text = "按书名：";
            this.chkByName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(84, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 27);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToOrderColumns = true;
            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.productnameDataGridViewTextBoxColumn,
            this.productcategoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.productdescDataGridViewTextBoxColumn});
            this.dgvBook.DataSource = this.tblproductBindingSource;
            this.dgvBook.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvBook.Location = new System.Drawing.Point(12, 141);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(747, 319);
            this.dgvBook.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "产品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "类别";
            // 
            // tblproductBindingSource
            // 
            this.tblproductBindingSource.DataMember = "tbl_product";
            this.tblproductBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_productTableAdapter
            // 
            this.tbl_productTableAdapter.ClearBeforeFill = true;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "product_id";
            this.product_id.Name = "product_id";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // productcategoryDataGridViewTextBoxColumn
            // 
            this.productcategoryDataGridViewTextBoxColumn.DataPropertyName = "product_category";
            this.productcategoryDataGridViewTextBoxColumn.HeaderText = "product_category";
            this.productcategoryDataGridViewTextBoxColumn.Name = "productcategoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // productdescDataGridViewTextBoxColumn
            // 
            this.productdescDataGridViewTextBoxColumn.DataPropertyName = "product_desc";
            this.productdescDataGridViewTextBoxColumn.HeaderText = "product_desc";
            this.productdescDataGridViewTextBoxColumn.Name = "productdescDataGridViewTextBoxColumn";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(837, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnQuitSave);
            this.Controls.Add(this.btnSaveModify);
            this.Controls.Add(this.lblBookCode);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.chkByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnQuitSave;
        private System.Windows.Forms.Button btnSaveModify;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.CheckBox chkByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBook;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private DataSet1TableAdapters.tbl_productTableAdapter tbl_productTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescDataGridViewTextBoxColumn;
    }
}