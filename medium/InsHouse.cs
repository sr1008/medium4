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
    public partial class InsHouse : Form
    {
        private ConnetionMysql mysql = new ConnetionMysql();
        private Form l;
        private string jobNum;
        private string jobName;

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

        public InsHouse()
        {
            InitializeComponent();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text;
            string cardNo = this.textCardNo.Text;
            string number = this.textNumber.Text;
            string strSex = (string)this.comboSex.SelectedItem;
            string address = this.textAddress.Text;
            string suggssest = this.textSuggssest.Text;
            string estPrice= this.textEstPrice.Text;
            int sex = 0;

            if(strSex=="男")
            {
                sex = (int)Enums.man;
            }
            else if(strSex=="女")
            {
                sex = (int)Enums.woman;
            }
            Random rd = new Random();
            string cardCli = Convert.ToString( rd.Next(10000,100000));
            string houseCard = Convert.ToString(rd.Next(100000,1000000));
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            if(name!=""&&cardNo!=""&&number!=""&&address!=""&&suggssest!=""&&estPrice!="")
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string cliSql = string.Format("insert into client(cardCli,name,sex,cardNo,number,status,endDate) values('{0}','{1}',{2},'{3}','{4}',{5},'{6}')",
                        cardCli,name,sex,cardNo,number,(int)Enums.houseCli,date);
                    string houseSql = string.Format("insert into house(card,address,state,cardCli,insDate,UpdDate,estPrice,addCard,suggest) values('{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}','{8}')",
                        houseCard, address, (int)Enums.vacancy, cardCli, date, date, estPrice, this.JobNum, suggssest);

                    mysql.Comd = new MySqlCommand(cliSql,mysql.Conn);
                    MySqlTransaction tran = mysql.Conn.BeginTransaction();
                    mysql.Comd.Transaction = tran;
                    int index = mysql.Comd.ExecuteNonQuery();
                    mysql.Comd.CommandText = houseSql;
                    index += mysql.Comd.ExecuteNonQuery();

                    if(index>1)
                    {
                        tran.Commit();
                        ManageHouse house = new ManageHouse();
                        house.JobNum = this.JobNum;
                        house.L = this.L;
                        house.JobName = this.JobName;
                        house.Messge = "房源添加成功！";
                        house.Show();
                        this.Dispose();
                    }
                    else
                    {
                        tran.Rollback();
                        MessageBox.Show("房源添加失败！");
                    }

                }
            }
            else
            {
                MessageBox.Show("必填项不能为空！");
            }
            
        }

        private void InsHouse_Load(object sender, EventArgs e)
        {
            this.comboSex.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageHouse house = new ManageHouse();
            house.JobNum = this.JobNum;
            house.L = this.L;
            house.JobName = this.JobName;
            house.Show();
            this.Dispose();
        }

        private void InsHouse_FormClosing(object sender, FormClosingEventArgs e)
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

        private void InsHouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
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
