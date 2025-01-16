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

namespace FinancialCrm
{
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void GetExpenses()
        {
            var expenses = db.Expenses.Select(x => new
            {
                x.ExpenseId,
                x.ExpenseTitle,
                x.ExpenseAmount,
                x.ExpenseDate,
                x.Categories.CategoryName,
            }).ToList();

            dataGridView1.DataSource = expenses;
        }

        void GetExpensesByDate(DateTime first, DateTime last, string categoryName)
        {
            var expenses = db.Expenses.Where(x => x.ExpenseDate > first && x.ExpenseDate < last && (categoryName == "" || x.Categories.CategoryName == categoryName)).Select(x => new
            {
                x.ExpenseId,
                x.ExpenseTitle,
                x.ExpenseAmount,
                x.ExpenseDate,
                x.Categories.CategoryName,
            }).ToList();

            dataGridView1.DataSource = expenses;
        }

        decimal GetAmounts()
        {
            decimal amount = Convert.ToDecimal(db.Expenses.Sum(x=>x.ExpenseAmount));
            return amount;
        }

        decimal GetAmountsByDate(DateTime first, DateTime last, string categoryName)
        {
            decimal amount = Convert.ToDecimal(db.Expenses.Where(x => x.ExpenseDate > first && x.ExpenseDate < last && (categoryName == "" || x.Categories.CategoryName == categoryName)).Sum(x=>x.ExpenseAmount));
            return amount;
        }

        void GetCategories()
        {
            List<Categories> categories = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = -1;
        }

        void GetCategoriesForFilter()
        {
            List<Categories> categories = db.Categories.ToList();
            cmbCategoryFilter.DisplayMember = "CategoryName";
            cmbCategoryFilter.ValueMember = "CategoryId";
            cmbCategoryFilter.DataSource = categories;
            cmbCategoryFilter.SelectedIndex = -1;
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            GetExpenses();

            GetCategories();

            GetCategoriesForFilter();

            lblTotal.Text = GetAmounts().ToString() + " ₺";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtAmount.Text != "" && cmbCategory.Text != "")
            {
                Expenses expense = new Expenses();
                expense.ExpenseTitle = txtTitle.Text;
                try
                {
                    expense.ExpenseAmount = Convert.ToDecimal(txtAmount.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter expense amount correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                expense.ExpenseDate = dtpDate.Value;
                expense.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                db.Expenses.Add(expense);
                db.SaveChanges();
                MessageBox.Show("Expense added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = txtTitle.Text = txtAmount.Text = "";
                cmbCategory.SelectedIndex = -1;
                dtpDate.Value = DateTime.Today;
                GetExpenses();
            }
            else MessageBox.Show("Please enter expense data correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            cmbCategory.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (txtTitle.Text != "" && txtAmount.Text != "" && cmbCategory.Text != "")
                {
                    Expenses eUpdate = db.Expenses.Find(Convert.ToInt32(txtId.Text));
                    eUpdate.ExpenseTitle = txtTitle.Text;
                    try
                    {
                        eUpdate.ExpenseAmount = Convert.ToDecimal(txtAmount.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please enter expense amount correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    eUpdate.ExpenseDate = dtpDate.Value;
                    eUpdate.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                    db.SaveChanges();
                    MessageBox.Show("Expense updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = txtTitle.Text = txtAmount.Text = "";
                    cmbCategory.SelectedIndex = -1;
                    dtpDate.Value = DateTime.Today;
                    GetExpenses();
                }
                else MessageBox.Show("Please enter expense data correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please firstly choose the expense to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Expenses eDelete = db.Expenses.Find(Convert.ToInt32(txtId.Text));
                db.Expenses.Remove(eDelete);
                db.SaveChanges();
                MessageBox.Show("Expense deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = txtTitle.Text = txtAmount.Text = "";
                cmbCategory.SelectedIndex = -1;
                dtpDate.Value = DateTime.Today;
                GetExpenses();
            }
            else MessageBox.Show("Please firstly choose the expense to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string categoryName = cmbCategoryFilter.Text;
            GetExpensesByDate(dtpFirst.Value, dtpLast.Value, categoryName);
            lblFilteredTotal.Text = GetAmountsByDate(dtpFirst.Value, dtpLast.Value, categoryName).ToString() + " ₺";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetExpenses();
            lblTotal.Text = GetAmounts().ToString() + " ₺";
            lblFilteredTotal.Text = "0,00 ₺";
            dtpFirst.Value = dtpLast.Value = DateTime.Today;
            cmbCategoryFilter.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = txtTitle.Text = txtAmount.Text = "";
            dtpDate.Value = DateTime.Today;
            cmbCategory.SelectedIndex = -1;
        }
    }
}
