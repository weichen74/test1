using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//download by http://www.codefans.net
namespace 书店零售系统
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.vw_BookSellTableAdapter.Fill(this.BookStoreDataSet.vw_BookSell);
                this.rpvBook.LocalReport.DataSources[0].Value =
                    this.BookStoreDataSet.vw_BookSell.DefaultView;
                this.rpvPublish.LocalReport.DataSources[0].Value =
                    this.BookStoreDataSet.vw_BookSell.DefaultView;
                this.rpVCustomer.LocalReport.DataSources[0].Value =
                    this.rpVCustomer.LocalReport.DataSources;

                this.RefreshReports();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + exp.StackTrace);
            }
        }

        protected void RefreshReports()
        {
            this.rpvBook.RefreshReport();
            this.rpvPublish.RefreshReport();
            this.rpVCustomer.RefreshReport();
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                this.BookStoreDataSet.vw_BookSell.DefaultView.RowFilter = "";
                this.RefreshReports();
            }
        }

        private void rdbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYear.Checked)
            {
                string strFilter = string.Format("TIME>'1/1/{0}' AND TIME< '12/31/{0} 23:59:59'", 
                    DateTime.Now.Year);
                this.BookStoreDataSet.vw_BookSell.DefaultView.RowFilter = strFilter;
                this.RefreshReports();
            }
        }

        private void rdbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMonth.Checked)
            {
                int iYear = DateTime.Now.Year;
                int iMonth = DateTime.Now.Month;
                int iLastDay = DateTime.DaysInMonth(iYear, iMonth);//5%1%a%s%p%x

                string strFilter = string.Format("TIME>'{0}/1/{1}' and TIME<'{0}/{2}/{1} 23:59:59'", iMonth, iYear, iLastDay);
                this.BookStoreDataSet.vw_BookSell.DefaultView.RowFilter = strFilter;
                this.RefreshReports();
            }
        }

        private void rdbDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDay.Checked)
            {
                int iYear = DateTime.Now.Year;
                int iMonth = DateTime.Now.Month;
                int iDay = DateTime.Now.Day;

                string strFilter = string.Format("TIME>'{0}/{1}/{2} 00:00:00' and TIME<'{0}/{1}/{2} 23:59:59'", iMonth, iDay, iYear);
                this.BookStoreDataSet.vw_BookSell.DefaultView.RowFilter = strFilter;
                this.RefreshReports();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strFilter = string.Format("TIME>'{0} 00:00:00'and TIME <'{1} 23:59:59'",dtpStart.Value.ToString("d"),
            dtpEnd.Value.ToString("d"));
            this.BookStoreDataSet.vw_BookSell.DefaultView.RowFilter = strFilter;
            this.RefreshReports();
        }
       
    }
}
