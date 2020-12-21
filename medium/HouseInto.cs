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
    public partial class HouseInto : Form
    {
        private string jobNum;
        private Form l;
        private string card;
        private string cliCard;
        private string jobName;
        private ConnetionMysql mysql = new ConnetionMysql();

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

        public string Card
        {
            get
            {
                return card;
            }

            set
            {
                card = value;
            }
        }

        public string CliCard
        {
            get
            {
                return cliCard;
            }

            set
            {
                cliCard = value;
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

        public HouseInto()
        {
            InitializeComponent();
        }

        private void HouseInto_Load(object sender, EventArgs e)
        {
            using (mysql.Conn)
            {
                mysql.Conn.Open();
                string sql = string.Format("select c.name as cliName,c.cardCli,c.sex,c.cardNo,c.number,h.address,h.state,h.insDate,h.estPrice,h.suggest,u.name as adminName from client as c inner join house h inner join users u on c.cardCli=h.cardCli and h.addCard=u.jobNum where h.card='{0}';",
                    this.Card);
                mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                MySqlDataReader rd= mysql.Comd.ExecuteReader();

                rd.Read();
                int sex = (int)rd["sex"];
                int state = (int)rd["state"];
                string strState="";

                switch(state)
                {
                    case (int)Enums.vacancy:
                        {
                            strState = "空置";
                            break;
                        }
                    case (int)Enums.sell:strState = "出售"; break;
                    case (int)Enums.hire: strState = "出租"; break;
                    case (int)Enums.houseDel: strState = "下架"; break;
                }
                this.textName.Text =Convert.ToString(rd["cliName"]);
                this.textAddress.Text = (string )rd["address"];
                this.textAdmin.Text = (string)rd["adminName"];
                this.textState.Text = strState;
                this.textCardNo.Text = (string)rd["cardNo"];
                this.textDate.Text = rd["insDate"].ToString();
                this.comboSex.SelectedIndex = (int)rd["sex"];
                this.textEstPrice.Text =rd["estPrice"].ToString();
                this.textNumber.Text = rd["number"].ToString();
                this.textSuggest.Text = rd["suggest"].ToString();
                this.CliCard = rd["cardCli"].ToString();

                if(state!=(int)Enums.vacancy)
                {
                    this.textTrade.Enabled = false;
                }
            }
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

        private void btnUpd_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text;
            string cardNo = this.textCardNo.Text;
            string strSex = this.comboSex.SelectedItem.ToString();
            string number = this.textNumber.Text;
            string address = this.textAddress.Text;
            string suggest = this.textSuggest.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            int sex = 2;

            if(strSex=="男")
            {
                sex = (int)Enums.man;
            }
            else if(strSex == "女")
            {
                sex = (int)Enums.woman;
            }
            
            if(name!=""&&cardNo!=""&&number!=""&&address!=""&&suggest!=""&&sex>=0&&sex<2)
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string cliSql = string.Format("update client set name='{0}',cardNo='{1}',sex={2},number='{3}',endDate='{4}' where cardCli='{5}'",
                        name,cardNo,sex,number,date,this.CliCard);
                    string houseSql = string.Format("update house set address='{0}',suggest='{1}',updDate='{2}' where card='{3}'",
                        address,suggest,date,this.Card);

                    MySqlTransaction trans = mysql.Conn.BeginTransaction();
                    mysql.Comd.Transaction = trans;

                    mysql.Comd = new MySqlCommand(cliSql,mysql.Conn);
                    int index = mysql.Comd.ExecuteNonQuery();

                    mysql.Comd.CommandText = houseSql;
                    index+=mysql.Comd.ExecuteNonQuery();

                    if(index>1)
                    {
                        trans.Commit();
                        ManageHouse house = new ManageHouse();
                        house.JobNum = this.JobNum;
                        house.L = this.L;
                        house.JobName = this.JobName;
                        house.Messge = "房源信息更新成功！";
                        house.Show();
                        this.Dispose();

                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("更新失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("必填项不能为空！");
            }
            
        }

        private void textTrade_Click(object sender, EventArgs e)
        {
            dealhouse deal = new dealhouse();
            deal.JobNum = this.JobNum;
            deal.L = this.L;
            deal.Card = this.Card;
            deal.JobName = this.JobName;
            deal.Show();
            this.Dispose();
        }

        private void HouseInto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void HouseInto_KeyDown(object sender, KeyEventArgs e)
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
