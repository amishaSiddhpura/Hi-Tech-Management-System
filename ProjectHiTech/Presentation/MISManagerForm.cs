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
using ProjectHiTech.DataAccess;

namespace ProjectHiTech.Presentation
{
    public partial class MISManagerForm : Form
    {
        public MISManagerForm()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            MISmanager manager = new MISmanager();
            dataGridView1.DataSource = manager.ReadUserData();
            ClearTextBox();
        }
        public bool CheckISNullOREmpty(int checkNumber)
        {
            switch (checkNumber)
            {
                case 1:
                    return !String.IsNullOrEmpty(textBoxFirstname.Text) &&
                        !String.IsNullOrEmpty(textBoxLastname.Text) &&
                        !String.IsNullOrEmpty(textBoxUsername.Text) &&
                        !String.IsNullOrEmpty(textBoxPassword.Text) &&
                        !String.IsNullOrEmpty(textBoxPositionId.Text);
                case 2:
                    return !String.IsNullOrEmpty(textBoxSearch.Text);
                case 3:
                    return !String.IsNullOrEmpty(comboBoxSearch.Text);

                default:
                    //! Return false in default case 
                    return false;
            }
        }
        public void ClearTextBox()
        {
            textBoxFirstname.Clear();
            textBoxLastname.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxPositionId.Clear();
        }
        private void MISManager_Load(object sender, EventArgs e)
        {
            MISmanager manager = new MISmanager();
            dataGridView1.DataSource = manager.ReadUserData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                MISmanager manager = new MISmanager();
                manager.Firstname = textBoxFirstname.Text;
                manager.Lastname = textBoxLastname.Text;
                manager.Username = textBoxUsername.Text;
                manager.Password = textBoxPassword.Text;
                manager.Position = Convert.ToInt32(textBoxPositionId.Text);
                if (manager.SaveRecored(manager))  //! TRUE
                {
                    MessageBox.Show("Recored Inserted..");

                }
                else
                {
                    MessageBox.Show("Recored Is Not Inserted..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshData();
                this.ClearTextBox();

            }
            else
            {
                MessageBox.Show("Please Enter Values. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                if (MessageBox.Show("Do You Want to Update this Record", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MISmanager manager = new MISmanager();
                    manager.UserID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    manager.Firstname = textBoxFirstname.Text;
                    manager.Lastname = textBoxLastname.Text;
                    manager.Username = textBoxUsername.Text;
                    manager.Password = textBoxPassword.Text;
                    manager.Position = Convert.ToInt32(textBoxPositionId.Text);

                    if (manager.UpdateRecord(manager))
                    {
                        MessageBox.Show("Record Updated.");


                    }
                    else
                    {
                        MessageBox.Show("Record Is Not Updated.");
                    }
                }
                RefreshData();
                this.ClearTextBox();
            }

            else
            {
                MessageBox.Show("Please select a row");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                MISmanager manager = new MISmanager();
                manager.UserID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                textBoxFirstname.Text = row.Cells["Firstname"].Value.ToString();
                textBoxLastname.Text = row.Cells["Lastname"].Value.ToString();
                textBoxUsername.Text = row.Cells["Username"].Value.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value.ToString();
                textBoxPositionId.Text = row.Cells["PositionId"].Value.ToString();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckISNullOREmpty(1))
            {
                if (MessageBox.Show("Do You Want to Delete this Record", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MISmanager manager = new MISmanager();
                    manager.UserID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    if (manager.DeleteRecord(manager))
                    {
                        MessageBox.Show("Record is Deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Record can not be deleted.");
                    }
                    RefreshData();
                    this.ClearTextBox();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Row.");
            }
        }

        public void SearchRecoredAllInOne(MISmanager manager, int index)
        {
            DataTable dataTable = manager.SearchRecord(manager, index);
            if (dataTable.Rows.Count != 0)
            {
                dataGridView2.DataSource = dataTable;
            }
            else
            {
                dataGridView2.DataSource = null;
                MessageBox.Show("Record not Found.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            this.ClearTextBox();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
           if(comboBoxSearch.SelectedIndex == 0)
            {
                int userID = Convert.ToInt32(textBoxSearch.Text.Trim());
                if(userID != null)
                {
                    if (CheckISNullOREmpty(2))
                    {
                        MISmanager manager = new MISmanager();
                        manager.UserID = Convert.ToInt32(textBoxSearch.Text);
                        this.SearchRecoredAllInOne(manager, 1);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the UserID ");
                    }
                }

            }else if(comboBoxSearch.SelectedIndex == 1)
            {
                string firstname = textBoxSearch.Text.Trim();
                if (firstname != null)
                {
                    if (CheckISNullOREmpty(2))
                    {
                        MISmanager manager = new MISmanager();
                        manager.Firstname =textBoxSearch.Text;
                        this.SearchRecoredAllInOne(manager, 2);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Firstname.. ");
                    }
                }
            }
            else
            {
                string username = textBoxSearch.Text.Trim();
                if (username != null)
                {
                    if (CheckISNullOREmpty(2))
                    {
                        MISmanager manager = new MISmanager();
                        manager.Username = textBoxSearch.Text;
                        this.SearchRecoredAllInOne(manager, 3);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Username.. ");
                    }
                }
            }

        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                buttonSearch_Click(sender, e);
            }
        }
    }
    
}
