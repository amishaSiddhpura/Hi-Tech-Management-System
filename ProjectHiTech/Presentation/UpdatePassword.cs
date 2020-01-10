using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHiTech.DataAccess;
using ProjectHiTech.Business;


namespace ProjectHiTech.Presentation
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Update this Record", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MISmanager manager = new MISmanager();
                 manager.Username = textBoxUsername.Text;
                manager.Password = textBoxnewPass.Text;
                manager.Password = textBoxConfirmPAss.Text;
                if (manager.UpdatePassword(manager))
                {
                    MessageBox.Show("Password Updated.");


                }
                else
                {
                    MessageBox.Show("Password Is Not Updated.");
                }
            }
        }
    }
}
