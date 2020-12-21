using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace medium
{
    class ConnetionMysql
    {
        private MySqlConnection  conn;
        private string strConn= "server=localhost;port=3306;database=db_medium;user=root;password=123456;SslMode=none";
        private MySqlCommand comd;
        private MySqlDataAdapter da;

        public MySqlConnection Conn
        {
            get
            {
                if(conn!=null)
                {
                    return conn;
                }
                else
                {
                    return conn = new MySqlConnection(strConn);
                }
                
            }
        }

        public MySqlCommand Comd
        {
            get
            {
                return comd;
            }

            set
            {
                comd = value;
            }
        }

        public MySqlDataAdapter Da
        {
            get
            {
                return da;
            }

            set
            {
                da = value;
            }
        }
    }
}
