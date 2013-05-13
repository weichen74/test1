using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace bartool
{
    public partial class frmProduct : Form
    {

        //数据库连接，数据命令，数据适配器对象
        protected OleDbCommand cmd;
        protected OleDbConnection conn;
        protected DataSet1TableAdapters.tbl_productTableAdapter adapter;
        protected DataSet1.tbl_productDataTable producttable;
       

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.tbl_product”中。您可以根据需要移动或删除它。
            this.tbl_productTableAdapter.Fill(this.dataSet1.tbl_product);
            try
            {
                conn = new OleDbConnection(ConfigurationManager.ConnectionStrings
                    ["ConnectionString"].ConnectionString);
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                this.InitData();
                //adapter = new bartool.DataSet1TableAdapters.tbl_productTableAdapter();
                OleDbCommandBuilder scb = new OleDbCommandBuilder(this.tbl_productTableAdapter.Adapter);
                //producttable = new bartool.DataSet1.tbl_productDataTable();
                //adapter.Fill(producttable);
                //dgvBook.DataSource = producttable.DefaultView;
            }
            catch (Exception exp)
            {
                MessageBox.Show("无法建立数据库连接：" + exp.Message);
                this.Close();
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        #region InitData
        /// <summary>
        /// 在启动窗口时候，加载数据到组合框中
        /// </summary>
        protected void InitData()
        {
            //cmd = new SqlCommand("select distinct product_id from tbl_product  order by product_id", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //txtProductName.Items.Clear();
            //while (reader.Read())
            //    cmbCategory.Items.Add(reader[0]);
            //reader.Close();

            cmd.CommandText = "select category_id,category_name from tbl_category order by category_id asc";
            OleDbDataReader reader = cmd.ExecuteReader();
            cmbCategory.Items.Clear();
            while (reader.Read())
                cmbCategory.Items.Add(reader[0]+":"+reader[1]);
            reader.Close();
        }
        #endregion

        private void btnSaveModify_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("确认保存所做的修改吗？", "提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
               
                OleDbCommandBuilder odb = new OleDbCommandBuilder(this.tbl_productTableAdapter.Adapter);
                this.tbl_productTableAdapter.Adapter.DeleteCommand = odb.GetDeleteCommand();
                this.tbl_productTableAdapter.Adapter.InsertCommand = odb.GetInsertCommand();
                this.tbl_productTableAdapter.Adapter.UpdateCommand = odb.GetUpdateCommand();
                this.tbl_productTableAdapter.Adapter.Update(dataSet1.tbl_product);
                dataSet1.AcceptChanges();
                dataSet1.tbl_product.AcceptChanges();
               // this.tbl_productTableAdapter.Adapter.Update(dataSet1.tbl_product);


               
               
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("保存失败:" + exp.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchstr = "1=1";
            if (txtProductName.Text != "")
            {
                searchstr =searchstr + " and product_name like '%" + txtProductName.Text + "%'";
            }
            if (cmbCategory.Text != "")
            {
                searchstr = searchstr +  " and product_category =" + cmbCategory.Text.Split(':')[0] + "";
            }
            string strFilter = string.Format(searchstr);
            this.dataSet1.tbl_product.DefaultView.RowFilter = strFilter;
            dgvBook.DataSource = this.dataSet1.tbl_product.DefaultView;
            dgvBook.Refresh();
        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
                conn.Close();
        }
    }
}
