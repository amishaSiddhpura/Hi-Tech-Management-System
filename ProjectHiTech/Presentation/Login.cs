using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectHiTech.Business;
using System.Windows.Forms;

namespace ProjectHiTech.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }
        public bool ValidateEmptyTextBox(int checkNumber)
        {
            switch (checkNumber)
            {
                case 1:
                    return !String.IsNullOrEmpty(textBoxUsername.Text) && !String.IsNullOrEmpty(textBoxPassword.Text);
                default:
                    return false;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ValidateEmptyTextBox(1))
            {
                Login loginForm = new Login();
                LoginUser login = new LoginUser();
                login.Username = textBoxUsername.Text;
                login.Password = textBoxPassword.Text;
                int role = login.CheckUserLogin(login);
                if(role != -1)
                {
                   switch(role)
                    {
                        case 1:
                            MessageBox.Show("Login Successful");
                            this.Hide();
                            MISManagerForm manager = new MISManagerForm();
                            manager.ShowDialog(); // Open MISmanager Form
                            this.Close();
                            
                            break;
                        case 2:
                            MessageBox.Show("Login Successful");
                            this.Hide();
                            SalesManagerForm managesale = new SalesManagerForm();
                            managesale.ShowDialog(); // Open SalesManager Form
                            this.Close();
                            break;
                        case 3:
                            MessageBox.Show("Login Successful");
                            this.Hide();
                            OrderClerksForm orderClerks = new OrderClerksForm();
                            orderClerks.ShowDialog(); // Open Orderclerks Form
                            this.Close();
                            break;
                        case 4:
                            MessageBox.Show("Login Successful");
                            this.Hide();
                            AccountantForm accountant = new AccountantForm();
                            accountant.ShowDialog(); // Open Accountant Form
                            this.Close();
                            break;
                        case 5:
                            MessageBox.Show("Login Successful");
                            this.Hide();
                            InventoryControllerForm inventoy = new InventoryControllerForm();
                            inventoy.ShowDialog(); // Open InventoryController Form
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Invalid Username & Password");
                            break;

                    }
                }else
                {
                    MessageBox.Show("Login Unsuccessfull");
                }
                   
            }
        }
     
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                buttonLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePassword pass= new UpdatePassword();
            pass.ShowDialog();
            this.Close();
        }
    }
}
