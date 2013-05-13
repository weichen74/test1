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
    public partial class CustomerForm : Form
    {
        protected SqlConnection conn;
        protected SqlCommand cmd;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["书店零售系统.Properties.Settings.BookStoreConnectionString"].ConnectionString);
                cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                this.InitData();
            }
            catch (Exception exp)
            {
                MessageBox.Show("无法建立连接："+exp.Message);
                this.Close();
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
                conn.Close();
        }

        protected void InitData()
        {
            cmd.CommandText = "select distinct ID from Customer order by ID";
            SqlDataReader reader = cmd.ExecuteReader();
            cmbID.Items.Clear();
            while (reader.Read())
                cmbID.Items.Add(reader[0]);
            reader.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbID.Text == "")
                return;
            cmd.CommandText = "select * from tbl_Customer where customer_code = "
                + cmbID.Text;
            SqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    numericUpDownLevel.Value = (short)reader["Levels"];
                    if ((bool)reader["Gender"])
                        rdbBoy.Checked = true;
                    else
                        rdbGirl.Checked = true;
                    cmbGender.Text = reader["Degree"].ToString();
                    dtpBirthday.Value = (DateTime)reader["Birthday"];
                    txtAddress.Text = reader["Addres"].ToString();
                    txtPhone.Text = reader["Telephone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    numericUpDownScore.Value = (int)reader["Score"];
                }
                else
                {
                    MessageBox.Show("没有符合条件的记录","提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据访问错误："+exp.Message + exp.StackTrace,
                    "错误",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbID.Text == "")
                return;
            if (txtName.Text == "")
            {
                MessageBox.Show("姓名不能为空","提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (MessageBox.Show("确认保存所进行的修改吗？", "提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            StringBuilder sb = new StringBuilder("update Customer set Name = '");
            sb.Append(txtName.Text);
            sb.Append("', Levels=");
            sb.Append(numericUpDownLevel.Value);
            sb.Append(", Gender='");
            if (rdbBoy.Checked)
                sb.Append("1");
            else
                sb.Append("0");
            sb.Append("', Birthday='");
            sb.Append(dtpBirthday.Value.ToShortDateString());
            sb.Append("', Degree='");
            sb.Append(cmbGender.Text);
            sb.Append("', Addres='");
            sb.Append(txtAddress.Text);
            sb.Append("', Telephone='");
            sb.Append(txtPhone.Text);
            sb.Append("', Email='");
            sb.Append(txtEmail.Text);
            sb.Append("', Score=");
            sb.Append(numericUpDownScore.Value);
            sb.Append(" where ID =");
            sb.Append(cmbID.Text);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("姓名不能为空","提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (MessageBox.Show("确认增加新会员吗？", "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
                return;

            StringBuilder sb = new StringBuilder("Insert into Customer values(");
          
            sb.Append( cmbID.Text + ",'" + txtName.Text + "'," + numericUpDownLevel.Value + ",'" + (rdbBoy.Checked ? "1":"0") + 
                "','" + dtpBirthday.Value.ToShortDateString() + "','" + cmbGender.Text + "','" +
                txtAddress.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "'," + 
                numericUpDownScore.Value + ")");
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

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void grpInformation_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
