using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectHiTech.Business;
using System.Data.SqlClient;

namespace ProjectHiTech.DataAccess
{
    public static class MISManagerDB
    {
        public static DataTable ExecuteReaderQuery(string queryText)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = UtilityDB.ConnectDB())
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.CommandText = queryText;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    dataTable.Load(dataReader);
                    return dataTable;
                }
            }
            catch (Exception)
            {
                return dataTable;

            }
        }

        private static bool SqlNonQuery(string queryText)
        {
            try
            {
                using (SqlConnection conn = UtilityDB.ConnectDB())
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.CommandText = queryText;
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static DataTable ReadUserDetails()
        {
            string queryText = String.Format("Select * from users");
            return MISManagerDB.ExecuteReaderQuery(queryText);
        }
        public static bool SaveRecoredDB(MISmanager manager)
        {
            string queryText = String.Format("Insert into users values ('{0}','{1}','{2}','{3}',{4})", manager.Firstname, manager.Lastname,
                                                manager.Username,manager.Password,manager.Position);
            return MISManagerDB.SqlNonQuery(queryText);
        }
        public static bool UpdateRecordDB(MISmanager manager)
        {
            string queryText = String.Format("Update users set Firstname = '{0}', Lastname = '{1}',Username = '{2}',Password = '{3}',PositionId = {4} where UserId = {5} ",
                                              manager.Firstname, manager.Lastname,
                                                manager.Username, manager.Password, manager.Position,manager.UserID);
            return MISManagerDB.SqlNonQuery(queryText);
        }
        public static bool UpdatePassword(MISmanager manager)
        {
            string queryText = String.Format("Update users set Password = '{0}' where Username = '{1}'", manager.Password, manager.Username);
            return MISManagerDB.SqlNonQuery(queryText);
        }
        public static bool DeleteRecordDB(MISmanager manager)
        {
            string queryText = String.Format("Delete From users where UserId = {0} ", manager.UserID);
            return MISManagerDB.SqlNonQuery(queryText);
        }

        public static DataTable SearchRecordDB(MISmanager manager,int index)
        {
            string queryText = "";
            if (index == 1)
            {
                queryText = String.Format("Select * from users where UserId = {0} ", manager.UserID);

            }
            else if (index == 2)
            {
                queryText = String.Format("Select * from users where Firstname = '{0}' ", manager.Firstname);
            }
            else if (index == 3)
            {
                queryText = String.Format("Select * from users where Username = '{0}' ", manager.Username);
            }
            return MISManagerDB.ExecuteReaderQuery(queryText);

        }
    }
}
