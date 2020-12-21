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
    public partial class ManageHouse : medium.FatherManage
    {
        private ConnetionMysql mysql = new ConnetionMysql();
        private DataSet data = new DataSet();
        private string messge;

        public string Messge
        {
            get
            {
                return messge;
            }

            set
            {
                messge = value;
            }
        }

        public ManageHouse()
        {
            InitializeComponent();
        }

        private void ManageHouse_Load(object sender, EventArgs e)
        {
            if(this.Messge!=null&&this.Messge!="")
            {
                MessageBox.Show(this.Messge);
            }

            this.btnDetele.DefaultCellStyle.NullValue = "删除";
            this.btnInto.DefaultCellStyle.NullValue = "详细";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnUpdate";
            btn.HeaderText = "修改";
            btn.DefaultCellStyle.NullValue = "修改";
            this.dataHouse.Columns.Add(btn);
            this.dataHouse.AutoGenerateColumns = false;
            this.comboState.SelectedIndex = 0;
            showData();
        }

        private void showData()
        {
            if(data.Tables["HCT"]!=null)
            {
                data.Tables["HCT"].Clear();
            }
            using (mysql.Conn)
            {
                string sql = string.Format("select card,address,state,h.cardCli,c.name,c.number,estPrice,insDate from house as h inner join client c on h.cardCli=c.cardCli where h.state <> {0}",(int)Enums.houseDel);
                mysql.Da = new MySqlDataAdapter(sql,mysql.Conn);
                mysql.Da.Fill(data,"HCT"); 

                if(data.Tables["HCT"].Columns["houseState"]==null)
                {
                    data.Tables["HCT"].Columns.Add("houseState",Type.GetType("System.String"));
                }
                StringBuilder temp = new StringBuilder();

                //foreach(DataColumn col in data.Tables[0].Columns)
              //  {
                  //  temp.Append(col.ColumnName);
               // }

               // MessageBox.Show(Convert.ToString(temp));
                foreach(DataRow row in data.Tables["HCT"].Rows)
                {
                    if((int)row["state"]==(int)Enums.vacancy)
                    {
                        row["houseState"] = "空置";
                    }

                    if ((int)row["state"] == (int)Enums.hire)
                    {
                        row["houseState"] = "出租";
                    }

                    if ((int)row["state"] == (int)Enums.sell)
                    {
                        row["houseState"] = "出售";
                    }

                    this.dataHouse.DataSource = data.Tables["HCT"];
                }
            }
        }

        private void dataHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnDelete(e);
            BtnUpdate(e);
            BtnInto(e);
        }

        /*
         * 详细
         * */
         private void BtnInto(DataGridViewCellEventArgs e)
        {
            if (this.dataHouse.Columns[e.ColumnIndex].Name == "btnInto" && e.RowIndex >= 0)
            {
                DataGridViewColumn col = this.dataHouse.Columns[e.ColumnIndex];
                string cardHouse = (string)this.dataHouse.CurrentRow.Cells[0].Value;

                HouseInto into = new HouseInto();
                into.JobNum = this.JobNum;
                into.L = this.L;
                into.JobName = this.JobName;
                into.Card = cardHouse;
                into.Show();
                this.Dispose();
            }
         }

        /*
         * 修改
         * */
        private void BtnUpdate(DataGridViewCellEventArgs e)
        {
            if(this.dataHouse.Columns[e.ColumnIndex].Name == "btnUpdate" && e.RowIndex >= 0)
            {
                DataGridViewColumn col = this.dataHouse.Columns[e.ColumnIndex];
                string cardCli = (string)this.dataHouse.CurrentRow.Cells[4].Value;
                string houseCard = (string)this.dataHouse.CurrentRow.Cells[0].Value;
                double estPrice = (double)this.dataHouse.CurrentRow.Cells[1].Value;
                string address = (string)this.dataHouse.CurrentRow.Cells[2].Value;
                string name = (string)this.dataHouse.CurrentRow.Cells[5].Value;
                string number = (string)this.dataHouse.CurrentRow.Cells[6].Value;

                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string CliSql = string.Format("update client set name='{0}' , number='{1}' where cardCli='{2}'",name,number,cardCli);
                    string houseSql = string.Format("update house set address='{0}' , estPrice={1} where card='{2}'",address,estPrice,houseCard);

                    MySqlTransaction trans = mysql.Conn.BeginTransaction();
                    mysql.Comd = new MySqlCommand(CliSql,mysql.Conn);

                    mysql.Comd.Transaction = trans;

                    int index = mysql.Comd.ExecuteNonQuery();
                    mysql.Comd.CommandText = houseSql;
                    index += mysql.Comd.ExecuteNonQuery();
                    
                    if(index>1)
                    {
                        trans.Commit();
                        MessageBox.Show("修改成功！");
                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("修改失败！");
                    }

                }
            }
        }

        /*
         * 删除按钮
         * */
         private void BtnDelete(DataGridViewCellEventArgs e)
        {
            if(this.dataHouse.Columns[e.ColumnIndex].Name== "btnDetele" && e.RowIndex>=0)
            {
                DataGridViewColumn col = this.dataHouse.Columns[e.ColumnIndex];
                string card =(string) this.dataHouse.CurrentRow.Cells[0].Value;
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string sql = string.Format("update house set state={0} where card='{1}'",(int)Enums.houseDel,card);
                    mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                    int index = mysql.Comd.ExecuteNonQuery();

                    if(index>0)
                    {
                        MessageBox.Show("删除成功！");
                        showData();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string houseCard = this.textHouseCard.Text;
            double priceBegin = -1;
            double priceEnd = -1;

            if(this.textPriceBegin.Text!="")
            {
                priceBegin = Convert.ToDouble(this.textPriceBegin.Text);
            }
           
            if(this.textPriceEnd.Text!="")
            {
                priceEnd = Convert.ToDouble(this.textPriceEnd.Text);
            }
            
            // if (Regex.IsMatch(this.textPriceBegin.Text, @"^[+-] ?\d *[.] ?\d * $"))
            //  {
            // priceBegin = Convert.ToDouble(this.textPriceBegin.Text);
            // }

            // if(Regex.IsMatch(this.textPriceEnd.Text, @"^[+-] ?\d *[.] ?\d * $"))
            // {
            // priceEnd = Convert.ToDouble(this.textPriceEnd.Text);
            // }

            string address = this.textAddress.Text;
            string strSate = this.comboState.SelectedItem.ToString();
            string ClientName = this.textClientName.Text;
            string number = this.textNumber.Text;

            this.dateBegin.Format = DateTimePickerFormat.Custom;
            this.dateBegin.CustomFormat = "yyyy-MM-dd";
            this.dateEnd.Format = DateTimePickerFormat.Custom;
            this.dateEnd.CustomFormat = "yyyy-MM-dd";

            string dateBegin = this.dateBegin.Text;
            string dateEnd = this.dateEnd.Text;
            string CilentCard = this.textCilentCard.Text;
            int state = 9;

            if(strSate=="空置")
            {
                state = (int)Enums.vacancy;
            }
            else if(strSate == "租赁")
            {
                state = (int)Enums.hire;
            }
            else if(strSate == "出售")
            {
                state = (int)Enums.sell;
            }
            showData(houseCard,priceBegin,priceEnd,address,state,ClientName,number,dateBegin,dateEnd, CilentCard);
        }

        private void showData(string houseCard,double priceBegin,double priceEnd,string address ,int state,string clientName,string number,string dateBegin,string dateEnd,string clientCard)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select card,address,state,h.cardCli,c.name,c.number,estPrice,insDate from house as h inner join client c on h.cardCli=c.cardCli where h.state <> {0}", (int)Enums.houseDel);
           
            if(houseCard!="")
            {
                sql.AppendFormat(" and card='{0}'",houseCard);
            }
            if (address != "")
            {
                sql.AppendFormat(" and address='{0}'", address);
            }

            if (state != 9)
            {
                sql.AppendFormat(" and state={0}", state);
            }

            if (clientCard != "")
            {
                sql.AppendFormat(" and h.cardCli='{0}'", clientCard);
            }

            if (clientName != "")
            {
                sql.AppendFormat(" and c.name='{0}'", clientName);
            }

            if (number != "")
            {
                sql.AppendFormat(" and c.number='{0}'", number);
            }

            if (priceBegin >=0&& priceEnd>=0)
            {
                sql.AppendFormat(" and estPrice between {0} and {1}", priceBegin,priceEnd);
            }

            if (dateBegin != ""&& dateEnd!="")
            {
                sql.AppendFormat(" and insDate between '{0}' and '{1}'", dateBegin,dateEnd);
            }

            //MessageBox.Show(Convert.ToString(sql));
            this.data.Tables["HCT"].Clear();

            using (mysql.Conn)
            {
                mysql.Da = new MySqlDataAdapter(Convert.ToString( sql),mysql.Conn);
                mysql.Da.Fill(data.Tables["HCT"]);

                foreach (DataRow row in data.Tables["HCT"].Rows)
                {
                    if ((int)row["state"] == (int)Enums.vacancy)
                    {
                        row["houseState"] = "空置";
                    }

                    if ((int)row["state"] == (int)Enums.hire)
                    {
                        row["houseState"] = "出租";
                    }

                    if ((int)row["state"] == (int)Enums.sell)
                    {
                        row["houseState"] = "出售";
                    }
                }

                this.dataHouse.DataSource = data.Tables["HCT"];
            }
        }

        private void btnInsHouse_Click(object sender, EventArgs e)
        {
            InsHouse ins = new InsHouse();
            ins.JobName = this.JobName;
            ins.JobNum = this.JobNum;
            ins.L = this.L;
            ins.Show();
            this.Dispose();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Tools.ExportHouse(data);
        }

        private void textPriceBegin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == 8 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textPriceEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.'||e.KeyChar==8||e.KeyChar==13))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
