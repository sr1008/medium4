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
using System.IO;

namespace medium
{
    public partial class ManageSaff : FatherManage
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

        public ManageSaff()
        {
            InitializeComponent();
        }

        private void ManageSaff_Load(object sender, EventArgs e)
        {
            if(this.Messge!=null&&this.Messge!="")
            {
                MessageBox.Show(this.Messge);
            }

            this.comboSex.SelectedIndex = 0;
            this.comboStatus.SelectedIndex = 0;
            showData();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnUpdate";
            btn.HeaderText = "修改";
            btn.DefaultCellStyle.NullValue = "修改";
            this.dataSaff.Columns.Add(btn);

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            btnDel.Name = "btnDelete";
            btnDel.HeaderText = "删除";
            btnDel.DefaultCellStyle.NullValue = "删除";
            this.dataSaff.Columns.Add(btnDel);

            DataGridViewButtonColumn btnReset = new DataGridViewButtonColumn();
            btnReset.Name = "btnReset";
            btnReset.HeaderText = "密码重置";
            btnReset.DefaultCellStyle.NullValue = "重置";
            this.dataSaff.Columns.Add(btnReset);
        }

        /*
         * 数据显示
         * */
        private void showData()
        {
            if(data.Tables["users"]!=null)
            {
                data.Tables[0].Clear();
            }
            using (mysql.Conn)
            {
                string sql = string.Format("select * from users where jobNum <> {0}", this.JobNum);
                mysql.Da = new MySqlDataAdapter(sql, mysql.Conn);
                mysql.Da.Fill(data, "users");
                //DataSet dataTemp = new DataSet();
                // data.Tables[0].Columns["sex"].DataType =Type.GetType("System.String");
                //  data.Tables[0].Columns["status"].DataType = Type.GetType("System.String");
                if(data.Tables[0].Columns["sex1"]==null)
                {
                    data.Tables[0].Columns.Add("sex1", Type.GetType("System.String"));
                }

                if (data.Tables[0].Columns["status1"] == null)
                {
                    data.Tables[0].Columns.Add("status1", Type.GetType("System.String"));
                }
                
                foreach (DataRow row in data.Tables[0].Rows)
                {
                    int sex = (int)row["sex"];

                    if (sex == (int)Enums.man)
                    {
                        row["sex1"] = "男";
                    }
                    else
                    {

                        // row["sex"].GetType.
                        row["sex1"] = "女";
                    }

                    int status = (int)row["status"];
                    if (status == (int)Enums.staff)
                    {
                        row["status1"] = "业务员";
                    }
                    else
                    {
                        row["status1"] = "管理员";
                    }

                }

                this.dataSaff.AutoGenerateColumns = false;
                this.dataSaff.DataSource = data.Tables[0];
            }
        }

        private void dataSaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate(e);
            btnDelete(e);
            btnReset(e);
        }

        /*
         * 密码重置
         * */
        private void btnReset(DataGridViewCellEventArgs e)
        {
            if (this.dataSaff.Columns[e.ColumnIndex].Name == "btnReset" && e.RowIndex >= 0)
            {
                DataGridViewColumn col = this.dataSaff.Columns[e.ColumnIndex];
                string job = (string)this.dataSaff.CurrentRow.Cells[0].Value;
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    string sql = string.Format("update users set password={0} where jobNum={0}",job,job);
                    mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                    int index=mysql.Comd.ExecuteNonQuery();
                    if(index>0)
                    {
                        showData();
                        MessageBox.Show("密码重置成功！");
                    }else
                    {
                        MessageBox.Show("密码重置失败！");
                    }
                }
            }
         }

       /*
        * 点击删除
        * */
         private void btnDelete(DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show("delete1");
            if (this.dataSaff.Columns[e.ColumnIndex].Name == "btnDelete" && e.RowIndex >= 0)
            {
              //  MessageBox.Show("delete");
                DataGridViewColumn col = this.dataSaff.Columns[e.ColumnIndex];
                string job = (string)this.dataSaff.CurrentRow.Cells[0].Value;
                using (mysql.Conn)
                {
                    mysql.Conn.Open();
                    String sql = string.Format("delete from users where jobNum={0}",job);
                    mysql.Comd = new MySqlCommand(sql,mysql.Conn);
                    int index = mysql.Comd.ExecuteNonQuery();
                    if(index>0)
                    {
                        showData();
                        MessageBox.Show("删除成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        /**
         * 
         * 点击修改
         */
        private void btnUpdate(DataGridViewCellEventArgs e)
        {
            if (this.dataSaff.Columns[e.ColumnIndex].Name == "btnUpdate" && e.RowIndex >= 0)
            {
                DataGridViewColumn col = this.dataSaff.Columns[e.ColumnIndex];
                int sex = 3;
                if ((string)this.dataSaff.CurrentRow.Cells[2].Value == "男")
                {
                    sex = (int)Enums.man;
                }
                else if ((string)this.dataSaff.CurrentRow.Cells[2].Value == "女")
                {
                    sex = (int)Enums.woman;
                }

                int status = 3;
                if ((string)this.dataSaff.CurrentRow.Cells[5].Value == "管理员")
                {
                    status = (int)Enums.manage;
                }
                else if ((string)this.dataSaff.CurrentRow.Cells[5].Value == "业务员")
                {
                    status = (int)Enums.staff;
                }
                string name = (string)this.dataSaff.CurrentRow.Cells[1].Value;
                string cardNo = (string)this.dataSaff.CurrentRow.Cells[3].Value;
                string number = (string)this.dataSaff.CurrentRow.Cells[4].Value;
                string job = (string)this.dataSaff.CurrentRow.Cells[0].Value;
                if (sex == 0 || sex == 1)
                {
                    if (status == 0 || status == 1)
                    {
                        string sql = string.Format("update users set name='{0}' , sex={1} , cardNo='{2}' , number='{3}' , status={4} where jobNum='{5}'", name, sex, cardNo, number, status, job);
                        using (mysql.Conn)
                        {
                            mysql.Conn.Open();
                            mysql.Comd = new MySqlCommand(sql, mysql.Conn);
                            int index = mysql.Comd.ExecuteNonQuery();
                            if (index > 0)
                            {
                                MessageBox.Show("修改成功！");
                            }
                            else
                            {
                                MessageBox.Show("修改失败!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("职务输入不正确（管理员/业务员）");
                    }
                }
                else
                {
                    MessageBox.Show("性别输入不正确（男/女）");
                }

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SaffInsert ins = new SaffInsert();
            ins.Job = this.JobNum;
            ins.L = this.L;
            ins.JobName = this.JobName;
            ins.Show();
            this.Dispose();
        }

        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string name = this.textname.Text;
            string cardNo = this.textCardNo.Text;
            string number = this.textNumber.Text;
            string jobNum = this.textJobNum.Text;

            int sex = 2;
            int status = 2;
            string strSex = (string)this.comboSex.SelectedItem;
            string strStatus = (string)this.comboStatus.SelectedItem;
            if (strSex == "男")
            {
                sex = (int)Enums.man;
            }
            else if(strSex == "女")
            {
                sex = (int)Enums.woman;
            }

            if (strStatus == "管理员")
            {
                status = (int)Enums.manage;
            }
            else if(strStatus == "业务员")
            {
                status = (int)Enums.staff;
            }

            this.dateBegin.Format = DateTimePickerFormat.Custom;
            this.dateBegin.CustomFormat = "yyyy-MM-dd";
            this.dateEnd.Format = DateTimePickerFormat.Custom;
            this.dateEnd.CustomFormat = "yyyy-MM-dd";

            string dateBegin = this.dateBegin.Text;
            string dateEnd = this.dateEnd.Text;

            showData(name,number,cardNo,jobNum,dateBegin,dateEnd,sex,status);

        }

        private void showData(string name,string number,string cardNo,string jobNum,string dateBegin,string dateEnd,int sex,int status)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select * from users  where jobNum <> '{0}'",this.JobNum);
            if(name!="")
            {
                sql.AppendFormat(" and name='{0}'",name);
            }

            if (number != "")
            {
                sql.AppendFormat(" and number='{0}'", number);
            }

            if (cardNo != "")
            {
                sql.AppendFormat(" and cardNo='{0}'", cardNo);
            }

            if (jobNum != "")
            {
                sql.AppendFormat(" and jobNum='{0}'", jobNum);
            }

            if (sex!=2)
            {
                sql.AppendFormat(" and sex={0}", sex);
            }

            if (status != 2)
            {
                sql.AppendFormat(" and status={0}", status);
            }

            if(dateBegin!="" && dateEnd!="")
            {
                sql.AppendFormat(" and endDate between '{0}' and '{1}'",dateBegin,dateEnd);
            }

          //  MessageBox.Show(Convert.ToString( sql));
            if (data.Tables["users"] != null)
            {
                data.Tables[0].Clear();
            }

            using (mysql.Conn)
            {
                mysql.Da = new MySqlDataAdapter(Convert.ToString(sql),mysql.Conn);
                mysql.Da.Fill(data, "users");
                //DataSet dataTemp = new DataSet();
                // data.Tables[0].Columns["sex"].DataType =Type.GetType("System.String");
                //  data.Tables[0].Columns["status"].DataType = Type.GetType("System.String");
                if (data.Tables[0].Columns["sex1"] == null)
                {
                    data.Tables[0].Columns.Add("sex1", Type.GetType("System.String"));
                }

                if (data.Tables[0].Columns["status1"] == null)
                {
                    data.Tables[0].Columns.Add("status1", Type.GetType("System.String"));
                }

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    int sex1 = (int)row["sex"];

                    if (sex1 == (int)Enums.man)
                    {
                        row["sex1"] = "男";
                    }
                    else
                    {

                        // row["sex"].GetType.
                        row["sex1"] = "女";
                    }

                    int status1 = (int)row["status"];
                    if (status1 == (int)Enums.staff)
                    {
                        row["status1"] = "业务员";
                    }
                    else
                    {
                        row["status1"] = "管理员";
                    }

                }

                this.dataSaff.AutoGenerateColumns = false;
                this.dataSaff.DataSource = data.Tables[0];
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Tools.ExportSaff(data);
        }
    }
}
