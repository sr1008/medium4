namespace medium
{
    partial class ManageRent
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataRent = new System.Windows.Forms.DataGridView();
            this.orderCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operateMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textOrderCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHouseCard = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textHostCard = new System.Windows.Forms.TextBox();
            this.textHostNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textHostName = new System.Windows.Forms.TextBox();
            this.textGuestCard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textGuestNumber = new System.Windows.Forms.TextBox();
            this.textGuestName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBeginPrice = new System.Windows.Forms.TextBox();
            this.textEndPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRent
            // 
            this.dataRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderCard,
            this.houseCard,
            this.address,
            this.hostClient,
            this.hosetNumber,
            this.hosetName,
            this.guestClient,
            this.guestNumber,
            this.geustName,
            this.strType,
            this.factPrice,
            this.endDate,
            this.operateMan,
            this.btnInto});
            this.dataRent.Location = new System.Drawing.Point(157, 115);
            this.dataRent.Name = "dataRent";
            this.dataRent.RowTemplate.Height = 23;
            this.dataRent.Size = new System.Drawing.Size(1445, 430);
            this.dataRent.TabIndex = 6;
            this.dataRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRent_CellContentClick);
            // 
            // orderCard
            // 
            this.orderCard.DataPropertyName = "orderCard";
            this.orderCard.HeaderText = "订单编号";
            this.orderCard.Name = "orderCard";
            this.orderCard.ReadOnly = true;
            // 
            // houseCard
            // 
            this.houseCard.DataPropertyName = "houseCard";
            this.houseCard.HeaderText = "交易房源编号";
            this.houseCard.Name = "houseCard";
            this.houseCard.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "房源地址";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // hostClient
            // 
            this.hostClient.DataPropertyName = "hostClient";
            this.hostClient.HeaderText = "房东编号";
            this.hostClient.Name = "hostClient";
            this.hostClient.ReadOnly = true;
            // 
            // hosetNumber
            // 
            this.hosetNumber.DataPropertyName = "hosetNumber";
            this.hosetNumber.HeaderText = "房东电话";
            this.hosetNumber.Name = "hosetNumber";
            this.hosetNumber.ReadOnly = true;
            // 
            // hosetName
            // 
            this.hosetName.DataPropertyName = "hosetName";
            this.hosetName.HeaderText = "房东姓名";
            this.hosetName.Name = "hosetName";
            this.hosetName.ReadOnly = true;
            // 
            // guestClient
            // 
            this.guestClient.DataPropertyName = "guestClient";
            this.guestClient.HeaderText = "房客编号";
            this.guestClient.Name = "guestClient";
            this.guestClient.ReadOnly = true;
            // 
            // guestNumber
            // 
            this.guestNumber.DataPropertyName = "guestNumber";
            this.guestNumber.HeaderText = "房客电话";
            this.guestNumber.Name = "guestNumber";
            this.guestNumber.ReadOnly = true;
            // 
            // geustName
            // 
            this.geustName.DataPropertyName = "geustName";
            this.geustName.HeaderText = "房客姓名";
            this.geustName.Name = "geustName";
            this.geustName.ReadOnly = true;
            // 
            // strType
            // 
            this.strType.DataPropertyName = "strType";
            this.strType.HeaderText = "交易类型";
            this.strType.Name = "strType";
            this.strType.ReadOnly = true;
            // 
            // factPrice
            // 
            this.factPrice.DataPropertyName = "factPrice";
            this.factPrice.HeaderText = "交易金额";
            this.factPrice.Name = "factPrice";
            this.factPrice.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "交易时间";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // operateMan
            // 
            this.operateMan.DataPropertyName = "operateMan";
            this.operateMan.HeaderText = "操作人";
            this.operateMan.Name = "operateMan";
            this.operateMan.ReadOnly = true;
            // 
            // btnInto
            // 
            this.btnInto.HeaderText = "详细";
            this.btnInto.Name = "btnInto";
            this.btnInto.Text = "详细";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "订单编号：";
            // 
            // textOrderCard
            // 
            this.textOrderCard.Location = new System.Drawing.Point(229, 19);
            this.textOrderCard.Name = "textOrderCard";
            this.textOrderCard.Size = new System.Drawing.Size(100, 21);
            this.textOrderCard.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "房源编号：";
            // 
            // textHouseCard
            // 
            this.textHouseCard.Location = new System.Drawing.Point(419, 19);
            this.textHouseCard.Name = "textHouseCard";
            this.textHouseCard.Size = new System.Drawing.Size(100, 21);
            this.textHouseCard.TabIndex = 10;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(594, 18);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 21);
            this.textAddress.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "房源地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "房东编号：";
            // 
            // textHostCard
            // 
            this.textHostCard.Location = new System.Drawing.Point(759, 18);
            this.textHostCard.Name = "textHostCard";
            this.textHostCard.Size = new System.Drawing.Size(100, 21);
            this.textHostCard.TabIndex = 14;
            // 
            // textHostNumber
            // 
            this.textHostNumber.Location = new System.Drawing.Point(936, 18);
            this.textHostNumber.Name = "textHostNumber";
            this.textHostNumber.Size = new System.Drawing.Size(100, 21);
            this.textHostNumber.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(865, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "房东电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1043, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "房东名字：";
            // 
            // textHostName
            // 
            this.textHostName.Location = new System.Drawing.Point(1101, 18);
            this.textHostName.Name = "textHostName";
            this.textHostName.Size = new System.Drawing.Size(100, 21);
            this.textHostName.TabIndex = 18;
            // 
            // textGuestCard
            // 
            this.textGuestCard.Location = new System.Drawing.Point(1278, 18);
            this.textGuestCard.Name = "textGuestCard";
            this.textGuestCard.Size = new System.Drawing.Size(100, 21);
            this.textGuestCard.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1207, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "房客编号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "房客电话：";
            // 
            // textGuestNumber
            // 
            this.textGuestNumber.Location = new System.Drawing.Point(218, 71);
            this.textGuestNumber.Name = "textGuestNumber";
            this.textGuestNumber.Size = new System.Drawing.Size(100, 21);
            this.textGuestNumber.TabIndex = 22;
            // 
            // textGuestName
            // 
            this.textGuestName.Location = new System.Drawing.Point(410, 73);
            this.textGuestName.Name = "textGuestName";
            this.textGuestName.Size = new System.Drawing.Size(100, 21);
            this.textGuestName.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "房客名字：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "交易类型：";
            // 
            // comboSex
            // 
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "全部",
            "租赁",
            "出售"});
            this.comboSex.Location = new System.Drawing.Point(599, 78);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(95, 20);
            this.comboSex.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "交易金额：";
            // 
            // textBeginPrice
            // 
            this.textBeginPrice.Location = new System.Drawing.Point(759, 78);
            this.textBeginPrice.Name = "textBeginPrice";
            this.textBeginPrice.Size = new System.Drawing.Size(64, 21);
            this.textBeginPrice.TabIndex = 28;
            // 
            // textEndPrice
            // 
            this.textEndPrice.Location = new System.Drawing.Point(846, 77);
            this.textEndPrice.Name = "textEndPrice";
            this.textEndPrice.Size = new System.Drawing.Size(63, 21);
            this.textEndPrice.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(829, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(936, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "交易时间：";
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(997, 78);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(111, 21);
            this.dateBegin.TabIndex = 32;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(1135, 78);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(121, 21);
            this.dateEnd.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1115, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "-";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1288, 76);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 35;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1332, 563);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 36;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ManageRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1648, 617);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textEndPrice);
            this.Controls.Add(this.textBeginPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textGuestName);
            this.Controls.Add(this.textGuestNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textGuestCard);
            this.Controls.Add(this.textHostName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textHostNumber);
            this.Controls.Add(this.textHostCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textHouseCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textOrderCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataRent);
            this.Name = "ManageRent";
            this.Text = "房产中介管理系统>订单管理";
            this.Load += new System.EventHandler(this.ManageRent_Load);
            this.Controls.SetChildIndex(this.dataRent, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textOrderCard, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textHouseCard, 0);
            this.Controls.SetChildIndex(this.textAddress, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textHostCard, 0);
            this.Controls.SetChildIndex(this.textHostNumber, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textHostName, 0);
            this.Controls.SetChildIndex(this.textGuestCard, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textGuestNumber, 0);
            this.Controls.SetChildIndex(this.textGuestName, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.comboSex, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.textBeginPrice, 0);
            this.Controls.SetChildIndex(this.textEndPrice, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.dateBegin, 0);
            this.Controls.SetChildIndex(this.dateEnd, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.btnExport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn geustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strType;
        private System.Windows.Forms.DataGridViewTextBoxColumn factPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn operateMan;
        private System.Windows.Forms.DataGridViewButtonColumn btnInto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrderCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHouseCard;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHostCard;
        private System.Windows.Forms.TextBox textHostNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textHostName;
        private System.Windows.Forms.TextBox textGuestCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textGuestNumber;
        private System.Windows.Forms.TextBox textGuestName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBeginPrice;
        private System.Windows.Forms.TextBox textEndPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExport;
    }
}
