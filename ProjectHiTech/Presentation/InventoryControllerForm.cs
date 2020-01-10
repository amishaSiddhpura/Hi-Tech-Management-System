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
    public partial class InventoryControllerForm : Form
    {
        public InventoryControllerForm()
        {
            InitializeComponent();
        }
        HitechProjectEntities3 entity = new HitechProjectEntities3();

        private void cleanTextBox()
        {
            textBoxisbn.Text = string.Empty;
            comboBoxCategory.Text = string.Empty;
            textBoxtitle.Text = string.Empty;
            textBoxYearPublished.Text = string.Empty;
            textBoxQoh.Text = string.Empty;
            textBoxAuthorID.Text = string.Empty;
            textBoxFname.Text = string.Empty;
            textBoxLastname.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxSupplierId.Text = string.Empty;
            textBoxpublishedby.Text = string.Empty;
            textBoxUnitPrice.Text = string.Empty;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bookData bd = new bookData();
            author ad = new author();
            supplierData sd = new supplierData();
            bd.ISBN = Convert.ToInt32(textBoxisbn.Text.Trim());
            bd.Category = comboBoxCategory.Text.Trim();
            bd.Title = textBoxtitle.Text.Trim();
            bd.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
            bd.YearPublished = Convert.ToInt32(textBoxYearPublished.Text.Trim());
            bd.Qoh = Convert.ToInt32(textBoxQoh.Text.Trim());
            bd.A_ID = Convert.ToInt32(textBoxAuthorID.Text.Trim());
            ad.AuthorID = Convert.ToInt32(textBoxAuthorID.Text.Trim());
            ad.FirstName = textBoxFname.Text.Trim();
            ad.LastName = textBoxLastname.Text.Trim();
            ad.Email = textBoxEmail.Text.Trim();
            bd.S_ID = Convert.ToInt32(textBoxSupplierId.Text.Trim());
            sd.S_ID = Convert.ToInt32(textBoxSupplierId.Text.Trim());
            sd.Supplier = textBoxSupplierId.Text.Trim();
            entity.bookDatas.Add(bd);
            entity.authors.Add(ad);
            entity.supplierDatas.Add(sd);
            entity.SaveChanges();
            MessageBox.Show("Book Saved successfully");
            cleanTextBox();
            PopulateList();
        }
        public void PopulateList()
        {

            var bookquery = (from book in entity.bookDatas
                            join author in entity.authors
                            on book.A_ID equals author.AuthorID
                            join supplier in entity.supplierDatas
                            on book.S_ID equals supplier.S_ID

                            select new
                            {
                                isbn = book.ISBN,
                                category = book.Category,
                                title = book.Title,
                                price = book.UnitPrice,
                                year = book.YearPublished,
                                qoh = book.Qoh,
                                aid = author.AuthorID,
                                fname = author.FirstName,
                                lname = author.LastName,
                                email = author.Email,
                                sid = supplier.S_ID,
                                publisher = supplier.Supplier

                            }).ToList();


            listView1.Items.Clear();
            foreach (var book in bookquery)
            {

                ListViewItem item = new ListViewItem(Convert.ToString(book.isbn));
                item.SubItems.Add(book.category);
                item.SubItems.Add(book.title);
                item.SubItems.Add(Convert.ToString(book.price));
                item.SubItems.Add(Convert.ToString(book.year));
                item.SubItems.Add(Convert.ToString(book.qoh));
                item.SubItems.Add(Convert.ToString(book.aid));
                item.SubItems.Add(book.fname);
                item.SubItems.Add(book.lname);
                item.SubItems.Add(book.email);
                item.SubItems.Add(Convert.ToString(book.sid));
                item.SubItems.Add(book.publisher);
                listView1.Items.Add(item);
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookData bd = new bookData();
            author ad = new author();
            supplierData sd = new supplierData();
            int isbn = Convert.ToInt32(textBoxisbn.Text.Trim());
            bd = entity.bookDatas.Find(isbn);
            int aid = Convert.ToInt32(textBoxAuthorID.Text.Trim());
            ad = entity.authors.Find(aid);
            int sid = Convert.ToInt32(textBoxSupplierId.Text.Trim());
            sd = entity.supplierDatas.Find(sid);
            if (bd == null && ad == null)
            {
                MessageBox.Show("Duplicated EmployeeId", "Error");
                textBoxisbn.Clear();
                textBoxisbn.Focus();
                return;
            }
            else
            {

                entity.bookDatas.Remove(bd);
                entity.authors.Remove(ad);
                entity.supplierDatas.Remove(sd);
                entity.SaveChanges();
                PopulateList();
                MessageBox.Show("Deleted Successfully");
                cleanTextBox();

            }

        }

        private void InventoryControllerForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Java development");
            comboBoxCategory.Items.Add("Mathematics");
            comboBoxCategory.Items.Add("Web Development");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxisbn.Enabled = false;
            textBoxAuthorID.Enabled = false;
            textBoxSupplierId.Enabled = false;
            int isbn = Convert.ToInt32(textBoxisbn.Text);
            bookData updateBook = entity.bookDatas.Find(isbn);
            int aid = Convert.ToInt32(textBoxAuthorID.Text);
            author updateAuthor = entity.authors.Find(aid);
            int sid = Convert.ToInt32(textBoxSupplierId.Text);
            supplierData updateSupplier = entity.supplierDatas.Find(sid);
            updateBook.Category = comboBoxCategory.Text;
            updateBook.Title = textBoxtitle.Text;
            updateBook.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
            updateBook.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
            updateBook.Qoh = Convert.ToInt32(textBoxQoh.Text);
            updateBook.A_ID = Convert.ToInt32(textBoxAuthorID.Text);
            updateBook.S_ID = Convert.ToInt32(textBoxSupplierId.Text);
            updateAuthor.AuthorID = Convert.ToInt32(textBoxAuthorID.Text);
            updateAuthor.FirstName = textBoxFname.Text;
            updateAuthor.LastName = textBoxLastname.Text;
            updateAuthor.Email = textBoxEmail.Text;
            updateSupplier.S_ID = Convert.ToInt32(textBoxSupplierId.Text);
            updateSupplier.Supplier = textBoxSupplierId.Text;

            entity.SaveChanges();
            PopulateList();
            MessageBox.Show("Book Update successful");
            cleanTextBox();
            textBoxisbn.Enabled = true;
            textBoxAuthorID.Enabled = true;
            textBoxSupplierId.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBoxisbn.Text = item.SubItems[1].Text;
                comboBoxCategory.Text = item.SubItems[2].Text;
                textBoxtitle.Text = item.SubItems[3].Text;
                textBoxYearPublished.Text = item.SubItems[4].Text;
                textBoxQoh.Text = item.SubItems[5].Text;
                textBoxAuthorID.Text = item.SubItems[6].Text;
                textBoxFname.Text = item.SubItems[7].Text;
                textBoxLastname.Text = item.SubItems[8].Text;
                textBoxEmail.Text = item.SubItems[9].Text;
                textBoxSupplierId.Text = item.SubItems[10].Text;
                textBoxpublishedby.Text = item.SubItems[11].Text;
                textBoxUnitPrice.Text = item.SubItems[12].Text;


            }
            else
            {
                cleanTextBox();
            }
        }
        int index;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            index = listView1.SelectedIndices[0];
            textBoxisbn.Text = listView1.SelectedItems[0].SubItems[1].Text.Trim();
            comboBoxCategory.Text = listView1.SelectedItems[0].SubItems[2].Text.Trim();
            textBoxtitle.Text = listView1.SelectedItems[0].SubItems[3].Text.Trim();
            textBoxYearPublished.Text = listView1.SelectedItems[0].SubItems[4].Text.Trim();
            textBoxQoh.Text = listView1.SelectedItems[0].SubItems[5].Text.Trim();
            textBoxAuthorID.Text = listView1.SelectedItems[0].SubItems[6].Text.Trim();
            textBoxFname.Text = listView1.SelectedItems[0].SubItems[7].Text.Trim();
            textBoxLastname.Text = listView1.SelectedItems[0].SubItems[8].Text.Trim();
            textBoxEmail.Text = listView1.SelectedItems[0].SubItems[9].Text.Trim();
            textBoxSupplierId.Text = listView1.SelectedItems[0].SubItems[10].Text.Trim();
            textBoxpublishedby.Text = listView1.SelectedItems[0].SubItems[11].Text.Trim();
            textBoxUnitPrice.Text = listView1.SelectedItems[0].SubItems[12].Text.Trim();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    

}
