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

namespace 书店零售系统
{
    public partial class BookForm : Form
    {
        //数据库连接，数据命令，数据适配器对象
        protected SqlCommand cmd;
        protected SqlConnection conn;
        protected BookStoreDataSetTableAdapters.BookTableAdapter adapter;

        public BookForm()
        {
            InitializeComponent();
        }
        #region BookFormLoad
        /// <summary>
        /// 窗口启动时候，加载数据到DataGirdView之中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings
                    ["书店零售系统.Properties.Settings.BookStoreConnectionString"].ConnectionString);
                conn.Open();
                this.InitData();
                adapter = new 书店零售系统.BookStoreDataSetTableAdapters.BookTableAdapter();
                adapter.Fill(bookStoreDataSet1.Book );
                dgvBook.DataSource = bookStoreDataSet1.Book.DefaultView;
            }
            catch (Exception exp)
            {
                MessageBox.Show("无法建立数据库连接：" + exp.Message );
                this.Close();
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }
        #endregion

        #region InitData
        /// <summary>
        /// 在启动窗口时候，加载数据到组合框中
        /// </summary>
        protected void InitData()
        {
            cmd = new SqlCommand("select distinct Press from Book order by Press", conn );
            SqlDataReader reader = cmd.ExecuteReader();
            cmbPublish.Items.Clear();
            while (reader.Read())
                cmbPublish.Items.Add(reader[0]);
            reader.Close();

            cmd.CommandText = "select distinct BarCode from Book order by BarCode";
            reader = cmd.ExecuteReader();
            cmbBookCode.Items.Clear();
            while (reader.Read())
                cmbBookCode.Items.Add(reader[0]);
            reader.Close();
        }
        #endregion

        #region GetFilter
        /// <summary>
        /// 输入查询条件
        /// </summary>
        /// <returns></returns>
        protected string GetFilter()
        {
            StringBuilder sb = new StringBuilder();
            if (chkByName.Checked)
                sb.Append(string.Format("Name like '%{0}%'", txtByName.Text));
            if (chkByPuslish.Checked)
            {
                if (sb.Length > 0)
                    sb.Append(" AND ");
                sb.Append(string.Format("Press = '{0}'", cmbPublish.Text));
            }
            if (chkByAuthor.Checked)
            {
                if (sb.Length > 0)
                    sb.Append("AND");
                sb.Append(string.Format("Author like '%{0}%'", txtAuthor.Text));
            }

            return sb.ToString();
        }
        #endregion

        #region Search by Name, author, publish
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!chkByName.Checked && !chkByPuslish.Checked && !chkByAuthor.Checked)
            {
                MessageBox.Show("至少输入一个查询条件","温馨提示",MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
            if (chkByName.Checked && txtByName.Text == "")
            {
                MessageBox.Show("请输入书名", "温馨提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtByName.Focus();
                return;
            }
            if ( chkByPuslish.Checked && cmbPublish.Text == "")
            {
                MessageBox.Show("请输入出版社", "温馨提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbPublish.Focus();
                return;
            }
            if (chkByAuthor.Checked && txtAuthor.Text == "")
            {
                MessageBox.Show("请输入作者", "温馨提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return;
            }

            bookStoreDataSet1.Book.DefaultView.RowFilter = this.GetFilter();
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            chkByAuthor.Checked = false;
            chkByName.Checked = true;
            chkByPuslish.Checked = false;
            txtAuthor.Text = "";
            txtByName.Text = "";
            cmbPublish.Text = "";
        }
        #endregion

        /// <summary>
        /// List All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListAll_Click(object sender, EventArgs e)
        {
            bookStoreDataSet1.Book.DefaultView.RowFilter = "";
        }

        /// <summary>
        /// Locate 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocate_Click(object sender, EventArgs e)
        {
            if (cmbBookCode.Text == "")
                return;
            bookStoreDataSet1.Book.DefaultView.RowFilter = string.Format("Barcode = '{0}'",
                cmbBookCode.Text );
        }

        private void dgvBook_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("输入不合法，请重新输入。原因：" + e.Exception.Message, "警告",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

       /// <summary>
       /// 保存修改
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnSaveModify_Click(object sender, EventArgs e)
        {
            if (!bookStoreDataSet1.HasChanges())
                return;
            if (MessageBox.Show("确认保存所做的修改吗？", "提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                adapter.Update(bookStoreDataSet1.Book);
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("保存失败:" + exp.Message );
            }
        }

        /// <summary>
        /// 放弃所有的修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitSave_Click(object sender, EventArgs e)
        {
            if (!bookStoreDataSet1.HasChanges())
                return;
            if (MessageBox.Show("确认放弃上次保存以来的所有修改吗？", "提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                bookStoreDataSet1.Book.RejectChanges();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要退出系统吗？？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                this.Close();
                this.Dispose();            
            }
            else
            {
            }
                         
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
