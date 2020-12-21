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
    public partial class Manage : Form
    {
        private string jobNum;
        private Form l;
        private int userStatus;
        private string jobName;
       
        private ConnetionMysql mysql = new ConnetionMysql();
        public Manage()
        {
            InitializeComponent();
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

        public int UserStatus
        {
            get
            {
                return userStatus;
            }

            set
            {
                userStatus = value;
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

        private void lbOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            l.Show();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            string number = this.textNumber.Text.Trim();
            if(number.Length==11)
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string sql = string.Format("update users set number={0} where jobNum={1}",number,jobNum);
                    mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                    int index=mysql.Comd.ExecuteNonQuery();
                    if(index>0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                }
            }
            else
            {
                MessageBox.Show("电话号码格式不正确！");
            }

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(jobNum);

            this.statusInfo.Items[1].Text = this.JobNum;
            this.statusInfo.Items[4].Text = this.JobName;

            

            using (mysql.Conn)
            {
                mysql.Conn.Open();
                string sql = string.Format("select * from users where jobNum={0}",jobNum);
                mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                MySqlDataReader reader= mysql.Comd.ExecuteReader();
                if(reader.HasRows)
                {
                    if(reader.Read())
                    {
                        this.textJobNum.Text = (string)reader["jobNum"];
                        this.textName.Text = (string)reader["name"];
                        this.textCordNo.Text = (string)reader["cardNo"];
                        int sex = (int)reader["sex"];
                        string strSex = sex == (int)Enums.man ? "男" : "女";
                        this.textSex.Text = strSex;
                        this.textNumber.Text = (string)reader["number"];
                        this.UserStatus = (int)reader["status"];
                        mysql.Conn.Close();
                    }
                }
            }

            if (this.UserStatus != (int)Enums.manage)
            {
                this.lbSaff.Hide();
                this.lbHome.Top = 70;
                this.lbRent.Top = 100;
                this.lbOut.Top = 130;
            }
        }

        private void lbSaff_Click(object sender, EventArgs e)
        {
            ManageSaff saff = new ManageSaff();
            saff.JobNum = jobNum;
            saff.L = l;
            saff.UserStatus = this.UserStatus;
            saff.JobName = this.JobName;
            saff.Show();
            this.Dispose();
        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            ManageHouse house = new ManageHouse();
            house.JobNum = jobNum;
            house.L = l;
            house.UserStatus = this.UserStatus;
            house.JobName = this.JobName;
            house.Show();
            this.Dispose();
        }

        private void lbRent_Click(object sender, EventArgs e)
        {
            ManageRent rent = new ManageRent();
            rent.JobNum = this.JobNum;
            rent.L = this.L;
            rent.UserStatus = this.UserStatus;
            rent.JobName = this.JobName;
            rent.Show();
            this.Dispose();
        }

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Manage_KeyDown(object sender, KeyEventArgs e)
        {
            /* if (e.KeyCode == Keys.Escape)
             {
                 DialogResult result;
                 result = MessageBox.Show("是否要退出系统？", "提示", MessageBoxButtons.YesNo);

                 if (result == DialogResult.Yes)
                 {
                     Application.Exit();
                 }

             }
              */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdPws p = new UpdPws();
            p.L = this.L;
            p.JobName = this.JobName;
            p.JobNum = this.JobNum;
            p.Show();
            this.Dispose();
        }
    }
}
