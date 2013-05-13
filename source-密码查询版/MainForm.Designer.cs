namespace bartool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBook = new System.Windows.Forms.Button();
            this.btnHuiyuan = new System.Windows.Forms.Button();
            this.btnTongji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(53, 51);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(153, 40);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "产品管理";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnHuiyuan
            // 
            this.btnHuiyuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuiyuan.Location = new System.Drawing.Point(53, 136);
            this.btnHuiyuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuiyuan.Name = "btnHuiyuan";
            this.btnHuiyuan.Size = new System.Drawing.Size(153, 40);
            this.btnHuiyuan.TabIndex = 0;
            this.btnHuiyuan.Text = "员工管理";
            this.btnHuiyuan.UseVisualStyleBackColor = true;
            this.btnHuiyuan.Click += new System.EventHandler(this.btnHuiyuan_Click);
            // 
            // btnTongji
            // 
            this.btnTongji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongji.Location = new System.Drawing.Point(53, 221);
            this.btnTongji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTongji.Name = "btnTongji";
            this.btnTongji.Size = new System.Drawing.Size(153, 40);
            this.btnTongji.TabIndex = 0;
            this.btnTongji.Text = "统计查询";
            this.btnTongji.UseVisualStyleBackColor = true;
            this.btnTongji.Click += new System.EventHandler(this.btnTongji_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(258, 308);
            this.Controls.Add(this.btnTongji);
            this.Controls.Add(this.btnHuiyuan);
            this.Controls.Add(this.btnBook);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "水吧销售管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnHuiyuan;
        private System.Windows.Forms.Button btnTongji;
    }
}

