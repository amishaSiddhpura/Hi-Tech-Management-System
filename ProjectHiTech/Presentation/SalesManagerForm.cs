using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHiTech.Business;

namespace ProjectHiTech.Presentation
{
    public partial class SalesManagerForm : Form
    {
        DataSet dsproject = new DataSet("project_db");
        DataTable dtcustomer = new DataTable("customer");


        public SalesManagerForm()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            textBoxCustomerId.Clear();
            textBoxCustomerName.Clear();
            textBoxStreetName.Clear();
            textBoxCityName.Clear();
            textBoxPostalCode.Clear();
            textBoxPhoneNo.Clear();
            textBoxFaxNo.Clear();
            textBoxCreditLimit.Clear();
        }
        public bool CheckISNullOREmpty(int checkNumber)
        {
            switch (checkNumber)
            {
                case 1:
                    return !String.IsNullOrEmpty(textBoxCustomerName.Text) && !String.IsNullOrEmpty(textBoxStreetName.Text)
                        && !String.IsNullOrEmpty(textBoxCityName.Text) && !String.IsNullOrEmpty(textBoxPostalCode.Text)
                        && !String.IsNullOrEmpty(textBoxPhoneNo.Text) && !String.IsNullOrEmpty(textBoxFaxNo.Text)
                        && !String.IsNullOrEmpty(textBoxCreditLimit.Text);
                case 2:
                    return !String.IsNullOrEmpty(textBoxSearch.Text);

                default:

                    return false;
            }
        }

        private void SalesManager_Load(object sender, EventArgs e)
        {
            textBoxCustomerId.Enabled = false; // Disable CustomerID textBox 
          

            comboBoxSearch.Text = comboBoxSearch.Items[0] as string;

            Salesmanager salesManager = new Salesmanager();
            this.dsproject = salesManager.CreateTable(this.dsproject, this.dtcustomer);

            salesManager.ReadData(this.dsproject, this.dtcustomer);

            dataGridViewShow.DataSource = dtcustomer;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                    Salesmanager salesManager = new Salesmanager();
                    //salesManager.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
                    salesManager.CustomerName = textBoxCustomerName.Text;
                    salesManager.Street = textBoxStreetName.Text;
                    salesManager.City = textBoxCityName.Text;
                    salesManager.PostalCode = textBoxPostalCode.Text;
                    salesManager.PhoneNumber = textBoxPhoneNo.Text;
                    salesManager.FaxNumber = textBoxFaxNo.Text;
                    salesManager.CreditLimit = float.Parse(textBoxCreditLimit.Text);

                    if (salesManager.SaveCustomerRecord(this.dsproject, this.dtcustomer, salesManager))
                    {
                        MessageBox.Show("Customer Recored Inserted..");
                    }
                    else
                    {
                        MessageBox.Show("Customer Recored Is Not Inserted..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Please Enter Values. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1) && !string.IsNullOrEmpty(textBoxCustomerId.Text))
            {
                if (MessageBox.Show("Do You Want to Update this Record", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Salesmanager manager = new Salesmanager();
                    manager.CustomerID = Convert.ToInt32(textBoxCustomerId.Text);
                    manager.CustomerName = textBoxCustomerName.Text;
                    manager.Street = textBoxStreetName.Text;
                    manager.City = textBoxCityName.Text;
                    manager.PostalCode = textBoxPostalCode.Text;
                    manager.PhoneNumber = textBoxPhoneNo.Text;
                    manager.FaxNumber = textBoxFaxNo.Text;
                    manager.CreditLimit = float.Parse(textBoxCreditLimit.Text);


                    if (manager.UpdateCustomerRecord(this.dsproject, this.dtcustomer, manager))
                    {
                        MessageBox.Show("Customer Record Is Updated.");
                    }
                    else
                    {
                        MessageBox.Show("Customer Recored Is Not Updated..", "Error", MessageBoxButtons.OK);

                    }
                }
                this.ClearTextBox();
            }
            else
            {
                MessageBox.Show("Please Select a Row For Update Operation.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1) && !string.IsNullOrEmpty(textBoxCustomerId.Text))
            {
                if (MessageBox.Show("Do You Want to Delete this Record", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Salesmanager manager = new Salesmanager();
                    manager.CustomerID = Convert.ToInt32(textBoxCustomerId.Text);

                    if (manager.DeleteCustomerRecord(dsproject, dtcustomer, manager))
                    {
                        MessageBox.Show("Customer record is deleted...");
                    }
                    else
                    {
                        MessageBox.Show("Customer record is not deleted..", "Error", MessageBoxButtons.OK);
                    }
                    this.ClearTextBox();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row For Delete Operation.");
            }
        }

        private void dataGridViewShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewShow.Rows[e.RowIndex];
                textBoxCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
                textBoxCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                textBoxStreetName.Text = row.Cells["Street"].Value.ToString();
                textBoxCityName.Text = row.Cells["City"].Value.ToString();
                textBoxPostalCode.Text = row.Cells["PostalCode"].Value.ToString();
                textBoxPhoneNo.Text = row.Cells["PhoneNumber"].Value.ToString();
                textBoxFaxNo.Text = row.Cells["FaxNumber"].Value.ToString();
                textBoxCreditLimit.Text = row.Cells["CreditLimit"].Value.ToString();
            }
        }
        public void SearchRecoredAllInOne(DataTable dtcustomer, Salesmanager manager)
        {
            DataTable dataTable = manager.SearchRecord(dtcustomer, manager);
            if (dataTable.Rows.Count != 0)
            {
                dataGridViewSearch.DataSource = dataTable;
            }
            else
            {
                dataGridViewSearch.DataSource = null;
                MessageBox.Show("Record not Found.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            this.ClearTextBox();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(2))
            {
                try
                {
                    Salesmanager salesManager = new Salesmanager();

                    if (comboBoxSearch.Text == Convert.ToString(comboBoxSearch.Items[0])) // CustomerID
                    {
                        salesManager.CustomerID = Convert.ToInt32(textBoxSearch.Text);
                    }
                    else if (comboBoxSearch.Text == Convert.ToString(comboBoxSearch.Items[1])) // CustomerName
                    {
                        salesManager.CustomerName = textBoxSearch.Text;
                    }
                    else if (comboBoxSearch.Text == Convert.ToString(comboBoxSearch.Items[2])) // CustomerName
                    {
                        salesManager.City = textBoxSearch.Text;
                    }
                    DataTable dataTable = salesManager.SearchRecord(dtcustomer, salesManager);

                    if (dataTable != null)
                    {
                        dataGridViewSearch.DataSource = dataTable;
                    }
                    else
                    {
                        dataGridViewSearch.DataSource = null;
                        MessageBox.Show("Record not Found.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    this.ClearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select and Enter Correct Search Field and Search ");
                    this.ClearTextBox();
                }
            }
            else
            {
                MessageBox.Show("Please enter some data in search box");

            }

        }

    }
}
