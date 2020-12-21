namespace medium
{
    partial class ManageSaff
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
            this.dataSaff = new System.Windows.Forms.DataGridView();
            this.jobNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textJobNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCardNo = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSaff
            // 
            this.dataSaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobNum,
            this.name,
            this.sex,
            this.cardNo,
            this.number,
            this.status,
            this.endDate});
            this.dataSaff.Location = new System.Drawing.Point(178, 101);
            this.dataSaff.Name = "dataSaff";
            this.dataSaff.RowTemplate.Height = 23;
            this.dataSaff.Size = new System.Drawing.Size(1114, 366);
            this.dataSaff.TabIndex = 6;
            this.dataSaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSaff_CellContentClick);
            // 
            // jobNum
            // 
            this.jobNum.DataPropertyName = "jobNum";
            this.jobNum.HeaderText = "工号";
            this.jobNum.Name = "jobNum";
            this.jobNum.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex1";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.Width = 70;
            // 
            // cardNo
            // 
            this.cardNo.DataPropertyName = "cardNo";
            this.cardNo.HeaderText = "身份证号";
            this.cardNo.Name = "cardNo";
            this.cardNo.Width = 150;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "电话号码";
            this.number.Name = "number";
            // 
            // status
            // 
            this.status.DataPropertyName = "status1";
            this.status.HeaderText = "职务";
            this.status.Name = "status";
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "入职时间";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(218, 473);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(164, 27);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "添加员工";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名：";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(239, 19);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 21);
            this.textname.TabIndex = 9;
            // 
            // textJobNum
            // 
            this.textJobNum.Location = new System.Drawing.Point(401, 20);
            this.textJobNum.Name = "textJobNum";
            this.textJobNum.Size = new System.Drawing.Size(100, 21);
            this.textJobNum.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "性别：";
            // 
            // comboSex
            // 
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.comboSex.Location = new System.Drawing.Point(569, 23);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(54, 20);
            this.comboSex.TabIndex = 13;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "全部",
            "管理员",
            "业务员"});
            this.comboStatus.Location = new System.Drawing.Point(702, 24);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 20);
            this.comboStatus.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "职务：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "身份证号：";
            // 
            // textCardNo
            // 
            this.textCardNo.Location = new System.Drawing.Point(910, 24);
            this.textCardNo.Name = "textCardNo";
            this.textCardNo.Size = new System.Drawing.Size(100, 21);
            this.textCardNo.TabIndex = 17;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(1075, 22);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 21);
            this.textNumber.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1028, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "入职时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "-";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(548, 71);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 24;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(261, 71);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(104, 21);
            this.dateBegin.TabIndex = 25;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(389, 71);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(112, 21);
            this.dateEnd.TabIndex = 26;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(763, 476);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ManageSaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 544);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textCardNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textJobNum);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataSaff);
            this.Name = "ManageSaff";
            this.Text = "房产中介管理系统>员工信息管理";
            this.Load += new System.EventHandler(this.ManageSaff_Load);
            this.Controls.SetChildIndex(this.dataSaff, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textname, 0);
            this.Controls.SetChildIndex(this.textJobNum, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboSex, 0);
            this.Controls.SetChildIndex(this.comboStatus, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textCardNo, 0);
            this.Controls.SetChildIndex(this.textNumber, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.dateBegin, 0);
            this.Controls.SetChildIndex(this.dateEnd, 0);
            this.Controls.SetChildIndex(this.btnExport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataSaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSaff;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textJobNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCardNo;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnExport;
    }
}