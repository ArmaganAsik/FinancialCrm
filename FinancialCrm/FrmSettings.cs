using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string currPass = txtCurrent.Text;
            string newPass = txtNew.Text;
            string userName = txtUsername.Text;

            Admins admin = db.Admins.FirstOrDefault(x => x.Username == userName);

            if (admin == null)
            {
                MessageBox.Show("User not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isPasswordChanged = newPass != currPass && !string.IsNullOrWhiteSpace(newPass);

            if (admin.Password == currPass)
            {
                if (isPasswordChanged)
                {
                    admin.Password = newPass;
                    MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                    txtCurrent.Text = txtNew.Text = "";
                }
                else MessageBox.Show("New password cannot be empty or the same as current password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please check your current password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCurrentSee_Click(object sender, EventArgs e)
        {
            txtCurrent.UseSystemPasswordChar = !txtCurrent.UseSystemPasswordChar;
        }

        private void btnNewSee_Click(object sender, EventArgs e)
        {
            txtNew.UseSystemPasswordChar = !txtNew.UseSystemPasswordChar;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
