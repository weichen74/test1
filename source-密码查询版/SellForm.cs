using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
//download by http://www.codefans.net
namespace 书店零售系统
{
    public partial class SellForm : Form
    {
        /// <summary>
        /// IDNUMER 是为系统生成的一个序列号，如1017103654表示是10月17号10:36:54时刻
        /// 进行的一个交易，此方法不是太科学，如如果到下年的这个时候还是同一时刻进行的交易
        /// 就会存在冲突，解决方法是可以在前面加上年份，或者是将当初的ID设置为nvarchar类型
        /// </summary>
        protected int IDNUMBER = DateTime.Now.Month * 100000000 + DateTime.Now.Day * 1000000 + DateTime.Now.Hour * 10000
                + DateTime.Now.Minute * 100 + DateTime.Now.Second;
        /// <summary>
        /// 建立的一些ＳＱＬ对象
        /// </summary>
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected BookStoreDataSetTableAdapters.SellTableAdapter sellAdapter;
        protected BookStoreDataSetTableAdapters.SellItemTableAdapter sellItemAdapter;
        protected int sellID;
        protected decimal total;


        public SellForm()
        {
            InitializeComponent();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["书店零售系统.Properties.Settings.BookStoreConnectionString"].ConnectionString);
                cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                this.InitData();
                sellAdapter = new 书店零售系统.BookStoreDataSetTableAdapters.SellTableAdapter();
                sellItemAdapter = new 书店零售系统.BookStoreDataSetTableAdapters.SellItemTableAdapter();//5|1|a|s|p|x
                this.printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("BookList", 320, 480);
            }
            catch (Exception exp)
            {
                MessageBox.Show("无法建立数据库连接:" + exp.Message);
                this.Close();
            }

        }

        private void SellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
                conn.Close();
        }

        /// <summary>
        /// 初始化数据，让会员号，图书条码都有相应的信息
        /// </summary>
        protected void InitData()
        {
            cmd.CommandText = "select distinct ID from Customer order by ID";
            SqlDataReader reader = cmd.ExecuteReader();
            cmbCustomerID.Items.Clear();
            while (reader.Read())
                cmbCustomerID.Items.Add(reader[0]);
            reader.Close();

            cmd.CommandText = "select distinct Barcode from Book order by Barcode";
            reader = cmd.ExecuteReader();
            cmbBarcode.Items.Clear();
            while (reader.Read())
                cmbBarcode.Items.Add(reader[0]);
            reader.Close();

        }

        /// <summary>
        ///通过会员号来检查会员以及享受的折扣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbCustomerID.Text == "")
                return;
            cmd.CommandText = "select Levels from Customer where ID = " + cmbCustomerID.Text;
            object oLevel = cmd.ExecuteScalar();
            if (oLevel == null)
            {
                MessageBox.Show("无此会员记录", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudDiscount.Value = 1;
            }
            else
            {
                cmd.CommandText = "select Discount from Discount where Levels = " + oLevel.ToString();
                nudDiscount.Value = (decimal)((double)cmd.ExecuteScalar());
            }
        }

        /// <summary>
        /// 添加选定的书名到购物清单，但是目前还不能重复添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBarcode.Text == "")
                return;
            if (!chkCustomerID.Checked)
                nudDiscount.Value = 1;
            cmd.CommandText = string.Format("select ID, ISBN, Name, Price from Book where Barcode = '{0}'", cmbBarcode.Text);
            SqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    BookStoreDataSet.p_getSellDetailRow row = bookStoreDataSet1.p_getSellDetail.Newp_getSellDetailRow();
                    row.BookID = (int)reader["ID"];
                    row.ISBN = (string)reader["ISBN"];
                    row.Name = (string)reader["Name"];//5+1+a+s+p+x
                    row.Price = (decimal)reader["Price"];
                    row.Number = (int)nudNumber.Value;
                    row.Discount = (double)nudDiscount.Value ;
                    row.Sum = (decimal)((double)row.Price * row.Number * row.Discount);
                    bookStoreDataSet1.p_getSellDetail.Addp_getSellDetailRow(row);
                }
                else
                {
                    MessageBox.Show("没有符合条件的记录","提示",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据访问错误：" + exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }
        }

        /// <summary>
        /// 打印小票
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (bookStoreDataSet1.p_getSellDetail.Count == 0)
                return;
            this.total = 0;
            for (int i = 0; i < bookStoreDataSet1.p_getSellDetail.Count; i++)
                this.total += bookStoreDataSet1.p_getSellDetail[i].Sum;
            string sMsg = string.Format("合计金额为￥{0}元。是否打印小票？",this.total);
            DialogResult dr = MessageBox.Show(sMsg, "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
                return;
            try
            {
                if (chkCustomerID.Checked)
                    this.SaveDate(int.Parse(cmbCustomerID.Text));
                else
                    this.SaveDate(-1);

                if (dr == DialogResult.Yes)
                    this.printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show("交易失败：" + exp.Message , "错误", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            bookStoreDataSet1.Clear();
        }

        protected void SaveDate(int customerID)
        {
            BookStoreDataSet.SellRow row = bookStoreDataSet1.Sell.NewSellRow();
            if (customerID > 0)
                row.CustomerID = customerID;
            row.Sum = this.total;
            row.Time = DateTime.Now;
            row.ID = IDNUMBER++;
            

            bookStoreDataSet1.Sell.AddSellRow(row);
            sellAdapter.Update(bookStoreDataSet1.Sell);
            this.sellID = row.ID;
            BookStoreDataSet.SellItemRow row1;
            for (int i = 0; i < bookStoreDataSet1.p_getSellDetail.Count; i++)
            {
                row1 = bookStoreDataSet1.SellItem.NewSellItemRow();
                row1.ID = IDNUMBER;
                row1.BookID = bookStoreDataSet1.p_getSellDetail[i].BookID;
                row1.Number = bookStoreDataSet1.p_getSellDetail[i].Number;//5!1^a^s^p^x
                row1.Discount = bookStoreDataSet1.p_getSellDetail[i].Discount;
                row1.Sum = bookStoreDataSet1.p_getSellDetail[i].Sum;
                row1.SellRow = row;
                bookStoreDataSet1.SellItem.AddSellItemRow(row1);
            }

            sellItemAdapter.Update(bookStoreDataSet1.SellItem);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("微软雅黑", 8);
            Font font1 = new Font("华文行楷", 18);

            e.Graphics.DrawString("古今书屋", font1, Brushes.Red, 100, 15);
            e.Graphics.DrawString("时间：" + DateTime.Now.ToLongDateString(), font, Brushes.Black, 20,40);
            e.Graphics.DrawString("交易号：" + this.sellID.ToString(), font, Brushes.Black, 200, 40);

            if (chkCustomerID.Checked)
                e.Graphics.DrawString("会员号：" + cmbCustomerID.Text.ToString(), font, Brushes.Black, 20, 60);

            e.Graphics.DrawString("收银员：" + this.sellID.ToString(), font, Brushes.Black, 200, 60);
            e.Graphics.DrawString("书名：", font, Brushes.Black, 20, 80);
            e.Graphics.DrawString("单价：", font, Brushes.Black, 160, 80);
            e.Graphics.DrawString("数量：", font, Brushes.Black, 200, 80);
            e.Graphics.DrawString("折扣：", font, Brushes.Black, 230, 80);
            e.Graphics.DrawString("金额：", font, Brushes.Black, 270, 80);
            e.Graphics.DrawString("-----------------------------------------------------------",font , Brushes.Black, 10, 90);
            int i;
            BookStoreDataSet.p_getSellDetailRow row;
            for ( i = 0; i < bookStoreDataSet1.p_getSellDetail.Count; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), font, Brushes.Black, 10, 100 + 20 * i);
                row = bookStoreDataSet1.p_getSellDetail[i];//5*1*a*s*p*x
                string strBook = row.Name;
                if (strBook.Length > 12)
                    strBook = strBook.Substring(0,12);
                e.Graphics.DrawString(strBook, font, Brushes.Black, 20, 100 + 20 * i);
                e.Graphics.DrawString(row.Price.ToString().Substring(0,5), font, Brushes.Black, 160, 100 + 20 * i);
                e.Graphics.DrawString(row.Number.ToString(), font, Brushes.Black, 200, 100 + 20 * i);
                e.Graphics.DrawString(row.Discount.ToString(), font, Brushes.Black, 230, 100 + 20 * i);
                e.Graphics.DrawString(row.Sum.ToString(), font, Brushes.Black, 270, 100 + 20 * i);
            }

            e.Graphics.DrawString("-----------------------------------------------------------", font, Brushes.Black, 10, 90 + 20 * i );
            e.Graphics.DrawString("合计", font, Brushes.Black, 20, 100 + 20 * i);
            e.Graphics.DrawString(this.total.ToString(), font, Brushes.Black, 270, 100 + 20 * i);
            e.Graphics.DrawString("谢谢惠顾，欢迎再来！", font, Brushes.Black, 20, 120 + 20 * i);


        }

      
        private void btnReset_Click(object sender, EventArgs e)
        {
            bookStoreDataSet1.p_getSellDetail.Clear();
            chkCustomerID.Checked = false;
            cmbCustomerID.Text = "";
            cmbBarcode.Text = "";
            nudDiscount.Value = 0;
            nudNumber.Value = 0;
            cmbCustomerID.Focus();//5_1_a_s_p_x
        }

    }

}
