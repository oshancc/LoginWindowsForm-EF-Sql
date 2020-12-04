using LoginWindowsForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWindowsForm.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtUserName.Text = txtPassword.Text = "";
            txtUserName.Focus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Service.LoginUser(txtUserName.Text, txtPassword.Text))
            {
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials..!");
                Clear();
            }
        }
    }
}
