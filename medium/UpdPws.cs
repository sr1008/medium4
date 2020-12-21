using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace medium
{
    public partial class UpdPws : Form
    {
        private string jobNum;
        private string jobName;
        private Form l;
        private ConnetionMysql mysql = new ConnetionMysql();

       

        public Form L
        {
            get
            {
                return l;
            }

            set
            {
                l = value;
            }
        }

        public string JobNum
        {
            get
            {
                return jobNum;
            }

            set
            {
                jobNum = value;
            }
        }

        public string JobName
        {
            get
            {
                return jobName;
            }

            set
            {
                jobName = value;
            }
        }

        public UpdPws()
        {
            InitializeComponent();
        }

        private void btnAckn_Click(object sender, EventArgs e)
        {
            string oldPws = this.textOldPws.Text;
            string newPws = this.textNewPws.Text;
            string acknPws = this.textAckn.Text;

            if(newPws.Equals(acknPws))
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string oldSql = string.Format("select password from users where jobNum={0}",this.JobNum);
                    mysql.Comd = new MySqlCommand(oldSql,mysql.Conn);
                    MySqlDataReader rd = mysql.Comd.ExecuteReader();
                    rd.Read();
                    string dataPws = rd["password"].ToString();
                    mysql.Conn.Close();
                    if (dataPws==oldPws)
                    {
                        if(newPws.Length<=18)
                        {
                            mysql.Conn.Open();
                            string newSql = string.Format("update users set password={0} where jobNum={1}",newPws,this.JobNum);
                            mysql.Comd.CommandText = newSql;
                            mysql.Comd.ExecuteNonQuery();
                            this.textAckn.Text = "";
                            this.textNewPws.Text = "";
                            this.textOldPws.Text = "";
                            MessageBox.Show("密码修改成功！");
                            btnBack_Click(sender,e);
                        }
                        else
                        {
                            MessageBox.Show("密码过长！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("旧密码不正确！");
                    }
                }
            }
            else
            {
                MessageBox.Show("两次密码不同！");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Manage m = new Manage();
            m.L = this.L;
            m.JobNum = this.JobNum;
            m.JobName = this.JobName;
            m.Show();
            this.Dispose();
        }

        private void UpdPws_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;

            if(Tools.dom)
            {
                result = MessageBox.Show("是否要退出系统？", "提示", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Tools.dom = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
