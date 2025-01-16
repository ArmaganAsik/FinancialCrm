using FinancialCrm.Common;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinancialCrm
{
    public partial class FrmTransactions : Form
    {
        public FrmTransactions()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void GetTransactions()
        {
            var transactions = db.BankTransactions.Select(x => new
            {
                x.BankTransactionId,
                x.TransactionDescription,
                x.TransactionDate,
                x.TransactionType,
                x.TransactionAmount,
                x.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = transactions;
        }

        private void FrmTransactions_Load(object sender, EventArgs e)
        {
            GetTransactions();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResultHelper.LogOut(this);
        }
    }
}
