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
    public partial class Login : Form
    {
        private int staff = (int)Enums.staff;
        private int manage = (int)Enums.manage;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string jobNum = this.textJobNum.Text;
            string password = this.textPwb.Text;
            ConnetionMysql mysql = new ConnetionMysql();
            if (jobNum != "" && password != "")
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string sql = string.Format("select * from users where jobNum='{0}' and password='{1}'", jobNum, password);
                    mysql.Comd = new MySqlCommand(sql, mysql.Conn);
                    MySqlDataReader data = mysql.Comd.ExecuteReader();
                   
                    if (data.HasRows)
                    {
                        data.Read();
                        if (data["password"].Equals(password))
                        {
                            Manage manage = new Manage();
                            manage.JobNum = (string)data["jobNum"];
                            manage.L = this;
                            manage.UserStatus = Convert.ToInt32(data["status"]);
                            manage.JobName = data["name"].ToString();
                            this.Hide();
                            manage.Show();
                            mysql.Conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("密码错误！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户不存在！");
                    }
                    /* if (data.HasRows)
                     {
                          if (data.Read())
                          {
                              if (data["jobNum"].Equals(jobNum) && data["password"].Equals(password))
                              {
                                  if (Convert.ToInt32(data["status"]) == staff)
                                  {
                                      Staff staff = new Staff(jobNum);
                                      staff.Show();
                                      this.Hide();
                                      mysql.Conn.Close();
                                  }
                                  else if (Convert.ToInt32(data["status"]).Equals((int)Enums.manage))
                                  {
                                      Manage manage = new Manage();
                                      manage.JobNum = (string)data["jobNum"];
                                      manage.L = this;
                                      manage.UserStatus = Convert.ToInt32(data["status"]);
                                      this.Hide();
                                      manage.Show();
                                      mysql.Conn.Close();
                                  }
                              }
                          }

                      }else
                      {
                          MessageBox.Show("工号或者密码错误！");
                      }


                  } */
                }
            }
            else
              {
                  MessageBox.Show("工号或者密码不能为空！");
              }
   
        }

        private void Login_Load(object sender, EventArgs e)
        {
           // Manage m = new Manage();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }

            if(e.KeyCode==Keys.Escape)
            {
                DialogResult result;
                result = MessageBox.Show("是否要退出系统？", "提示", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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
