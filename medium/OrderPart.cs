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
    public partial class OrderPart : Form
    {
        private string jobNum;
        private Form l;
        private string orderCard;
        private string jobName;
        private ConnetionMysql mysql = new ConnetionMysql();
        
        public OrderPart()
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

        public string OrderCard
        {
            get
            {
                return orderCard;
            }

            set
            {
                orderCard = value;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageRent rent = new ManageRent();
            rent.JobNum = this.JobNum;
            rent.L = this.L;
            rent.JobName = this.jobName;
            rent.Show();
            this.Dispose();
        }

        private void OrderPart_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            using (mysql.Conn)
            {
                mysql.Conn.Open();
                string sql = string.Format("select h.suggest,h.address,c1.number as hostNumber,c1.cardNo as hostCardNo,c1.sex as hostSex,c1.name as hostName,c2.number as guestNumber,c2.name as guestName,c2.cardNo as guestCardNo,c2.sex as guestSex,o.type,o.factPrice,o.endDate,o.operateMan ,u.name as operateName from orderhouse as o INNER JOIN client as c1 INNER JOIN client as c2 INNER JOIN house as h inner join users as u on o.guestClient=c1.cardCli and o.guestClient=c2.cardCli and o.houseCard=h.card and o.operateMan=u.jobNum where o.orderCard='{0}'",
                    this.OrderCard);

                mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                MySqlDataReader rd = mysql.Comd.ExecuteReader();

                while (rd.Read())
                {
                    this.textAddress.Text = rd["address"].ToString();
                    this.textSugest.Text = rd["suggest"].ToString();

                    this.textHostName.Text = rd["hostName"].ToString();
                    this.textHostCardNo.Text = rd["hostCardNo"].ToString();
                    this.textHostNumber.Text = rd["hostNumber"].ToString();

                    int hostSex = Convert.ToInt32(rd["hostSex"]);
                    string strSex = "";
                    if (hostSex == (int)Enums.man)
                    {
                        strSex = "男";
                    }
                    else
                    {
                        strSex = "女";
                    }

                    this.textHostSex.Text = strSex;

                    this.textGuestName.Text = rd["guestName"].ToString();
                    this.textGuestCardNo.Text = rd["guestCardNo"].ToString();
                    this.textGuestNumber.Text = rd["guestNumber"].ToString();

                    int guestSex = Convert.ToInt32(rd["guestSex"]);
                    string strGuestSex = "";
                    if(guestSex==(int)Enums.man)
                    {
                        strGuestSex = "男";
                    }
                    else
                    {
                        strGuestSex = "女";
                    }

                    this.textGuestSex.Text = strGuestSex;

                    int type=Convert.ToInt32(rd["type"]);
                    string strType = "";
                    if(type==(int)Enums.hire)
                    {
                        strType = "租赁";
                    }
                    else
                    {
                        strType = "出售";
                    }

                    this.textType.Text = strType;

                    this.textPrice.Text = rd["factPrice"].ToString();
                    this.textOperateCard.Text = rd["operateMan"].ToString();
                    this.textOperateName.Text = rd["operateName"].ToString();
                    this.textDate.Text = rd["endDate"].ToString();
                }

            }
        }

        private void OrderPart_FormClosing(object sender, FormClosingEventArgs e)
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

        private void OrderPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result;
                result = MessageBox.Show("是否要退出系统？","提示",MessageBoxButtons.YesNo);

                if(result==DialogResult.Yes)
                {
                    Application.Exit();
                }
                
            }
        }
    }
}
