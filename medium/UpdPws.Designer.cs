namespace medium
{
    partial class UpdPws
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textOldPws = new System.Windows.Forms.TextBox();
            this.textNewPws = new System.Windows.Forms.TextBox();
            this.textAckn = new System.Windows.Forms.TextBox();
            this.btnAckn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // textOldPws
            // 
            this.textOldPws.Location = new System.Drawing.Point(100, 40);
            this.textOldPws.Name = "textOldPws";
            this.textOldPws.PasswordChar = '*';
            this.textOldPws.Size = new System.Drawing.Size(139, 21);
            this.textOldPws.TabIndex = 3;
            // 
            // textNewPws
            // 
            this.textNewPws.Location = new System.Drawing.Point(100, 76);
            this.textNewPws.Name = "textNewPws";
            this.textNewPws.PasswordChar = '*';
            this.textNewPws.Size = new System.Drawing.Size(139, 21);
            this.textNewPws.TabIndex = 4;
            // 
            // textAckn
            // 
            this.textAckn.Location = new System.Drawing.Point(100, 113);
            this.textAckn.Name = "textAckn";
            this.textAckn.PasswordChar = '*';
            this.textAckn.Size = new System.Drawing.Size(139, 21);
            this.textAckn.TabIndex = 5;
            // 
            // btnAckn
            // 
            this.btnAckn.Location = new System.Drawing.Point(44, 180);
            this.btnAckn.Name = "btnAckn";
            this.btnAckn.Size = new System.Drawing.Size(75, 23);
            this.btnAckn.TabIndex = 6;
            this.btnAckn.Text = "确认修改";
            this.btnAckn.UseVisualStyleBackColor = true;
            this.btnAckn.Click += new System.EventHandler(this.btnAckn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(188, 179);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdPws
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 266);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAckn);
            this.Controls.Add(this.textAckn);
            this.Controls.Add(this.textNewPws);
            this.Controls.Add(this.textOldPws);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdPws";
            this.Text = "个人信息>修改密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdPws_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOldPws;
        private System.Windows.Forms.TextBox textNewPws;
        private System.Windows.Forms.TextBox textAckn;
        private System.Windows.Forms.Button btnAckn;
        private System.Windows.Forms.Button btnBack;
    }
}