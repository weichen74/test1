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
    public partial class frmSell : Form
    {

        protected OleDbConnection conn;
        protected OleDbCommand cmd;
        protected DataSet1TableAdapters.tbl_sell_detailTableAdapter adapter;
        protected DataSet1.tbl_sell_detailDataTable selltable;
        protected int sellID;
        protected decimal total;
        protected bool isLogined=false;
       

        public frmSell()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (cmbCustomerCode.Text == "")
                return;
            cmd.CommandText = "select * from tbl_Customer where customer_code ='"
                + cmbCustomerCode.Text.Trim()+"' and password='"+maskedPassword.Text.Trim()+"'";
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["islocked"].ToString() == "1")
                    {
                        MessageBox.Show("该用户已离职", "提示",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        isLogined = true;
                        changebtnstatus();
                        lblCustomerCode.Text = cmbCustomerCode.Text.Trim();
                        lblCustomerName.Text = reader["Customer_Name"].ToString();
                        lblSumMoney.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("密码不对，请重新输入", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据访问错误：" + exp.Message + exp.StackTrace,
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }
        }

        private void changebtnstatus()
        {
            if (!isLogined)
            {
                this.btnAdd.Enabled = false;
                this.btnReset.Enabled = false;
                this.btnFinish.Enabled = false;
                this.dgvSellDetail.ReadOnly = true;
                this.button1.Enabled = false;
            }
            else
            {
                this.btnAdd.Enabled = true;
                this.btnReset.Enabled = true;
                this.btnFinish.Enabled = true;
                this.dgvSellDetail.ReadOnly = false;
                this.button1.Enabled = true;
            }
        }

        protected void InitCustomerData()
        {
            cmd.CommandText = "select distinct customer_code from tbl_Customer order by customer_code asc";
            OleDbDataReader reader = cmd.ExecuteReader();
            cmbCustomerCode.Items.Clear();
            while (reader.Read())
                cmbCustomerCode.Items.Add(reader[0]);
            reader.Close();
        }

        protected void InitProductData()
        {
            cmd.CommandText = "select distinct product_name from tbl_product order by product_name asc";
            OleDbDataReader reader = cmd.ExecuteReader();
            cmbProduct.Items.Clear();
            while (reader.Read())
                cmbProduct.Items.Add(reader[0]);
            reader.Close();

            cmd.CommandText = "select category_id,category_name from tbl_category order by category_id asc";
            reader = cmd.ExecuteReader();
            cmbCategory.Items.Clear();
            while (reader.Read())
                cmbCategory.Items.Add(reader[0] + ":" + reader[1]);
            reader.Close();
        }

        protected int getSellDetailIdentity()
        {
            cmd.CommandText = "SELECT max(detail_id) from tbl_sell_detail";
            OleDbDataReader reader = cmd.ExecuteReader();
            int iSellDetailIdentity = 0;
            while (reader.Read() && reader!=null)
                if (reader.IsDBNull(0))
                {
                    iSellDetailIdentity = 0;
                }
                else
                {
                    iSellDetailIdentity = (int)reader[0];
                }
            reader.Close();

            return iSellDetailIdentity;
        }

        private void frmSell_Load(object sender, System.EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.tbl_sell_detail”中。您可以根据需要移动或删除它。
           // this.tbl_sell_detailTableAdapter.Fill(this.dataSet1.tbl_sell_detail);
            try
            {
                conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                changebtnstatus();
                InitCustomerData();
                InitProductData();
                adapter = new DataSet1TableAdapters.tbl_sell_detailTableAdapter();
                DataGridViewCheckBoxColumn cbdelete = new DataGridViewCheckBoxColumn();

                cbdelete.Name = "cbdelete";
                cbdelete.HeaderText = "删除";
                cbdelete.Selected = false;
                dgvSellDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cbdelete });//加第二个。

                //dgvSellDetail.Columns["cbdelete"].DataPropertyName = "detail_id";//数据绑定
               

              
           
            }
            catch (Exception exp)
            {
                MessageBox.Show("无法建立连接：" + exp.Message);
                this.Close();
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.Text == "")
                return;

            cmd.CommandText = string.Format("select product_id, product_name, Price from tbl_product where product_name = '{0}'", cmbProduct.Text);

            OleDbDataReader reader = null;
            //int MaxDetailID = 0;
            //if (adapter.GetData().Select("", " detail_id desc")[0].["detail_id"]==null)
            //{
            //    MaxDetailID = 0;
            //}
            //else
            //{
            //    MaxDetailID = (int)adapter.GetData().Select("", " detail_id desc")[0]["detail_id"];
            //}
            int MaxDetailID = 0;
            if (adapter.GetData().Select("", " detail_id desc").Length==0)
            {
                MaxDetailID = 0;
            }
            else
            {
                MaxDetailID = (int)(int)adapter.GetData().Select("", " detail_id desc")[0]["detail_id"];
            }
            dataSet1.tbl_sell_detail.Columns["detail_id"].AutoIncrement = true;
            dataSet1.tbl_sell_detail.Columns["detail_id"].AutoIncrementSeed =MaxDetailID+1;
            dataSet1.tbl_sell_detail.Columns["detail_id"].AutoIncrementStep = 1;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    DataSet1.tbl_sell_detailRow row = dataSet1.tbl_sell_detail.Newtbl_sell_detailRow();
                    //if (detailtable.Last() == null) {
                    //    row.detail_id = 1;
                    //}
                    //else
                    //{
                    //    row.detail_id = detailtable.Last().detail_id + 1;
                    //}

                    
                    row.product_id = (int)reader["product_id"];
                    row.sell_id =0;
                    row.product_name = (string)reader["product_name"];
                   

                    row.sell_number = (int)nudNumber.Value;//5+1+a+s+p+x
                    if (txtPrice.Text == "")
                    {
                        row.price = (double)reader["Price"];
                    }
                    else
                    {
                        row.price = Double.Parse(txtPrice.Text.ToString());
                    }
                    row.discount = (double)nudDiscount.Value;
                    row.customer_code = lblCustomerCode.Text;
                    if (txtTotalPrice.Text != "")
                    {
                        row.sum_money = double.Parse(txtTotalPrice.Text);
                    }
                    else
                    {
                        row.sum_money = (double)row.price * row.sell_number * row.discount;
                    }
                    row.create_date = (DateTime)System.DateTime.Now;
                    
                    
                    dataSet1.tbl_sell_detail.Addtbl_sell_detailRow(row);
                    lblSumMoney.Text = dataSet1.tbl_sell_detail.Compute("Sum(sum_money)", "product_id>0").ToString();
                }
                else
                {
                    MessageBox.Show("没有符合条件的产品", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据访问错误：" + exp.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
               
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataSet1.tbl_sell_detail.Clear();
            isLogined = false;
            changebtnstatus();
           
            cmbCustomerCode.Text = "";
            cmbProduct.Text = "";
            maskedPassword.Text = "";
            nudDiscount.Value = 1;
            nudNumber.Value = 0;
            cmbCustomerCode.Focus();//5_1_a_s_p_x
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
               
                adapter.Update(dataSet1.tbl_sell_detail);
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据访问错误：" + exp.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                MessageBox.Show("成功完成订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvSellDetail.Rows) { 
                if (row.Cells["cbdelete"].EditedFormattedValue.ToString() == "True") { 
                    rows.Add(row); 
                } 
            }
            foreach (DataGridViewRow row in rows) { 
                dgvSellDetail.Rows.Remove(row); 
            }
        }

        private void frmSell_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
                conn.Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select distinct product_name from tbl_product where product_category=" + cmbCategory.Text.Split(':')[0]+ " order by product_name asc";
            OleDbDataReader reader = cmd.ExecuteReader();
            cmbProduct.Items.Clear();
            while (reader.Read())
                cmbProduct.Items.Add(reader[0]);
            reader.Close();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select price from tbl_product where product_name='" + cmbProduct.Text + "' ";
            OleDbDataReader reader = cmd.ExecuteReader();
          
            while (reader.Read())
                txtPrice.Text = reader[0].ToString();
            reader.Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            double dprice=double.Parse(txtPrice.Text);
            double dnumber = (double)nudNumber.Value;
            txtTotalPrice.Text=(dprice*dnumber).ToString();
        }
    }
}
