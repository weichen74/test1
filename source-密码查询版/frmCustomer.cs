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
    public partial class frmCustomer : Form
    {

        protected OleDbConnection conn;
        protected OleDbCommand cmd;


        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                this.InitData();
            }
            catch (Exception exp)
            {
                MessageBox.Show("无法建立连接：" + exp.Message);
                this.Close();
            }
        }

        protected void InitData()
        {
            cmd.CommandText = "select distinct customer_code from tbl_Customer order by customer_code asc";
            OleDbDataReader reader = cmd.ExecuteReader();
            cmbCustomerID.Items.Clear();
            while (reader.Read())
                cmbCustomerID.Items.Add(reader[0]);
            reader.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpInformation_Enter(object sender, EventArgs e)
        {

        }

        private bool IsExistSameCustomer(string customer_code)
        {
             cmd.CommandText = "select * from tbl_Customer where customer_code = '"
                + customer_code+"'";
            OleDbDataReader reader = null;
             try
            {
                reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
             catch (Exception exp)
             {
                 return false;
             }
             finally
             {
                 if (reader != null && !reader.IsClosed)
                     reader.Close();
             }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cmbCustomerID.Text == ""&&txtSearchExt.Text=="")
                return;
            string searchstr = "";

            if (cmbCustomerID.Text != "" && txtSearchExt.Text != "")
            {
                searchstr = "(customer_code='" + cmbCustomerID.Text + "' or ext='" + txtSearchExt.Text + "')";
               
            }
            if (cmbCustomerID.Text != "" && txtSearchExt.Text == "")
            {
                searchstr =  " customer_code='" + cmbCustomerID.Text + "'";
               
            }
            if (cmbCustomerID.Text == "" && txtSearchExt.Text != "")
            {
                searchstr =  " ext='" + txtSearchExt.Text + "'";

            }
            

            cmd.CommandText = "select * from tbl_Customer where " + searchstr;
            OleDbDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("没有符合条件的记录", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (reader.Read())
                {
                    
                    txtCustomerName.Text = reader["Customer_Name"].ToString();
                    numericUpDownLevel.Value = (short)reader["Levels"];
                    if (reader["Gender"].ToString()=="0")
                        rdbGirl.Checked = true;
                    else
                        rdbBoy.Checked = true;
                    if (reader["islocked"].ToString() == "1")
                        cblocked.Checked = true;
                    else
                        cblocked.Checked = false;
                    cmbDegree.Text = reader["Degree"].ToString();
                    dtpBirthday.Value = (DateTime)reader["Birthday"];
                    dtpRecruit.Value = (DateTime)reader["recruit_date"];
                    txtAddress.Text = reader["Address"].ToString();
                    txtPassword.Text = reader["password"].ToString();
                    txtCustomerCode.Text = reader["customer_code"].ToString();
                    txtCustomerID.Text = reader["customer_id"].ToString();
                    txtTelephone.Text = reader["telephone"].ToString();
                    txtExt.Text = reader["ext"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    numericUpDownScore.Value = (int)reader["Score"];
                    txtMobilePhone.Text = reader["mobile_phone"].ToString();
                    txtCustomerCode.Text = reader["customer_code"].ToString();
                    cmbDepartment.Text = reader["department"].ToString();
                }
                else
                {
                    MessageBox.Show("没有符合条件的记录", "提示",
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            //if (cmbCustomerID.Text == "")
            //    return;
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("姓名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }
            if (MessageBox.Show("确认保存所进行的修改吗？", "提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            StringBuilder sb = new StringBuilder("update tbl_Customer set Customer_Name = '");
            sb.Append(txtCustomerName.Text);
            sb.Append("', Levels=");
            sb.Append(numericUpDownLevel.Value);
            sb.Append(", Gender='");
            if (rdbBoy.Checked)
                sb.Append("1");
            else
                sb.Append("0");
            sb.Append("', Birthday='");
            sb.Append(dtpBirthday.Value.ToShortDateString());
            sb.Append("', recruit_date='");
            sb.Append(dtpRecruit.Value.ToShortDateString());
            sb.Append("', Degree='");
            sb.Append(cmbDegree.Text);
            sb.Append("', Address='");
            sb.Append(txtAddress.Text);
            sb.Append("', Telephone='");
            sb.Append(txtTelephone.Text);
            sb.Append("', ext='");
            sb.Append(txtExt.Text);
            sb.Append("', mobile_phone='");
            sb.Append(txtMobilePhone.Text);
            sb.Append("', department='");
            sb.Append(cmbDepartment.Text);
            sb.Append("', Email='");
            sb.Append(txtEmail.Text);
            sb.Append("', customer_code='");
            sb.Append(txtCustomerCode.Text);
            sb.Append("', Score=");
            sb.Append(numericUpDownScore.Value);
           
            sb.Append(", islocked=");
            if (cblocked.Checked)
                sb.Append("1");
            else
                sb.Append("0");
         
            sb.Append(" where customer_id =");
            sb.Append(txtCustomerID.Text+"");

            cmd.CommandText = sb.ToString();

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("未做任何修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception exp)
            {
                MessageBox.Show("数据访问错误：" + exp.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("姓名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            if (MessageBox.Show("确认增加新会员吗？", "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (IsExistSameCustomer(txtCustomerCode.Text) == true)
            {
                MessageBox.Show("该员工号已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            StringBuilder sb = new StringBuilder("Insert into tbl_customer([customer_name],[customer_code],[levels],[gender],[birthday],[recruit_date],[degree],[address],[telephone],[password],[email],[score],[department],[ext],[mobile_phone]) values('");

            sb.Append(txtCustomerName.Text + "','" + txtCustomerCode.Text + "'," + numericUpDownLevel.Value + ",'" + (rdbBoy.Checked ? "1" : "0") +
                "','" + dtpBirthday.Value.ToShortDateString() + "','" + dtpRecruit.Value.ToShortDateString() + "','" + cmbDegree.Text + "','" +
                txtAddress.Text + "','" + txtTelephone.Text + "','" + getPassword() + "','" + txtEmail.Text + "',"+ numericUpDownScore.Value + ",'" + cmbDepartment.Text + "','" + txtExt.Text + "','" + txtMobilePhone.Text + "' )");
            cmd.CommandText = sb.ToString();

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("增加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.InitData();
                }
                else
                {
                    MessageBox.Show("未增加任何新记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据库访问错误：" + exp.Message);
            }
        }

        public int[] getRandomNum(int num, int minValue, int maxValue)
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int[] arrNum = new int[num];
            int tmp = 0;
            for (int i = 0; i <= num - 1; i++)
            {
                tmp = ra.Next(minValue, maxValue); //随机取数
                arrNum[i] = getNum(arrNum, tmp, minValue, maxValue, ra); //取出值赋到数组中
            }
            return arrNum;
        }

        public int getNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            int n = 0;
            while (n <= arrNum.Length - 1)
            {
                if (arrNum[n] == tmp) //利用循环判断是否有重复
                {
                    tmp = ra.Next(minValue, maxValue); //重新随机获取。
                    getNum(arrNum, tmp, minValue, maxValue, ra);//递归:如果取出来的数字和已取得的数字有重复就重新随机获取。
                }
                n++;
            }
            return tmp;
        }

        public string getPassword()
        {
            int[] arr=getRandomNum(6,1,10); //从1至20中取出6个互不相同的随机数
            int i=0;
            string temp="";
            while (i<=arr.Length-1){
                temp = arr[i].ToString() + temp;
                i++ ;
            }
            return temp;
        }

        private void cmbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
                conn.Close();
        } 




        
    }
}
