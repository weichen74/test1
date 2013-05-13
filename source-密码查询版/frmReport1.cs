using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace bartool
{
    public partial class frmReport1 : Form
    {
        public frmReport1()
        {
            InitializeComponent();
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                string sCustomerCode = txtCustomerCode.Text;
                string sCustomerName = txtCustomerName.Text;
                string searchstr = "";
                if (sCustomerCode != "")
                {
                    searchstr = searchstr + " and customer_code='" + sCustomerCode + "' ";
                }
                if (sCustomerName != "")
                {
                    searchstr = searchstr + " and customer_name like '%" + sCustomerName + "%' ";
                }
                this.dataSet1.sellmoredetailview.DefaultView.RowFilter = "";
                this.RefreshReports();
            }
        }

        protected void RefreshReports()
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();

        }

        private void rdbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYear.Checked)
            {
                string sCustomerCode = txtCustomerCode.Text;
                string sCustomerName = txtCustomerName.Text;
                string searchstr = "";
                if (sCustomerCode != "")
                {
                    searchstr = searchstr + " and customer_code='" + sCustomerCode + "' ";
                }
                if (sCustomerName != "")
                {
                    searchstr = searchstr + " and customer_name like '%" + sCustomerName + "%' ";
                }
                string strFilter = string.Format("Create_Date>'1/1/{0}' AND Create_Date< '12/31/{0} 23:59:59'" + searchstr,
                    DateTime.Now.Year);
                this.dataSet1.sellmoredetailview.DefaultView.RowFilter = strFilter;

                string strFilterTotal = string.Format("Create_Date>'1/1/{0}' AND Create_Date< '12/31/{0} 23:59:59'" + searchstr,
                    DateTime.Now.Year);
                this.dataSet1.selldetailview.DefaultView.RowFilter = strFilterTotal;

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
                string sCustomerCode = txtCustomerCode.Text;
                string sCustomerName = txtCustomerName.Text;
                string searchstr = "";
                if (sCustomerCode != "")
                {
                    searchstr = searchstr + " and customer_code='" + sCustomerCode + "' ";
                }
                if (sCustomerName != "")
                {
                    searchstr = searchstr + " and customer_name like '%" + sCustomerName + "%' ";
                }
                string strFilter = string.Format("Create_Date>'{0}/1/{1}' and Create_Date<'{0}/{2}/{1} 23:59:59'" + searchstr, iMonth, iYear, iLastDay);
                this.dataSet1.sellmoredetailview.DefaultView.RowFilter = strFilter;


                string strFilterTotal = string.Format("Create_Date>'{0}/1/{1}' and Create_Date<'{0}/{2}/{1} 23:59:59'" + searchstr, iMonth, iYear, iLastDay);
                this.dataSet1.selldetailview.DefaultView.RowFilter = strFilterTotal;

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
                string sCustomerCode = txtCustomerCode.Text;
                string sCustomerName = txtCustomerName.Text;
                string searchstr = "";
                if (sCustomerCode != "")
                {
                    searchstr = searchstr + " and customer_code='" + sCustomerCode + "' ";
                }
                if (sCustomerName != "")
                {
                    searchstr = searchstr + " and customer_name like '%" + sCustomerName + "%' ";
                }

                string strFilter = string.Format("Create_Date>'{0}/{1}/{2} 00:00:00' and Create_Date<'{0}/{1}/{2} 23:59:59' " + searchstr, iMonth, iDay, iYear);
                this.dataSet1.sellmoredetailview.DefaultView.RowFilter = strFilter;

                string strFilterTotal = string.Format("Create_Date>'{0}/{1}/{2} 00:00:00' and Create_Date<'{0}/{1}/{2} 23:59:59' " + searchstr, iMonth, iDay, iYear);
                this.dataSet1.selldetailview.DefaultView.RowFilter = strFilterTotal;

               
                this.RefreshReports();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sCustomerCode = txtCustomerCode.Text;
            string sCustomerName = txtCustomerName.Text;
            string searchstr = "";
            if (sCustomerCode != "")
            {
                searchstr = searchstr + " and customer_code='" + sCustomerCode + "' ";
            }
            if (sCustomerName != "")
            {
                searchstr = searchstr + " and customer_name like '%" + sCustomerName  + "%' ";
            }
            string strFilter = string.Format("Create_Date>'{0} 00:00:00'and Create_Date <'{1} 23:59:59'" + searchstr, dtpStart.Value.ToString("d"),
           dtpEnd.Value.ToString("d"));
            this.dataSet1.sellmoredetailview.DefaultView.RowFilter = strFilter;


            string strFilterTotal = string.Format("Create_Date>'{0} 00:00:00'and Create_Date <'{1} 23:59:59'" + searchstr, dtpStart.Value.ToString("d"),
          dtpEnd.Value.ToString("d"));
            this.dataSet1.selldetailview.DefaultView.RowFilter = strFilterTotal;

            this.RefreshReports();
        }

      
        private void frmReport1_Load(object sender, EventArgs e)
        {
            try
            {
                sellmoredetailviewTableAdapter1.Fill(this.dataSet1.sellmoredetailview);
                this.reportViewer1.LocalReport.DataSources[0].Value =
                    this.dataSet1.sellmoredetailview.DefaultView;
               
                selldetailviewTableAdapter1.Fill(this.dataSet1.selldetailview);
                this.reportViewer2.LocalReport.DataSources[0].Value =
                    this.dataSet1.selldetailview.DefaultView;

                this.reportViewer3.LocalReport.DataSources[0].Value =
                    this.dataSet1.selldetailview.DefaultView;

                this.RefreshReports();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + exp.StackTrace);
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }

     
    }
}
