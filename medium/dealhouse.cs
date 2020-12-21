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
    public partial class dealhouse : Form
    {
        private string jobNum;
        private Form l;
        private string card;
        private string houseClient;
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

        public string HouseClient
        {
            get
            {
                return houseClient;
            }

            set
            {
                houseClient = value;
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

        public dealhouse()
        {
            InitializeComponent();
        }

        private void dealhouse_Load(object sender, EventArgs e)
        {
            using (mysql.Conn)
            {
                mysql.Conn.Open();
                string sql = string.Format("select address,cardCli,suggest from house where card='{0}'",this.Card);
                mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                MySqlDataReader rd = mysql.Comd.ExecuteReader();

                rd.Read();
                this.textAddress.Text = rd["address"].ToString();
                this.textInto.Text = rd["suggest"].ToString();
                this.HouseClient = rd["cardCli"].ToString();

            }

            this.comboSex.SelectedIndex = 0;
            this.comboType.SelectedIndex = 0;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text;
            string cardNo = this.textCardNo.Text;
            string number = this.textNumber.Text;
            string factPrice = this.textFactPrice.Text;
            string strSex = this.comboSex.SelectedItem.ToString();
            string strType = this.comboType.SelectedItem.ToString();
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            int sex = (int)Enums.man;
            int type = (int)Enums.hire;

            if(strSex=="男")
            {
                sex = (int)Enums.man;
            }
            else if(strSex=="女")
            {
                sex = (int)Enums.woman;
            }

            if(strType=="租赁")
            {
                type = (int)Enums.hire;
            }
            else if(strType=="购买")
            {
                type = (int)Enums.sell;
            }
            Random ran = new Random();
            string orderCard = ran.Next(100000, 1000000).ToString();
            string cliCard = ran.Next(10000,100000).ToString();

            if(name!=""&&cardNo!=""&&number!=""&&factPrice!="")
            {
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string clientSql = string.Format("insert into client(cardCli,name,sex,cardNo,number,endDate,status) values('{0}','{1}',{2},'{3}','{4}','{5}',{6})",
                        cliCard,name,sex,cardNo,number,date,(int)Enums.resCli);
                    string orderSql = string.Format("insert into orderhouse(orderCard,hostClient,guestClient,houseCard,type,endDate,factPrice,operateMan) values('{0}','{1}','{2}','{3}',{4},'{5}',{6},'{7}')",
                        orderCard,this.HouseClient,cliCard,this.Card,type,date,factPrice,this.JobNum);
                    string updHouse = string.Format("update house set state={0} where card='{1}'",type,card);

                    MySqlTransaction trans = mysql.Conn.BeginTransaction();
                    mysql.Comd = new MySqlCommand(clientSql,mysql.Conn);
                    mysql.Comd.Transaction = trans;

                    int index=mysql.Comd.ExecuteNonQuery();
                    mysql.Comd.CommandText = orderSql;
                    index+=mysql.Comd.ExecuteNonQuery();

                    mysql.Comd.CommandText = updHouse;
                    index += mysql.Comd.ExecuteNonQuery();

                    if(index>2)
                    {
                        trans.Commit();
                        ManageHouse house = new ManageHouse();
                        house.JobNum = this.JobNum;
                        house.L = this.L;
                        house.JobName = this.JobName;
                        house.Messge = "订单生产成功！";
                        house.Show();
                        this.Dispose();
                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("订单生产失败！");
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
            ManageHouse house = new ManageHouse();
            house.JobNum = this.JobNum;
            house.L = this.L;
            house.JobName = this.JobName;
            house.Show();
            this.Dispose();
        }

        private void dealhouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (Tools.dom)
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
