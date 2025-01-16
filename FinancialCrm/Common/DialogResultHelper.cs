using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm.Common
{
    public static class DialogResultHelper
    {
        public static void LogOut(Form currentForm)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?\n(Click No to back to dashboard)", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;

                case DialogResult.No:
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show();
                    currentForm.Close();
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
