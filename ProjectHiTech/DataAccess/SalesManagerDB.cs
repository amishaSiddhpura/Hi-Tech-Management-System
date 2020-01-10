using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ProjectHiTech.Business;
using ProjectHiTech.Business;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectHiTech.DataAccess
{
    public  class SalesManagerDB
    {
        public static SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public static SqlConnection connection = UtilityDB.ConnectDB();
        public static DataSet CreateTableDB(DataSet dsProject,DataTable dtCustomer)
        {
            DataColumn customerIDAuto = dtCustomer.Columns.Add("CustomerID", typeof(Int32));
            customerIDAuto.AutoIncrement = true;
            customerIDAuto.AutoIncrementSeed = 1;
            customerIDAuto.AutoIncrementStep = 1;

            dtCustomer.Columns.Add("CustomerName", typeof(string));
            dtCustomer.Columns.Add("Street", typeof(string));
            dtCustomer.Columns.Add("City", typeof(string));
            dtCustomer.Columns.Add("PostalCode", typeof(string));
            dtCustomer.Columns.Add("PhoneNumber", typeof(string));
            dtCustomer.Columns.Add("FaxNumber", typeof(string));
            dtCustomer.Columns.Add("CreditLimit", typeof(float));

            dtCustomer.PrimaryKey = new DataColumn[] { dtCustomer.Columns["CustomerID"] };

            dsProject.Tables.Add(dtCustomer);

            return dsProject;
        }

        public static void ReadDataFromDataset(DataSet dsproject,DataTable dtcustomer)
        {
            sqlDataAdapter = new SqlDataAdapter("select * from customerDetails", connection);

            sqlDataAdapter.Fill(dsproject.Tables["customer"]);
        }
        public static bool SaveRecordDataSet(DataSet dsproject, DataTable dtcustomer, Salesmanager manager)
        {
            try
            {
                dtcustomer.Rows.Add(null, manager.CustomerName, manager.Street, manager.City,
                 manager.PostalCode, manager.PhoneNumber, manager.FaxNumber, manager.CreditLimit);

                //! whenever you want to make a column auto-increment in DataTable then you have to insert null into it.

                string query = String.Format("Insert into customerDetails values ('{0}','{1}','{2}','{3}','{4}','{5}',{6}) ",
                    manager.CustomerName, manager.Street, manager.City, manager.PostalCode,
                    manager.PhoneNumber, manager.FaxNumber, manager.CreditLimit);

                sqlDataAdapter.InsertCommand = new SqlCommand(query, connection);

                sqlDataAdapter.Update(dsproject, "customer"); //! table n
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public static bool UpdateRecordDataSet(DataSet dsproject, DataTable dtcustomer, Salesmanager manager)
        {
            try
            {
                DataRow drFindCustomerID = dtcustomer.Rows.Find(manager.CustomerID);

                drFindCustomerID["CustomerID"] = manager.CustomerID;
                drFindCustomerID["CustomerName"] = manager.CustomerName;
                drFindCustomerID["Street"] = manager.Street;
                drFindCustomerID["City"] = manager.City;
                drFindCustomerID["PostalCode"] = manager.PostalCode;
                drFindCustomerID["PhoneNumber"] = manager.PhoneNumber;
                drFindCustomerID["FaxNumber"] = manager.FaxNumber;
                drFindCustomerID["CreditLimit"] = manager.CreditLimit;

                string query = string.Format("Update customerDetails set CustomerName ='{0}', Street ='{1}',City ='{2}', " +
               " PostalCode ='{3}', PhoneNumber ='{4}',FaxNumber ='{5}',CreditLimit ='{6}' where CustomerID = {7}",
                   manager.CustomerName, manager.Street, manager.City, manager.PostalCode,
                   manager.PhoneNumber, manager.FaxNumber, manager.CreditLimit, manager.CustomerID);

                sqlDataAdapter.UpdateCommand = new SqlCommand(query, connection);
                sqlDataAdapter.Update(dsproject, "customer");

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public static bool DeleteCustomerDataSet(DataSet dsproject,DataTable dtcustomer,Salesmanager manager)
        {
            try
                
            {
                DataRow drFindCustomer = dtcustomer.Rows.Find(manager.CustomerID);
                drFindCustomer.Delete();
                string que = string.Format("Delete From customerDetails Where CustomerID = {0}", manager.CustomerID);
                sqlDataAdapter.DeleteCommand = new SqlCommand(que, connection);
                sqlDataAdapter.Update(dsproject, "customer");
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
                return false;
            }
        }

        public static DataTable SearchCustomerRecord(DataTable dtCustomer, Salesmanager manager)
        {
            DataTable dtSearch = new DataTable("customerSearch");
            
            string queryText = "";
           
            if (manager.CustomerID != 0)
            {
                queryText = string.Format(" CustomerID = {0} ", manager.CustomerID);
            }
            else if (!string.IsNullOrEmpty(manager.CustomerName))
            {
                queryText = string.Format(" CustomerName LIKE '%{0}%' ", manager.CustomerName);
            }
            else if (!string.IsNullOrEmpty(manager.City))
            {
                queryText = string.Format(" City LIKE '%{0}%' ", manager.City);
            }

            dtSearch = dtCustomer.Select(queryText).CopyToDataTable();
            return dtSearch;
        }
    }
}
