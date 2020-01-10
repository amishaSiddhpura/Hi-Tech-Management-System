using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectHiTech.DataAccess;

namespace ProjectHiTech.Business
{
    public class Salesmanager
    {
        private int customerId;
        private string customerName;
        private string street;
        private string city;
        private string postalCode;
        private string phoneNo;
        private string faxNo;
        private float creditLimit;


        public int CustomerID { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string PhoneNumber { get => phoneNo; set => phoneNo = value; }
        public string FaxNumber { get => faxNo; set => faxNo = value; }
        public float CreditLimit { get=>creditLimit; set=>creditLimit=value; }

        public DataSet CreateTable(DataSet ds,DataTable dt)
        {
            return SalesManagerDB.CreateTableDB(ds, dt);
        }
        public void ReadData(DataSet ds,DataTable dt)
        {
            SalesManagerDB.ReadDataFromDataset(ds, dt);
        }
        public bool SaveCustomerRecord(DataSet dsproject, DataTable dtcustomer, Salesmanager manager)
        {
            return SalesManagerDB.SaveRecordDataSet(dsproject, dtcustomer, manager);
        }


        public bool UpdateCustomerRecord(DataSet dsproject, DataTable dtcustomer, Salesmanager manager)
        {
            return SalesManagerDB.UpdateRecordDataSet(dsproject, dtcustomer, manager);
        }

        public bool DeleteCustomerRecord(DataSet dsproject, DataTable dtcustomer, Salesmanager manager)
        {
            return SalesManagerDB.DeleteCustomerDataSet(dsproject, dtcustomer, manager);
        }
        public DataTable SearchRecord(DataTable dtCustomer, Salesmanager manager)
        {
            return SalesManagerDB.SearchCustomerRecord(dtCustomer, manager);
        }

    }
}
