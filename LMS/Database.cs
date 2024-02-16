using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Database
    {
        //Establishing an database connection
        public SqlConnection DBConnect()
        {
            string con_string = "Data Source=DARK_PHOENIX\\SQLEXPRESS;Initial Catalog=LMS1;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(con_string);
            return con;
        }
    }
}
