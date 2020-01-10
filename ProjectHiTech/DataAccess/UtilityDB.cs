using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectHiTech.DataAccess
{
    public  class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {//connect database with winodws authentication
            SqlConnection connection = new SqlConnection("data source = . ; database = project_db; Integrated security = SSPI");
            connection.Open();
            return connection;

        }
    }
}
