using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//download by http://www.codefans.net
namespace bartool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmProduct myProductForm = new frmProduct();
            myProductForm.Show();
        }

        private void btnHuiyuan_Click(object sender, EventArgs e)
        {
            frmCustomer myCusotmerForm = new frmCustomer();
            myCusotmerForm.Show();
        }

        private void btnShouyin_Click(object sender, EventArgs e)
        {
            frmSell mySellForm = new frmSell();
            mySellForm.Show();
        }

        private void btnTongji_Click(object sender, EventArgs e)
        {
            frmReport1 myReportForm = new frmReport1();
            myReportForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
