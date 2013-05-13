namespace bartool
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabPress = new System.Windows.Forms.TabControl();
            this.tabIndividual = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabTotal = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.lblRange = new System.Windows.Forms.Label();
            this.rdbTime = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selldetailviewTableAdapter1 = new bartool.DataSet1TableAdapters.selldetailviewTableAdapter();
            this.tbl_sell_detailTableAdapter1 = new bartool.DataSet1TableAdapters.tbl_sell_detailTableAdapter();
            this.tabPress.SuspendLayout();
            this.tabIndividual.SuspendLayout();
            this.tabTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPress
            // 
            this.tabPress.Controls.Add(this.tabIndividual);
            this.tabPress.Controls.Add(this.tabTotal);
            this.tabPress.Location = new System.Drawing.Point(28, 121);
            this.tabPress.Name = "tabPress";
            this.tabPress.SelectedIndex = 0;
            this.tabPress.Size = new System.Drawing.Size(825, 459);
            this.tabPress.TabIndex = 20;
            // 
            // tabIndividual
            // 
            this.tabIndividual.Controls.Add(this.reportViewer1);
            this.tabIndividual.Location = new System.Drawing.Point(4, 22);
            this.tabIndividual.Name = "tabIndividual";
            this.tabIndividual.Size = new System.Drawing.Size(817, 433);
            this.tabIndividual.TabIndex = 0;
            this.tabIndividual.Text = "个人";
            this.tabIndividual.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "bartool.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(817, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabTotal
            // 
            this.tabTotal.Controls.Add(this.reportViewer2);
            this.tabTotal.Location = new System.Drawing.Point(4, 22);
            this.tabTotal.Name = "tabTotal";
            this.tabTotal.Size = new System.Drawing.Size(817, 433);
            this.tabTotal.TabIndex = 1;
            this.tabTotal.Text = "汇总";
            this.tabTotal.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "bartool.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(811, 267);
            this.reportViewer2.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(434, 68);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 27);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(543, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(17, 12);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "到";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(566, 26);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(93, 21);
            this.dtpEnd.TabIndex = 16;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(434, 26);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(93, 21);
            this.dtpStart.TabIndex = 17;
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(272, 30);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(47, 16);
            this.rdbDay.TabIndex = 14;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "当日";
            this.rdbDay.UseVisualStyleBackColor = true;
            this.rdbDay.CheckedChanged += new System.EventHandler(this.rdbDay_CheckedChanged);
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(213, 32);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(47, 16);
            this.rdbMonth.TabIndex = 13;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "当月";
            this.rdbMonth.UseVisualStyleBackColor = true;
            this.rdbMonth.CheckedChanged += new System.EventHandler(this.rdbMonth_CheckedChanged);
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Location = new System.Drawing.Point(154, 32);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(47, 16);
            this.rdbYear.TabIndex = 12;
            this.rdbYear.TabStop = true;
            this.rdbYear.Text = "当年";
            this.rdbYear.UseVisualStyleBackColor = true;
            this.rdbYear.CheckedChanged += new System.EventHandler(this.rdbYear_CheckedChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(26, 32);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(65, 12);
            this.lblRange.TabIndex = 10;
            this.lblRange.Text = "查看范围：";
            // 
            // rdbTime
            // 
            this.rdbTime.AutoSize = true;
            this.rdbTime.Location = new System.Drawing.Point(333, 30);
            this.rdbTime.Name = "rdbTime";
            this.rdbTime.Size = new System.Drawing.Size(95, 16);
            this.rdbTime.TabIndex = 15;
            this.rdbTime.TabStop = true;
            this.rdbTime.Text = "指定时间段：";
            this.rdbTime.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(90, 32);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(47, 16);
            this.rdbAll.TabIndex = 11;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "全部";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "员工号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "员工姓名";
            // 
            // selldetailviewTableAdapter1
            // 
            this.selldetailviewTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_sell_detailTableAdapter1
            // 
            this.tbl_sell_detailTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabPress);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.rdbDay);
            this.Controls.Add(this.rdbMonth);
            this.Controls.Add(this.rdbYear);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.rdbTime);
            this.Controls.Add(this.rdbAll);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.tabPress.ResumeLayout(false);
            this.tabIndividual.ResumeLayout(false);
            this.tabTotal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
        private System.Windows.Forms.RadioButton rdbYear;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.RadioButton rdbTime;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.TabPage tabIndividual;
        private System.Windows.Forms.TabPage tabTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;

        
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;




        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DataSet1TableAdapters.selldetailviewTableAdapter selldetailviewTableAdapter1;
        private DataSet1TableAdapters.tbl_sell_detailTableAdapter tbl_sell_detailTableAdapter1;

 

      
    }
}