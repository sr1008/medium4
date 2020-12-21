using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medium
{
    public partial class FatherManage : Form
    {
        private string jobNum;
        private Form l;
        private int userStatus;
        private string jobName;

        public FatherManage()
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

        public virtual void lbInfo_Click(object sender, EventArgs e)
        {
            Manage m = new Manage();
            m.JobNum = this.JobNum;
            m.L = this.L;
            m.JobName = this.JobName;
            m.Show();
            this.Dispose();
        }

        public virtual void lbSaff_Click(object sender, EventArgs e)
        {
            ManageSaff saff = new ManageSaff();
            saff.JobNum = this.JobNum;
            saff.L = this.L;
            saff.JobName = this.JobName;
            saff.Show();
            this.Dispose();
        }

        public virtual void lbHome_Click(object sender, EventArgs e)
        {
            ManageHouse house = new ManageHouse();
            house.JobNum = this.JobNum;
            house.L = this.L;
            house.JobName = this.JobName;
            house.Show();
            this.Dispose();
        }

        public virtual void lbRent_Click(object sender, EventArgs e)
        {
            ManageRent rent = new ManageRent();
            rent.JobNum = this.JobNum;
            rent.L = this.L;
            rent.UserStatus = this.UserStatus;
            rent.JobName = this.JobName;
            rent.Show();
            this.Dispose();
        }

        private void FatherManage_Load(object sender, EventArgs e)
        {
           if(this.UserStatus!=(int)Enums.manage)
            {
                this.lbSaff.Hide();
                this.lbHome.Top = 70;
                this.lbRent.Top = 100;
                this.lbOut.Top = 130;
            }

            this.statusInfo.Items[1].Text = this.JobNum;
            this.statusInfo.Items[4].Text=this.JobName;
        }

        private void FatherManage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FatherManage_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Escape)
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
    }
}
