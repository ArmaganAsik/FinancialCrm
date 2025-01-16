using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Admins admin = db.Admins.Where(x => x.Username == username).FirstOrDefault();

            if (admin != null && password != "" && admin.Password == password)
            {
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                Hide();
            }
            else MessageBox.Show("Please check your username and password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}
