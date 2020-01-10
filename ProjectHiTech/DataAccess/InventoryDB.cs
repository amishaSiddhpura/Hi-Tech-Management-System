using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHiTech.Business;
using System.Data.SqlClient;


namespace ProjectHiTech.DataAccess
{
    public class InventoryDB
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
        public static DataTable ReadBookData()
        {
            string queryText = String.Format("Select * from bookDetails");
            return MISManagerDB.ExecuteReaderQuery(queryText);
        }
    }
}
