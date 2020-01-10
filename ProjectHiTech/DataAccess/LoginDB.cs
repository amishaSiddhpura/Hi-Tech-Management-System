using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectHiTech.Business;

namespace ProjectHiTech.DataAccess
{
    public class LoginDB
    {
        public static int CheckUserLoginDB(LoginUser login)
        {
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.CommandText = String.Format("Select Count(*) from users where Username = '{0}' and Password = '{1}'",
                                                            login.Username, login.Password);


                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if(count != 0)
                    {
                        sqlCommand.CommandText = String.Format("Select PositionId from users where Username = '{0}' and Password = '{1}'",
                                                         login.Username, login.Password);
                        
                        int role = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        return role;
                    }
                    return -1;
                }
                catch (Exception)
                {
                    return -1;
                }

            }
        }

    }
}
