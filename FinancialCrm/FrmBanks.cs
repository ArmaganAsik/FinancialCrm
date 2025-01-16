using FinancialCrm.Common;
using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void GetBankBalances()
        {
            var banks = db.Banks.Select(x => new
            {
                x.BankId,
                x.BankTitle,
                x.BankBalance
            }).ToList();

            cmbBanks.DisplayMember = "BankTitle";
            cmbBanks.ValueMember = "BankId";
            cmbBanks.DataSource = banks;
            cmbBanks.SelectedIndex = -1;
            txtBalance.Text = "";

            lblBankTitle1.Text = banks[0].BankTitle;
            lblBankBalance1.Text = banks[0].BankBalance.ToString() + " ₺";
            lblBankTitle2.Text = banks[1].BankTitle;
            lblBankBalance2.Text = banks[1].BankBalance.ToString() + " ₺";
            lblBankTitle3.Text = banks[2].BankTitle;
            lblBankBalance3.Text = banks[2].BankBalance.ToString() + " ₺";
        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            #region BankBalances

            GetBankBalances();

            #endregion

            #region BankTransactions

            var bankTransaction1 = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).Take(1).FirstOrDefault();
            lblFirst.Text = bankTransaction1.TransactionDescription + " ; " + bankTransaction1.TransactionAmount + " ₺ ; " + bankTransaction1.TransactionDate;

            var bankTransaction2 = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).Take(2).Skip(1).FirstOrDefault();
            lblSecond.Text = bankTransaction2.TransactionDescription + " ; " + bankTransaction2.TransactionAmount + " ₺ ; " + bankTransaction2.TransactionDate;

            var bankTransaction3 = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).Take(3).Skip(2).FirstOrDefault();
            lblThird.Text = bankTransaction3.TransactionDescription + " ; " + bankTransaction3.TransactionAmount + " ₺ ; " + bankTransaction3.TransactionDate;

            var bankTransaction4 = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).Take(4).Skip(3).FirstOrDefault();
            lblFourth.Text = bankTransaction4.TransactionDescription + " ; " + bankTransaction4.TransactionAmount + " ₺ ; " + bankTransaction4.TransactionDate;

            var bankTransaction5 = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).Take(5).Skip(4).FirstOrDefault();
            lblFifth.Text = bankTransaction5.TransactionDescription + " ; " + bankTransaction5.TransactionAmount + " ₺ ; " + bankTransaction5.TransactionDate;

            #endregion
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResultHelper.LogOut(this);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.Show();
            Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            Close();
        }

        private void cmbBanks_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbBanks.SelectedValue);
            Banks bank = db.Banks.FirstOrDefault(x => x.BankId == id);
            if (bank != null) txtBalance.Text = bank.BankBalance.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbBanks.SelectedValue);
            Banks bank = db.Banks.FirstOrDefault(x => x.BankId == id);
            if (bank != null)
            {
                bank.BankBalance = Convert.ToDecimal(txtBalance.Text);
                db.SaveChanges();
                MessageBox.Show("Balance updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBankBalances();
            }   
        }
    }
}
