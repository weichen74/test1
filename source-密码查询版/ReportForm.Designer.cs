namespace 书店零售系统
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.lblRange = new System.Windows.Forms.Label();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbTime = new System.Windows.Forms.RadioButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabPress = new System.Windows.Forms.TabControl();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.rpvBook = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPublish = new System.Windows.Forms.TabPage();
            this.rpvPublish = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.rpVCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_BookSellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookStoreDataSet = new 书店零售系统.BookStoreDataSet();
            this.vw_BookSellTableAdapter = new 书店零售系统.BookStoreDataSetTableAdapters.vw_BookSellTableAdapter();
            this.tabPress.SuspendLayout();
            this.tabBook.SuspendLayout();
            this.tabPublish.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_BookSellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(12, 22);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(65, 12);
            this.lblRange.TabIndex = 0;
            this.lblRange.Text = "查看范围：";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(76, 22);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(47, 16);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "全部";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Location = new System.Drawing.Point(140, 22);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(47, 16);
            this.rdbYear.TabIndex = 2;
            this.rdbYear.TabStop = true;
            this.rdbYear.Text = "当年";
            this.rdbYear.UseVisualStyleBackColor = true;
            this.rdbYear.CheckedChanged += new System.EventHandler(this.rdbYear_CheckedChanged);
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(199, 22);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(47, 16);
            this.rdbMonth.TabIndex = 3;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "当月";
            this.rdbMonth.UseVisualStyleBackColor = true;
            this.rdbMonth.CheckedChanged += new System.EventHandler(this.rdbMonth_CheckedChanged);
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(258, 20);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(47, 16);
            this.rdbDay.TabIndex = 4;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "当日";
            this.rdbDay.UseVisualStyleBackColor = true;
            this.rdbDay.CheckedChanged += new System.EventHandler(this.rdbDay_CheckedChanged);
            // 
            // rdbTime
            // 
            this.rdbTime.AutoSize = true;
            this.rdbTime.Location = new System.Drawing.Point(319, 20);
            this.rdbTime.Name = "rdbTime";
            this.rdbTime.Size = new System.Drawing.Size(95, 16);
            this.rdbTime.TabIndex = 5;
            this.rdbTime.TabStop = true;
            this.rdbTime.Text = "指定时间段：";
            this.rdbTime.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(420, 16);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(93, 21);
            this.dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(552, 16);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(93, 21);
            this.dtpEnd.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(529, 19);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(17, 12);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "到";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(663, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 27);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabPress
            // 
            this.tabPress.Controls.Add(this.tabBook);
            this.tabPress.Controls.Add(this.tabPublish);
            this.tabPress.Controls.Add(this.tabCustomer);
            this.tabPress.Location = new System.Drawing.Point(14, 54);
            this.tabPress.Name = "tabPress";
            this.tabPress.SelectedIndex = 0;
            this.tabPress.Size = new System.Drawing.Size(702, 364);
            this.tabPress.TabIndex = 9;
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.rpvBook);
            this.tabBook.Location = new System.Drawing.Point(4, 22);
            this.tabBook.Name = "tabBook";
            this.tabBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabBook.Size = new System.Drawing.Size(694, 338);
            this.tabBook.TabIndex = 0;
            this.tabBook.Text = "图书";
            this.tabBook.UseVisualStyleBackColor = true;
            // 
            // rpvBook
            // 
            reportDataSource1.Name = "BookStoreDataSet_vw_BookSell";
            reportDataSource1.Value = this.vw_BookSellBindingSource;
            this.rpvBook.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBook.LocalReport.ReportEmbeddedResource = "书店零售系统.ReportBook.rdlc";
            this.rpvBook.Location = new System.Drawing.Point(0, 0);
            this.rpvBook.Name = "rpvBook";
            this.rpvBook.Size = new System.Drawing.Size(691, 335);
            this.rpvBook.TabIndex = 0;
            // 
            // tabPublish
            // 
            this.tabPublish.Controls.Add(this.rpvPublish);
            this.tabPublish.Location = new System.Drawing.Point(4, 22);
            this.tabPublish.Name = "tabPublish";
            this.tabPublish.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublish.Size = new System.Drawing.Size(694, 338);
            this.tabPublish.TabIndex = 1;
            this.tabPublish.Text = "出版社";
            this.tabPublish.UseVisualStyleBackColor = true;
            // 
            // rpvPublish
            // 
            reportDataSource2.Name = "BookStoreDataSet_vw_BookSell";
            reportDataSource2.Value = this.vw_BookSellBindingSource;
            this.rpvPublish.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvPublish.LocalReport.ReportEmbeddedResource = "书店零售系统.ReportPress.rdlc";
            this.rpvPublish.Location = new System.Drawing.Point(3, 3);
            this.rpvPublish.Name = "rpvPublish";
            this.rpvPublish.Size = new System.Drawing.Size(691, 332);
            this.rpvPublish.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.rpVCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(694, 338);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "会员";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // rpVCustomer
            // 
            reportDataSource3.Name = "BookStoreDataSet_vw_BookSell";
            reportDataSource3.Value = this.vw_BookSellBindingSource;
            this.rpVCustomer.LocalReport.DataSources.Add(reportDataSource3);
            this.rpVCustomer.LocalReport.ReportEmbeddedResource = "书店零售系统.ReportCustomer.rdlc";
            this.rpVCustomer.Location = new System.Drawing.Point(0, 0);
            this.rpVCustomer.Name = "rpVCustomer";
            this.rpVCustomer.Size = new System.Drawing.Size(691, 342);
            this.rpVCustomer.TabIndex = 0;
            // 
            // vw_BookSellBindingSource
            // 
            this.vw_BookSellBindingSource.DataMember = "vw_BookSell";
            this.vw_BookSellBindingSource.DataSource = this.BookStoreDataSet;
            // 
            // BookStoreDataSet
            // 
            this.BookStoreDataSet.DataSetName = "BookStoreDataSet";
            this.BookStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_BookSellTableAdapter
            // 
            this.vw_BookSellTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 430);
            this.Controls.Add(this.tabPress);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.rdbTime);
            this.Controls.Add(this.rdbDay);
            this.Controls.Add(this.rdbMonth);
            this.Controls.Add(this.rdbYear);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.lblRange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "统计查询";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tabPress.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            this.tabPublish.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vw_BookSellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbYear;
        private System.Windows.Forms.RadioButton rdbMonth;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbTime;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabPress;
        private System.Windows.Forms.TabPage tabBook;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBook;
        private System.Windows.Forms.TabPage tabPublish;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPublish;
        private System.Windows.Forms.TabPage tabCustomer;
        private Microsoft.Reporting.WinForms.ReportViewer rpVCustomer;
        private System.Windows.Forms.BindingSource vw_BookSellBindingSource;
        private BookStoreDataSet BookStoreDataSet;
        private 书店零售系统.BookStoreDataSetTableAdapters.vw_BookSellTableAdapter vw_BookSellTableAdapter;
    }
}