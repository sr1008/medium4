namespace medium
{
    partial class Manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.textJobNum = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSex = new System.Windows.Forms.TextBox();
            this.textCordNo = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lbInfo.Location = new System.Drawing.Point(40, 41);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(80, 18);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "个人信息";
            // 
            // lbSaff
            // 
            this.lbSaff.AutoSize = true;
            this.lbSaff.Font = new System.Drawing.Font("宋体", 13F);
            this.lbSaff.Location = new System.Drawing.Point(37, 75);
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
            this.lbHome.Location = new System.Drawing.Point(38, 110);
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
            this.lbRent.Location = new System.Drawing.Point(38, 142);
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
            this.lbOut.Location = new System.Drawing.Point(52, 178);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(44, 18);
            this.lbOut.TabIndex = 5;
            this.lbOut.Text = "退出";
            this.lbOut.Click += new System.EventHandler(this.lbOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "工号:";
            // 
            // textJobNum
            // 
            this.textJobNum.Location = new System.Drawing.Point(287, 41);
            this.textJobNum.Name = "textJobNum";
            this.textJobNum.ReadOnly = true;
            this.textJobNum.Size = new System.Drawing.Size(129, 21);
            this.textJobNum.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(287, 86);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(129, 21);
            this.textName.TabIndex = 8;
            // 
            // textSex
            // 
            this.textSex.Location = new System.Drawing.Point(287, 126);
            this.textSex.Name = "textSex";
            this.textSex.ReadOnly = true;
            this.textSex.Size = new System.Drawing.Size(129, 21);
            this.textSex.TabIndex = 9;
            // 
            // textCordNo
            // 
            this.textCordNo.Location = new System.Drawing.Point(287, 162);
            this.textCordNo.Name = "textCordNo";
            this.textCordNo.ReadOnly = true;
            this.textCordNo.Size = new System.Drawing.Size(210, 21);
            this.textCordNo.TabIndex = 10;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(287, 198);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(129, 21);
            this.textNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "身份证号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "电话号码：";
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(442, 196);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(75, 23);
            this.btnNumber.TabIndex = 16;
            this.btnNumber.Text = "修改";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "修改密码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusInfo
            // 
            this.statusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusInfo.Location = new System.Drawing.Point(0, 474);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(790, 22);
            this.statusInfo.TabIndex = 18;
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
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 496);
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textCordNo);
            this.Controls.Add(this.textSex);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textJobNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbRent);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.lbSaff);
            this.Controls.Add(this.lbInfo);
            this.Name = "Manage";
            this.Text = "房产中介管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Manage_KeyDown);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textJobNum;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSex;
        private System.Windows.Forms.TextBox textCordNo;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}