using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medium
{
    /**
     * 员工类
     * */
    class User
    {
        private int id;
        private string jobNum;//工号
        private int sex;
        private string cardNo;//身份证号
        private string number;//电话号码
        private int stutas;//身份0管理员1员工

        public User(string jobNum, int sex, string cardNo, string number, int stutas)
        {
            this.jobNum = jobNum;
            this.sex = sex;
            this.cardNo = cardNo;
            this.number = number;
            this.stutas = stutas;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public int Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string CardNo
        {
            get
            {
                return cardNo;
            }

            set
            {
                cardNo = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}
