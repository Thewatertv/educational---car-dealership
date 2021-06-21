using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DB_Car_Dealership
{
    class SqlConnect
    {

        public static SqlConnection sql_con = new SqlConnection(@"Data Source=SANEK;Initial Catalog=Lada_Avtosalon;Persist Security Info=True;User ID=sa;Password=1");

        public static bool connect_open()
        {
            bool temp = false;
            try
            {
                sql_con.Open();
                temp = true;
            }
            catch
            {
                temp = false;
            }
            return temp;
        }

        public static void sqlconnect_close()
        {
            try
            {
                sql_con.Close();
            }
            catch { }
        }


    }
}
