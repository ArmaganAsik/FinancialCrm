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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblTotalBalance.Text = db.Banks.Sum(x => x.BankBalance).ToString() + " ₺";

            lblTransactionTitle.Text = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).FirstOrDefault().TransactionDescription.ToString();
            lblTransactionAmount.Text = db.BankTransactions.OrderByDescending(x => x.BankTransactionId).FirstOrDefault().TransactionAmount.ToString() + " ₺";

            #region chartBank

            var banks = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            foreach (var item in banks)
            {
                chartBank.Series["Banks"].Points.AddXY(item.BankTitle, item.BankBalance);
            }

            #endregion

            #region chartBill

            var bills = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            foreach (var item in bills)
            {
                chartBill.Series["Bills"].Points.AddXY(item.BillTitle, item.BillAmount);
            }

            #endregion

        }

        int count;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            int i = count % 4;

            switch (i)
            {
                case (1):
                    lblBillTitle.Text = "Electricity";
                    lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Electricity").FirstOrDefault().BillAmount.ToString() + " ₺";
                    break;
                case (2):
                    lblBillTitle.Text = "Natural Gas";
                    lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Natural Gas").FirstOrDefault().BillAmount.ToString() + " ₺";
                    break;
                case (3):
                    lblBillTitle.Text = "Water";
                    lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Water").FirstOrDefault().BillAmount.ToString() + " ₺";
                    break;
                case (0):
                    lblBillTitle.Text = "Internet";
                    lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Internet").FirstOrDefault().BillAmount.ToString() + " ₺";
                    break;
                default:
                    break;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            Close();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.Show();
            Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            Close();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FrmTransactions frm = new FrmTransactions();
            frm.Show();
            Close();
        }
    }
}
