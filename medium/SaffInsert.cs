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
    public partial class SaffInsert : Form
    {
        private ConnetionMysql mysql = new ConnetionMysql();

        private string job;
        private Form l;
        private string jobNum;
        private string jobName;

        public string Job
        {
            get
            {
                return job;
            }

            set
            {
                job = value;
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

        public SaffInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text.Trim();
            string number = this.textNumber.Text.Trim();
            string cardNo = this.textCardNo.Text.Trim();
            int sex = 0;
            int status = 0;
            string strSex =(string) this.comboSex.SelectedItem;
            string strStatus = (string)this.comboStatus.SelectedItem;
            if (strSex == "男")
            {
                sex = (int)Enums.man;
            }
            else
            {
                sex = (int)Enums.woman;
            }

            if(strStatus=="管理员")
            {
                status = (int)Enums.manage;
            }
            else
            {
                status = (int)Enums.staff;
            }

            Random rd = new Random();
            string jobNum = rd.Next(10000, 100000).ToString();
            string password = jobNum;
            string addJobNum = this.Job;
            string endDate = DateTime.Now.ToString("yyyy-MM-dd");
            if(name!=""&&number!=""&&cardNo!=""&&cardNo.Length<=18&&number.Length<=11)
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string sql = string.Format("insert into users(jobNum,name,number,cardNo,sex,status,endDate,addJobNum,password) values('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}')",
                        jobNum,name,number,cardNo,sex,status,endDate,addJobNum,password);
                    mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                    int index= mysql.Comd.ExecuteNonQuery();
                    if(index>0)
                    {
                        ManageSaff saff = new ManageSaff();
                        saff.L = this.L;
                        saff.JobNum = this.Job;
                        saff.JobName = this.JobName;
                        saff.Messge = "添加成功！";
                        saff.Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("职工添加失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("必填项不能为空！");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageSaff saff = new ManageSaff();
            saff.L = this.L;
            saff.JobNum = this.Job;
            saff.JobName = this.JobName;
            saff.Show();
            this.Dispose();
        }

        private void SaffInsert_Load(object sender, EventArgs e)
        {
            this.comboSex.SelectedIndex = 0;
            this.comboStatus.SelectedIndex = 0;
        }

        private void SaffInsert_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SaffInsert_KeyDown(object sender, KeyEventArgs e)
        {
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
    }
}
