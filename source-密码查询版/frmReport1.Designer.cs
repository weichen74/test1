namespace bartool
{
    partial class frmReport1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport1));
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabTotal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabIndividual = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPress = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.lblRange = new System.Windows.Forms.Label();
            this.rdbTime = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.sellmoredetailviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new bartool.DataSet1();
            this.selldetailviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selldetailview1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sell_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selldetailviewTableAdapter1 = new bartool.DataSet1TableAdapters.selldetailviewTableAdapter();
            this.tbl_sell_detailTableAdapter1 = new bartool.DataSet1TableAdapters.tbl_sell_detailTableAdapter();
            this.tblselldetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selldetailviewbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sell_detailTableAdapter = new bartool.DataSet1TableAdapters.tbl_sell_detailTableAdapter();
            this.selldetailviewTableAdapter = new bartool.DataSet1TableAdapters.selldetailviewTableAdapter();
            this.sellmoredetailviewTableAdapter = new bartool.DataSet1TableAdapters.sellmoredetailviewTableAdapter();
            this.sellmoredetailviewTableAdapter1 = new bartool.DataSet1TableAdapters.sellmoredetailviewTableAdapter();
            this.selldetailview1TableAdapter = new bartool.DataSet1TableAdapters.selldetailview1TableAdapter();
            this.tabTotal.SuspendLayout();
            this.tabIndividual.SuspendLayout();
            this.tabPress.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellmoredetailviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailview1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sell_detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblselldetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailviewbindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sellmoredetailviewBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "bartool.Report5.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowPageNavigationControls = false;
            this.reportViewer2.Size = new System.Drawing.Size(900, 500);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabTotal
            // 
            this.tabTotal.AutoScroll = true;
            this.tabTotal.Controls.Add(this.reportViewer2);
            this.tabTotal.Location = new System.Drawing.Point(4, 22);
            this.tabTotal.Name = "tabTotal";
            this.tabTotal.Size = new System.Drawing.Size(942, 524);
            this.tabTotal.TabIndex = 1;
            this.tabTotal.Text = "汇总";
            this.tabTotal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "员工姓名";
            // 
            // tabIndividual
            // 
            this.tabIndividual.AutoScroll = true;
            this.tabIndividual.Controls.Add(this.reportViewer1);
            this.tabIndividual.Location = new System.Drawing.Point(4, 22);
            this.tabIndividual.Name = "tabIndividual";
            this.tabIndividual.Size = new System.Drawing.Size(942, 524);
            this.tabIndividual.TabIndex = 0;
            this.tabIndividual.Text = "个人";
            this.tabIndividual.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sellmoredetailviewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "bartool.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(900, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(77, 115);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerCode.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "员工号";
            // 
            // tabPress
            // 
            this.tabPress.Controls.Add(this.tabIndividual);
            this.tabPress.Controls.Add(this.tabTotal);
            this.tabPress.Controls.Add(this.tabPage1);
            this.tabPress.Location = new System.Drawing.Point(21, 162);
            this.tabPress.Name = "tabPress";
            this.tabPress.SelectedIndex = 0;
            this.tabPress.Size = new System.Drawing.Size(950, 550);
            this.tabPress.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.reportViewer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 524);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "产品汇总";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.AutoScroll = true;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.selldetailviewBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "bartool.Report4.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ShowPageNavigationControls = false;
            this.reportViewer3.Size = new System.Drawing.Size(900, 500);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(406, 111);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 27);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(234, 71);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(17, 12);
            this.lblTo.TabIndex = 32;
            this.lblTo.Text = "到";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(259, 67);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(93, 21);
            this.dtpEnd.TabIndex = 30;
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(259, 29);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(47, 16);
            this.rdbDay.TabIndex = 28;
            this.rdbDay.Text = "当日";
            this.rdbDay.UseVisualStyleBackColor = true;
            this.rdbDay.CheckedChanged += new System.EventHandler(this.rdbDay_CheckedChanged);
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(200, 31);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(47, 16);
            this.rdbMonth.TabIndex = 27;
            this.rdbMonth.Text = "当月";
            this.rdbMonth.UseVisualStyleBackColor = true;
            this.rdbMonth.CheckedChanged += new System.EventHandler(this.rdbMonth_CheckedChanged);
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Location = new System.Drawing.Point(141, 31);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(47, 16);
            this.rdbYear.TabIndex = 26;
            this.rdbYear.Text = "当年";
            this.rdbYear.UseVisualStyleBackColor = true;
            this.rdbYear.CheckedChanged += new System.EventHandler(this.rdbYear_CheckedChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(13, 31);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(65, 12);
            this.lblRange.TabIndex = 24;
            this.lblRange.Text = "查看范围：";
            // 
            // rdbTime
            // 
            this.rdbTime.AutoSize = true;
            this.rdbTime.Location = new System.Drawing.Point(21, 71);
            this.rdbTime.Name = "rdbTime";
            this.rdbTime.Size = new System.Drawing.Size(95, 16);
            this.rdbTime.TabIndex = 29;
            this.rdbTime.Text = "指定时间段：";
            this.rdbTime.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(77, 31);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(47, 16);
            this.rdbAll.TabIndex = 25;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "全部";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(122, 67);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(93, 21);
            this.dtpStart.TabIndex = 31;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(259, 115);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerName.TabIndex = 38;
            // 
            // sellmoredetailviewBindingSource
            // 
            this.sellmoredetailviewBindingSource.DataMember = "sellmoredetailview";
            this.sellmoredetailviewBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selldetailviewBindingSource
            // 
            this.selldetailviewBindingSource.DataMember = "selldetailview";
            this.selldetailviewBindingSource.DataSource = this.dataSet1;
            // 
            // selldetailview1BindingSource
            // 
            this.selldetailview1BindingSource.DataMember = "selldetailview1";
            this.selldetailview1BindingSource.DataSource = this.dataSet1;
            // 
            // tbl_sell_detailBindingSource
            // 
            this.tbl_sell_detailBindingSource.DataMember = "tbl_sell_detail";
            this.tbl_sell_detailBindingSource.DataSource = this.dataSet1;
            // 
            // selldetailviewTableAdapter1
            // 
            this.selldetailviewTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_sell_detailTableAdapter1
            // 
            this.tbl_sell_detailTableAdapter1.ClearBeforeFill = true;
            // 
            // tblselldetailBindingSource
            // 
            this.tblselldetailBindingSource.DataMember = "tbl_sell_detail";
            this.tblselldetailBindingSource.DataSource = this.dataSet1;
            // 
            // selldetailviewbindingSource1
            // 
            this.selldetailviewbindingSource1.DataMember = "selldetailview";
            this.selldetailviewbindingSource1.DataSource = this.dataSet1;
            // 
            // tbl_sell_detailTableAdapter
            // 
            this.tbl_sell_detailTableAdapter.ClearBeforeFill = true;
            // 
            // selldetailviewTableAdapter
            // 
            this.selldetailviewTableAdapter.ClearBeforeFill = true;
            // 
            // sellmoredetailviewTableAdapter
            // 
            this.sellmoredetailviewTableAdapter.ClearBeforeFill = true;
            // 
            // sellmoredetailviewTableAdapter1
            // 
            this.sellmoredetailviewTableAdapter1.ClearBeforeFill = true;
            // 
            // selldetailview1TableAdapter
            // 
            this.selldetailview1TableAdapter.ClearBeforeFill = true;
            // 
            // frmReport1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 750);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabPress);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.rdbDay);
            this.Controls.Add(this.rdbMonth);
            this.Controls.Add(this.rdbYear);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.rdbTime);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.dtpStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport1";
            this.Text = "frmReport1";
            this.Load += new System.EventHandler(this.frmReport1_Load);
            this.tabTotal.ResumeLayout(false);
            this.tabIndividual.ResumeLayout(false);
            this.tabPress.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellmoredetailviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailview1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_sell_detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblselldetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailviewbindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabIndividual;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
        private System.Windows.Forms.RadioButton rdbYear;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.RadioButton rdbTime;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private bartool.DataSet1TableAdapters.selldetailviewTableAdapter selldetailviewTableAdapter1;
        private bartool.DataSet1TableAdapters.tbl_sell_detailTableAdapter tbl_sell_detailTableAdapter1;
        private System.Windows.Forms.BindingSource tblselldetailBindingSource;
        private bartool.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource selldetailviewbindingSource1;
        private System.Windows.Forms.BindingSource tbl_sell_detailBindingSource;
        private DataSet1TableAdapters.tbl_sell_detailTableAdapter tbl_sell_detailTableAdapter;
        private System.Windows.Forms.BindingSource selldetailviewBindingSource;
        private DataSet1TableAdapters.selldetailviewTableAdapter selldetailviewTableAdapter;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.BindingSource sellmoredetailviewBindingSource;
        private DataSet1TableAdapters.sellmoredetailviewTableAdapter sellmoredetailviewTableAdapter;
        private DataSet1TableAdapters.sellmoredetailviewTableAdapter sellmoredetailviewTableAdapter1;
        private System.Windows.Forms.BindingSource selldetailview1BindingSource;
        private DataSet1TableAdapters.selldetailview1TableAdapter selldetailview1TableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}