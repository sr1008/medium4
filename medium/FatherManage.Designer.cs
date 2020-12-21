namespace medium
{
    partial class FatherManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbSaff = new System.Windows.Forms.Label();
            this.lbHome = new System.Windows.Forms.Label();
            this.lbRent = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.statusInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("宋体", 13F);
            this.lbInfo.Location = new System.Drawing.Point(40, 35);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(80, 18);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "个人信息";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // lbSaff
            // 
            this.lbSaff.AutoSize = true;
            this.lbSaff.Font = new System.Drawing.Font("宋体", 13F);
            this.lbSaff.Location = new System.Drawing.Point(36, 71);
            this.lbSaff.Name = "lbSaff";
            this.lbSaff.Size = new System.Drawing.Size(116, 18);
            this.lbSaff.TabIndex = 1;
            this.lbSaff.Text = "员工信息管理";
            this.lbSaff.Click += new System.EventHandler(this.lbSaff_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("宋体", 13F);
            this.lbHome.Location = new System.Drawing.Point(35, 101);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(116, 18);
            this.lbHome.TabIndex = 2;
            this.lbHome.Text = "房源信息管理";
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // lbRent
            // 
            this.lbRent.AutoSize = true;
            this.lbRent.Font = new System.Drawing.Font("宋体", 13F);
            this.lbRent.Location = new System.Drawing.Point(37, 131);
            this.lbRent.Name = "lbRent";
            this.lbRent.Size = new System.Drawing.Size(80, 18);
            this.lbRent.TabIndex = 3;
            this.lbRent.Text = "订单管理";
            this.lbRent.Click += new System.EventHandler(this.lbRent_Click);
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Font = new System.Drawing.Font("宋体", 13F);
            this.lbOut.Location = new System.Drawing.Point(37, 167);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(44, 18);
            this.lbOut.TabIndex = 5;
            this.lbOut.Text = "退出";
            this.lbOut.Click += new System.EventHandler(this.lbOut_Click);
            // 
            // statusInfo
            // 
            this.statusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusInfo.Location = new System.Drawing.Point(0, 463);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(769, 22);
            this.statusInfo.TabIndex = 6;
            this.statusInfo.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "工号：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel4.Text = "用户名：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 17);
            // 
            // FatherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbRent);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.lbSaff);
            this.Controls.Add(this.lbInfo);
            this.Name = "FatherManage";
            this.Text = "房产中介管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FatherManage_FormClosing);
            this.Load += new System.EventHandler(this.FatherManage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FatherManage_KeyDown);
            this.statusInfo.ResumeLayout(false);
            this.statusInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbSaff;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbRent;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.StatusStrip statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}