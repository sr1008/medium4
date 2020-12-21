namespace medium
{
    partial class ManageHouse
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
            this.dataHouse = new System.Windows.Forms.DataGridView();
            this.card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetele = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInsHouse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textHouseCard = new System.Windows.Forms.TextBox();
            this.textPriceBegin = new System.Windows.Forms.TextBox();
            this.textPriceEnd = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.textClientName = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textCilentCard = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHouse
            // 
            this.dataHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.card,
            this.estPrice,
            this.address,
            this.houseState,
            this.cardCli,
            this.name,
            this.number,
            this.insDate,
            this.btnDetele,
            this.btnInto});
            this.dataHouse.Location = new System.Drawing.Point(173, 101);
            this.dataHouse.Name = "dataHouse";
            this.dataHouse.RowTemplate.Height = 23;
            this.dataHouse.Size = new System.Drawing.Size(1255, 375);
            this.dataHouse.TabIndex = 6;
            this.dataHouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHouse_CellContentClick);
            // 
            // card
            // 
            this.card.DataPropertyName = "card";
            this.card.HeaderText = "房源编号";
            this.card.Name = "card";
            this.card.ReadOnly = true;
            // 
            // estPrice
            // 
            this.estPrice.DataPropertyName = "estPrice";
            this.estPrice.HeaderText = "预估价格";
            this.estPrice.Name = "estPrice";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "房源地址";
            this.address.Name = "address";
            this.address.Width = 200;
            // 
            // houseState
            // 
            this.houseState.DataPropertyName = "houseState";
            this.houseState.HeaderText = "房源状态";
            this.houseState.Name = "houseState";
            this.houseState.ReadOnly = true;
            // 
            // cardCli
            // 
            this.cardCli.DataPropertyName = "cardCli";
            this.cardCli.HeaderText = "房主编号";
            this.cardCli.Name = "cardCli";
            this.cardCli.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "房主名字";
            this.name.Name = "name";
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "电话号码";
            this.number.Name = "number";
            // 
            // insDate
            // 
            this.insDate.DataPropertyName = "insDate";
            this.insDate.HeaderText = "添加时间";
            this.insDate.Name = "insDate";
            this.insDate.ReadOnly = true;
            this.insDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnDetele
            // 
            this.btnDetele.HeaderText = "删除";
            this.btnDetele.Name = "btnDetele";
            this.btnDetele.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDetele.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnInto
            // 
            this.btnInto.HeaderText = "详细";
            this.btnInto.Name = "btnInto";
            // 
            // btnInsHouse
            // 
            this.btnInsHouse.Location = new System.Drawing.Point(298, 499);
            this.btnInsHouse.Name = "btnInsHouse";
            this.btnInsHouse.Size = new System.Drawing.Size(156, 23);
            this.btnInsHouse.TabIndex = 7;
            this.btnInsHouse.Text = "添加房源";
            this.btnInsHouse.UseVisualStyleBackColor = true;
            this.btnInsHouse.Click += new System.EventHandler(this.btnInsHouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "房源编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "房源状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1030, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "房主名字：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "电话：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "添加时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "-";
            // 
            // textHouseCard
            // 
            this.textHouseCard.Location = new System.Drawing.Point(254, 20);
            this.textHouseCard.Name = "textHouseCard";
            this.textHouseCard.Size = new System.Drawing.Size(100, 21);
            this.textHouseCard.TabIndex = 18;
            // 
            // textPriceBegin
            // 
            this.textPriceBegin.Location = new System.Drawing.Point(425, 21);
            this.textPriceBegin.Name = "textPriceBegin";
            this.textPriceBegin.Size = new System.Drawing.Size(100, 21);
            this.textPriceBegin.TabIndex = 19;
            this.textPriceBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPriceBegin_KeyPress);
            // 
            // textPriceEnd
            // 
            this.textPriceEnd.Location = new System.Drawing.Point(549, 21);
            this.textPriceEnd.Name = "textPriceEnd";
            this.textPriceEnd.Size = new System.Drawing.Size(100, 21);
            this.textPriceEnd.TabIndex = 20;
            this.textPriceEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPriceEnd_KeyPress);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(720, 21);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 21);
            this.textAddress.TabIndex = 21;
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Items.AddRange(new object[] {
            "全部",
            "空置",
            "租赁",
            "出售"});
            this.comboState.Location = new System.Drawing.Point(890, 21);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(121, 20);
            this.comboState.TabIndex = 22;
            // 
            // textClientName
            // 
            this.textClientName.Location = new System.Drawing.Point(1101, 21);
            this.textClientName.Name = "textClientName";
            this.textClientName.Size = new System.Drawing.Size(100, 21);
            this.textClientName.TabIndex = 23;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(244, 67);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 21);
            this.textNumber.TabIndex = 24;
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(425, 70);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(117, 21);
            this.dateBegin.TabIndex = 25;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(565, 71);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(114, 21);
            this.dateEnd.TabIndex = 26;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(865, 73);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 27;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(685, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "房主编号：";
            // 
            // textCilentCard
            // 
            this.textCilentCard.Location = new System.Drawing.Point(746, 73);
            this.textCilentCard.Name = "textCilentCard";
            this.textCilentCard.Size = new System.Drawing.Size(100, 21);
            this.textCilentCard.TabIndex = 30;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(674, 499);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 31;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ManageHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1440, 557);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.textCilentCard);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textClientName);
            this.Controls.Add(this.comboState);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPriceEnd);
            this.Controls.Add(this.textPriceBegin);
            this.Controls.Add(this.textHouseCard);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsHouse);
            this.Controls.Add(this.dataHouse);
            this.Name = "ManageHouse";
            this.Text = "房产中介管理系统>房源信息管理";
            this.Load += new System.EventHandler(this.ManageHouse_Load);
            this.Controls.SetChildIndex(this.dataHouse, 0);
            this.Controls.SetChildIndex(this.btnInsHouse, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.textHouseCard, 0);
            this.Controls.SetChildIndex(this.textPriceBegin, 0);
            this.Controls.SetChildIndex(this.textPriceEnd, 0);
            this.Controls.SetChildIndex(this.textAddress, 0);
            this.Controls.SetChildIndex(this.comboState, 0);
            this.Controls.SetChildIndex(this.textClientName, 0);
            this.Controls.SetChildIndex(this.textNumber, 0);
            this.Controls.SetChildIndex(this.dateBegin, 0);
            this.Controls.SetChildIndex(this.dateEnd, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.textCilentCard, 0);
            this.Controls.SetChildIndex(this.btnExport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHouse;
        private System.Windows.Forms.Button btnInsHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn card;
        private System.Windows.Forms.DataGridViewTextBoxColumn estPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn insDate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetele;
        private System.Windows.Forms.DataGridViewButtonColumn btnInto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textHouseCard;
        private System.Windows.Forms.TextBox textPriceBegin;
        private System.Windows.Forms.TextBox textPriceEnd;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.TextBox textClientName;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCilentCard;
        private System.Windows.Forms.Button btnExport;
    }
}
