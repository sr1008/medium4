using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace medium
{
    public partial class ManageRent : medium.FatherManage
    {
        private DataSet data = new DataSet();
        private ConnetionMysql mysql = new ConnetionMysql();
        private int sta;

        public int Sta
        {
            get
            {
                return sta;
            }

            set
            {
                sta = value;
            }
        }

        public ManageRent()
        {
            InitializeComponent();
        }

        private void ManageRent_Load(object sender, EventArgs e)
        {
            int s = 0;
            using (mysql.Conn)
            {
                mysql.Conn.Open();
                string sqlUser = string.Format("select status from users where jobNum='{0}'", this.JobNum);
                mysql.Comd = new MySqlCommand(sqlUser, mysql.Conn);
               MySqlDataReader rd = mysql.Comd.ExecuteReader();
                rd.Read();
                s = (int)rd["status"];
            }
            this.Sta = s;

            this.dateBegin.Format = DateTimePickerFormat.Custom;
            this.dateBegin.CustomFormat = "yyyy/MM/dd";
            this.dateEnd.Format = DateTimePickerFormat.Custom;
            this.dateEnd.CustomFormat = "yyyy/MM/dd";
            this.comboSex.SelectedIndex = 0;

            this.dataRent.AutoGenerateColumns = false;
            this.btnInto.DefaultCellStyle.NullValue = "详细";
            showData(s);
        }

        private void showData(int s)
        {
            if(data.Tables["order"]!=null)
            {
                data.Tables["order"].Clear();
            }

            using (mysql.Conn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select o.orderCard,o.houseCard,h.address,o.hostClient,c1.number as hosetNumber,c1.name as hosetName,o.guestClient,c2.number as guestNumber,c2.name as geustName,o.type,o.factPrice,o.endDate,o.operateMan from orderhouse as o INNER JOIN client as c1 INNER JOIN client as c2 INNER JOIN house as h on o.guestClient=c1.cardCli and o.guestClient=c2.cardCli and o.houseCard=h.card");

                if (s == (int)Enums.staff)
                {
                    sql.AppendFormat(" where o.operateMan='{0}'", this.JobNum);
                }
               // MessageBox.Show(Convert.ToString(sql));
                mysql.Da = new MySqlDataAdapter(Convert.ToString(sql),mysql.Conn);
                mysql.Da.Fill(data,"order");

                if(data.Tables["order"].Columns["strType"]==null)
                {
                    data.Tables["order"].Columns.Add("strType", Type.GetType("System.String"));
                }

                int type=0;
                foreach(DataRow row in data.Tables["order"].Rows)
                {
                    type = (int)row["type"];
                    if(type==(int)Enums.hire)
                    {
                        row["strType"] = "租赁";
                    }
                    else if(type == (int)Enums.sell)
                    {
                        row["strType"] = "出售";
                    }
                }

                this.dataRent.DataSource = data.Tables["order"];
            }

        }

        private void dataRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataRent.Columns[e.ColumnIndex].Name=="btnInto"&&e.RowIndex>=0)
            {
                string orderCard =(string) this.dataRent.CurrentRow.Cells[0].Value;

                OrderPart part = new OrderPart();
                part.JobNum = this.JobNum;
                part.L = this.L;
                part.JobName = this.JobName;
                part.OrderCard = orderCard;
                part.Show();
                this.Dispose();
            }
        }

       

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string orderCard = this.textOrderCard.Text;
            string houseCard = this.textHouseCard.Text;
            string houseAddress = this.textAddress.Text;

            string hostCard = this.textHostCard.Text;
            string hostNumber = this.textHostNumber.Text;
            string hostName = this.textHostName.Text;

            string guestCard = this.textGuestCard.Text;
            string guestNumber = this.textGuestNumber.Text;
            string guestName = this.textGuestName.Text;

            string strType = this.comboSex.SelectedItem.ToString();
            int type = 4;

            if(strType=="租赁")
            {
                type = (int)Enums.hire;
            }
            else if(strType=="出售")
            {
                type = (int)Enums.sell;
            }

            string beginPrice = this.textBeginPrice.Text;
            string endPrice = this.textEndPrice.Text;

            string beginDate = this.dateBegin.Text;
            string endDate = this.dateEnd.Text;

            showData(orderCard,houseCard,houseAddress,hostCard,hostNumber,hostName,guestCard,guestNumber,guestName,type,beginPrice,endPrice,beginDate,endDate);
        }

        private void showData(string orderCard,string houseCard,string houseAddress,string hostCard,string hostNumber,string hostName,string guestCard,string guestNumber,string guestName,int type,string beginPrice,string endPrice,string beginDate, string endDate)
        {
            if (data.Tables["order"] != null)
            {
                data.Tables["order"].Clear();
            }

            using (mysql.Conn)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select o.orderCard,o.houseCard,h.address,o.hostClient,c1.number as hosetNumber,c1.name as hosetName,o.guestClient,c2.number as guestNumber,c2.name as geustName,o.type,o.factPrice,o.endDate,o.operateMan from orderhouse as o INNER JOIN client as c1 INNER JOIN client as c2 INNER JOIN house as h on o.guestClient=c1.cardCli and o.guestClient=c2.cardCli and o.houseCard=h.card");

                if (this.Sta == (int)Enums.staff)
                {
                    sql.AppendFormat(" where o.operateMan='{0}'", this.JobNum);
                }

                if (orderCard !="")
                {
                    sql.AppendFormat(" and o.orderCard='{0}'", orderCard);
                }

                if (houseCard !="")
                {
                    sql.AppendFormat(" and o.houseCard='{0}'", houseCard);
                }

                if (houseAddress != "")
                {
                    sql.AppendFormat(" and h.address='{0}'", houseAddress);
                }

                if (hostCard != "")
                {
                    sql.AppendFormat(" and o.hostClient='{0}'", hostCard);
                }

                if (hostNumber != "")
                {
                    sql.AppendFormat(" and c1.number='{0}'", hostNumber);
                }

                if (hostName != "")
                {
                    sql.AppendFormat(" and c1.name='{0}'", hostName);
                }

                if (guestCard != "")
                {
                    sql.AppendFormat(" and o.guestClient='{0}'", guestCard);
                }

                if (guestNumber != "")
                {
                    sql.AppendFormat(" and c2.number='{0}'", guestNumber);
                }

                if (guestName != "")
                {
                    sql.AppendFormat(" and c2.name='{0}'", guestName);
                }

                if (type != 4)
                {
                    sql.AppendFormat(" and o.type={0}", type);
                }

                if (Regex.IsMatch(beginPrice, @"^[+-] ?\d *[.] ?\d * $")&& Regex.IsMatch(endPrice, @"^[+-] ?\d *[.] ?\d * $"))
                {
                    sql.AppendFormat(" and o.factPrice between {0} and {1}", Convert.ToDouble(beginPrice),Convert.ToDouble(endPrice));
                }

                if (beginDate!="" && endDate!="")
                {
                    sql.AppendFormat(" and o.endDate between '{0}' and '{1}'", beginDate,endDate);
                }

                //MessageBox.Show(Convert.ToString(sql));
                mysql.Da = new MySqlDataAdapter(Convert.ToString(sql), mysql.Conn);
                mysql.Da.Fill(data, "order");

                if (data.Tables["order"].Columns["strType"] == null)
                {
                    data.Tables["order"].Columns.Add("strType", Type.GetType("System.String"));
                }

                int type1 = 0;
                foreach (DataRow row in data.Tables["order"].Rows)
                {
                    type1 = (int)row["type"];
                    if (type1 == (int)Enums.hire)
                    {
                        row["strType"] = "租赁";
                    }
                    else if (type1 == (int)Enums.sell)
                    {
                        row["strType"] = "出售";
                    }
                }

                this.dataRent.DataSource = data.Tables["order"];
            }
            }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Tools.ExportOrder(data);
        }
    }
}
