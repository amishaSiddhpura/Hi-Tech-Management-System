using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectHiTech.Presentation
{
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
        }
        public void clearTextBox()
        {
            textBoxInvoiceID.Clear();
            textBoxtotalPrice.Clear();
            

        }
        HitechProjectEntities3 entity = new HitechProjectEntities3();
        public bool CheckISNullOREmpty(int checkNumber)
        {
            switch (checkNumber)
            {
                case 1:
                    return !String.IsNullOrEmpty(textBoxInvoiceID.Text) &&
                        !String.IsNullOrEmpty(textBoxtotalPrice.Text) &&
                        !String.IsNullOrEmpty(comboBoxTOP.Text) &&
                        !String.IsNullOrEmpty(dateTimePicker2.Text);


                case 2:
                   // return !String.IsNullOrEmpty(textBoxSearch.Text);

                default:
                    //! Return false in default case 
                    return false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                try
                {
                    invoice invoices = new invoice();
                    invoices.invoiceID = Convert.ToInt32(textBoxInvoiceID.Text);
                    invoices.totalPrice = Convert.ToInt32(textBoxtotalPrice.Text);
                    invoices.paymentDate = dateTimePicker2.Value.Date;
                    invoices.typeOfPayment = Convert.ToString(comboBoxTOP.SelectedItem);
                    entity.invoices.Add(invoices);
                    entity.SaveChanges();
                    ShowInvoiceOrderData();
                    MessageBox.Show("Invoice Inserted..");
                    this.clearTextBox();
                    
                }
                catch (Exception ex)
                {
                   
                }
            }
            else
            {
                MessageBox.Show("Please Enter Customer Order Values. ", "Error", MessageBoxButtons.OK);
            }
        }
        public void ShowInvoiceOrderData()
        {
            var invoiceDisplay = entity.invoices.Select(c => new
            
             {
                 c.invoiceID,
                 c.totalPrice,
                 c.typeOfPayment,
                 c.paymentDate
                
             });
            dataGridViewShow.DataSource = invoiceDisplay.ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                if (MessageBox.Show("Do You Want to Update this Record", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int invoiceID = Convert.ToInt32(textBoxInvoiceID.Text);
                        var invoice = entity.invoices.Find(invoiceID);
                       if(invoice != null)
                        {
                            invoice.totalPrice = Convert.ToInt16(textBoxtotalPrice.Text);
                            invoice.paymentDate = dateTimePicker2.Value.Date;
                            invoice.typeOfPayment = comboBoxTOP.SelectedItem.ToString();
                            entity.SaveChanges();
                            this.ShowInvoiceOrderData();
                            MessageBox.Show("Invoice Updated");
                            this.clearTextBox();
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Recored Is Not Updated..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.ClearTextBoxCO();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row For Update Operation.");
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                if (MessageBox.Show("Do You Want to Update this Record", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int invoiceID = Convert.ToInt32(textBoxInvoiceID.Text);
                        var invoice = entity.invoices.Find(invoiceID);
                        if(invoice != null)
                        {
                            entity.invoices.Remove(invoice);
                            entity.SaveChanges();
                            this.ShowInvoiceOrderData();
                            MessageBox.Show("Invoice Deleted");
                            this.clearTextBox();
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Recored Is Not Updated..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.ClearTextBoxCO();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row For Update Operation.");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string file_name = @"../../invoice.txt";

            using (StreamWriter writer = File.CreateText(file_name))
            {

                foreach (invoice i in entity.invoices)
                {
                    writer.WriteLine(i.invoiceID + " | " + i.totalPrice + "|" + i.typeOfPayment + "|" + i.paymentDate);
                }
                MessageBox.Show("Invoice had been printed into invoice.text file");

            }
        }

        private void dataGridViewShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewShow.Rows[e.RowIndex];
                textBoxInvoiceID.Text = row.Cells["invoiceID"].Value.ToString();
                textBoxtotalPrice.Text = row.Cells["totalPrice"].Value.ToString();
                comboBoxTOP.Text = row.Cells["typeOfPayment"].Value.ToString();
                dateTimePicker2.Text = row.Cells["paymentDate"].Value.ToString();


            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            ShowInvoiceOrderData();
        }
    }
}
