using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHiTech.Presentation
{


    public partial class OrderClerksForm : Form
    {
        
        public OrderClerksForm()
        {
            InitializeComponent();
        }
        HitechProjectEntities3 entity = new HitechProjectEntities3();

        public void ClearTextBoxCustomer()
        {
            textBoxCustomerOrderID1.Clear();
            textBoxCustomrID.Clear();
            textBoxSearchCustomer.Clear();

        }
        public void ClearTextBoxBook()
        {
            textBoxCustomerOrderID.Clear();
            textBoxBookId.Clear();
            textBoxQuantity.Clear();
            textBoxSearch.Clear();

        }

        public bool CheckISNullOREmpty(int checkNumber)
        {
            switch (checkNumber)
            {
                case 1:
                    return !String.IsNullOrEmpty(textBoxCustomerOrderID1.Text) && !String.IsNullOrEmpty(textBoxCustomrID.Text);
                case 2:
                    return !String.IsNullOrEmpty(textBoxSearchCustomer.Text);
                case 3:
                    return !String.IsNullOrEmpty(textBoxCustomerOrderID.Text) && !String.IsNullOrEmpty(textBoxBookId.Text)
                        && !String.IsNullOrEmpty(textBoxQuantity.Text);
                case 4:
                    return !String.IsNullOrEmpty(textBoxSearch.Text);

                default:
                    //! Return false in default case 
                    return false;
            }
        }


        private void buttonAddCustomr_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                try
                {
                    customerOrder customerOrder = new customerOrder();
                    customerOrder.CustomerID = Convert.ToInt32(textBoxCustomrID.Text);
                    customerOrder.OrderDate = dateTimePicker1.Value.Date;
                    entity.customerOrders.Add(customerOrder);
                    entity.SaveChanges();
                    ShowCustomerOrderData();
                    MessageBox.Show("Customer Order Recored Inserted..");
                    this.ClearTextBoxCustomer();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Customer Order Recored Is Not Inserted..", "Error", MessageBoxButtons.OK);
                    //this.ClearTextBoxCO();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Customer Order Values. ", "Error", MessageBoxButtons.OK);
            }

        }
        public void ShowCustomerOrderData()
        {
            var customerDisplay = entity.customerOrders.Join(
             entity.customerDetails,
             c1 => c1.CustomerID, c2 => c2.CustomerID,
             (c1, c2) => new
             {
                 c1.CustomerOrderID,
                 c1.CustomerID,
                 c1.OrderDate,
                 c2.CustomerName
             });

            var ShowCustomer = entity.customerDetails.Select(c => c);

            dataGridViewShowCustomerData.DataSource = customerDisplay.ToList();
            dataGridViewSearchedCustomerData.DataSource = ShowCustomer.ToList();
        }
        public void ShowBookData()
        {
            var bookDisplay = entity.bookOrders.Join(
             entity.bookDetails,
             c1 => c1.BookID, c2 => c2.BookID,
             (c1, c2) => new
             {
                 c1.CustomerOrderID,
                 c1.BookID,
                 c1.OrderQuality,
                 c2.Title
             });

            var ShowBookdata = entity.bookDetails.Select(c => c);

            dataGridViewShowBookData.DataSource = bookDisplay.ToList();
            dataGridViewSearchBookData.DataSource = ShowBookdata.ToList();
        }

        private void OrderClerksForm_Load(object sender, EventArgs e)
        {
            // textBoxCustomerOrderID1.Enabled = false;
            ShowCustomerOrderData();
            ShowBookData();


            comboBoxSearchCustomer.Text = comboBoxSearchCustomer.Items[0] as string;

        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1) && !string.IsNullOrEmpty(textBoxCustomerOrderID1.Text))
            {
                if (MessageBox.Show("Do You Want to Update this Record", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {

                        int customerOrderID = Convert.ToInt32(textBoxCustomerOrderID1.Text);
                        // var = customerOrder
                        var checkCustomerOrder = entity.customerOrders.Find(customerOrderID);
                        //MessageBox.Show("checkEmployee = " + checkEmployee);

                        if (checkCustomerOrder != null)
                        {
                            checkCustomerOrder.CustomerID = Convert.ToInt32(textBoxCustomrID.Text);
                            checkCustomerOrder.OrderDate = dateTimePicker1.Value.Date;
                            entity.SaveChanges();
                            this.ShowCustomerOrderData();
                            MessageBox.Show("Record Is Updated.");
                            this.ClearTextBoxCustomer();
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


        private void dataGridViewShowCustomerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewShowCustomerData.Rows[e.RowIndex];
                textBoxCustomerOrderID1.Text = row.Cells["CustomerOrderID"].Value.ToString();
                textBoxCustomrID.Text = row.Cells["CustomerID"].Value.ToString();
                dateTimePicker1.Text = row.Cells["OrderDate"].Value.ToString();
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1) && !string.IsNullOrEmpty(textBoxCustomrID.Text))
            {
                if (MessageBox.Show("Do You Want to Delete this Record", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int customerOrderID = Convert.ToInt32(textBoxCustomerOrderID1.Text);
                        // var = customerOrder
                        var checkCustomerOrder = entity.customerOrders.Find(customerOrderID);

                        if (checkCustomerOrder != null)
                        {
                            entity.customerOrders.Remove(checkCustomerOrder);
                            entity.SaveChanges();
                            this.ShowCustomerOrderData();
                            MessageBox.Show("Deletion Completed.");
                            this.ClearTextBoxCustomer();
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Deletion Is Not Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ClearTextBoxCustomer();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row For Delete Operation.");
                this.ClearTextBoxCustomer();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(2))
            {
                try
                {

                    if (comboBoxSearchCustomer.Text == Convert.ToString(comboBoxSearchCustomer.Items[0])) // CustomerOrderID
                    {
                        int customerOrderID = Convert.ToInt32(textBoxSearchCustomer.Text);

                        var customerOrderId = entity.customerOrders.Join(
                        entity.customerDetails,
                        c1 => c1.CustomerID, c2 => c2.CustomerID,
                        (c1, c2) => new
                        {
                            c1.CustomerOrderID,
                            c1.CustomerID,
                            c1.OrderDate,
                            c2.CustomerName
                        }).Where(c => c.CustomerOrderID == customerOrderID);

                        if (customerOrderId.Count() != 0)
                        {
                            dataGridViewSearchedCustomerData.DataSource = customerOrderId.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Record not Found.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else if (comboBoxSearchCustomer.Text == Convert.ToString(comboBoxSearchCustomer.Items[1])) // CustomerID(CustomerOrder)
                    {
                        int customerID = Convert.ToInt32(textBoxSearchCustomer.Text);

                        var checkCustomerOrder = entity.customerOrders.Join(
                        entity.customerDetails,
                        c1 => c1.CustomerID, c2 => c2.CustomerID,
                        (c1, c2) => new
                        {
                            c1.CustomerOrderID,
                            c1.CustomerID,
                            c1.OrderDate,
                            c2.CustomerName
                        }).Where(c => c.CustomerID == customerID);

                        if (checkCustomerOrder.Count() != 0)
                        {
                            dataGridViewSearchedCustomerData.DataSource = checkCustomerOrder.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Record not Found.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }

                    else if (comboBoxSearchCustomer.Text == Convert.ToString(comboBoxSearchCustomer.Items[2]))
                    {
                        string customerName = textBoxSearchCustomer.Text;

                        var customerOrderName = entity.customerOrders.Join(
                        entity.customerDetails,
                        c1 => c1.CustomerID, c2 => c2.CustomerID,
                        (c1, c2) => new
                        {
                            c1.CustomerOrderID,
                            c1.CustomerID,
                            c1.OrderDate,
                            c2.CustomerName
                        }).Where(c => c.CustomerName.Contains(customerName));

                        if (customerOrderName.Count() != 0)
                        {
                            dataGridViewSearchedCustomerData.DataSource = customerOrderName.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Order Record not Found.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select and Enter Correct Search Field and Search ");
                    this.ClearTextBoxCustomer();
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Data in Search Box.");
            }
        }
        //book Tab


        int cOrderIDUpdate;
        int bookIDUpdate;
        int orderQuantityUpdate;
        private void buttonADD_Click(object sender, EventArgs e)
        {

            if (CheckISNullOREmpty(3))
            {
                try
                {
                    bookOrder bOrder = new bookOrder();
                    bOrder.CustomerOrderID = Convert.ToInt32(textBoxCustomerOrderID.Text);
                    bOrder.BookID = Convert.ToInt32(textBoxBookId.Text);
                    bOrder.OrderQuality = Convert.ToInt32(textBoxQuantity.Text);

                    int checkBookIDQOH = Convert.ToInt32(textBoxBookId.Text);

                    var checkOrderQuantity = entity.bookDetails.Where(
                     x => x.BookID == checkBookIDQOH).Select(x => new { x.QOH, x.Title }).SingleOrDefault();
                    //MessageBox.Show(" " + checkOrderQuantity);

                    if (Convert.ToInt32(textBoxQuantity.Text) <= checkOrderQuantity.QOH)
                    {
                        entity.bookOrders.Add(bOrder);
                        entity.SaveChanges();
                        MessageBox.Show("Recored Inserted..");
                        ShowBookData();
                        ClearTextBoxBook();
                    }
                    else
                    {

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Recored Is Not Inserted..\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.ClearTextBoxCO();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Values. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(3))
            {
                try
                {


                    customerOrder customerorder = new customerOrder();
                    int cutomerId = Convert.ToInt32(textBoxCustomerOrderID.Text);
                    customerorder = entity.customerOrders.Find(cutomerId);

                    bookDetail bookdetail = new bookDetail();
                    int bookid = Convert.ToInt32(textBoxBookId.Text);
                    bookdetail = entity.bookDetails.Find(bookid);

                    bookOrder bookorder1 = new bookOrder();
                  
                    bookorder1.CustomerOrderID = Convert.ToInt32(textBoxCustomerOrderID.Text);
                    bookorder1.BookID = Convert.ToInt32(textBoxBookId.Text);
                    bookorder1.OrderQuality = Convert.ToInt32(textBoxQuantity.Text);
                    bookdetail.BookID = Convert.ToInt32(textBoxBookId.Text);
                    customerorder.CustomerOrderID = Convert.ToInt32(textBoxCustomerOrderID.Text);
                    entity.SaveChanges();
                    ShowBookData();
                    MessageBox.Show("Book Order updated Successfully");
                    ClearTextBoxBook();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Recored Is Not Updated.. \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.ClearTextBoxCO();
                }
            }

        }

        

        private void dataGridViewShowBookData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewShowBookData.Rows[e.RowIndex];

                textBoxCustomerOrderID.Text = row.Cells[0].Value.ToString();
                textBoxBookId.Text = row.Cells[1].Value.ToString();
                textBoxQuantity.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonDElete_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(3))
            {
                if (MessageBox.Show("Do You Want to Delete this Record", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        var checkBookOrder = entity.bookOrders.Where(x => x.CustomerOrderID == cOrderIDUpdate
                                                && x.BookID == bookIDUpdate && x.OrderQuality == orderQuantityUpdate).SingleOrDefault();

                        if (checkBookOrder != null)
                        {
                            entity.bookOrders.Remove(checkBookOrder);
                            entity.SaveChanges();
                            MessageBox.Show("Deletion Completed.");
                            this.ShowBookData();
                            this.ClearTextBoxBook();
                        }
                        else
                        {
                            MessageBox.Show("Deletion Is Not Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.ClearTextBoxBook();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Deletion Is Not Completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ClearTextBoxBook();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row For Delete Operation.");
                this.ClearTextBoxBook();
            }
        }
    }
}
