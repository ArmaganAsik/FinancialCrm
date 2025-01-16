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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        void GetCategories()
        {
            var categories = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();

            dataGridView1.DataSource = categories;
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetCategories();
            txtId.Text = txtName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                Categories c = new Categories { CategoryName = txtName.Text };
                db.Categories.Add(c);
                db.SaveChanges();
                MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCategories();
                txtId.Text = txtName.Text = "";
            }
            else MessageBox.Show("Please enter category name correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                db.Categories.Remove(db.Categories.Find(id));
                db.SaveChanges();
                MessageBox.Show("Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCategories();
                txtId.Text = txtName.Text = "";
            }
            else MessageBox.Show("Please firstly choose the category to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (txtName.Text != "")
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Categories cUpdate = db.Categories.Find(id);
                    cUpdate.CategoryName = txtName.Text;
                    db.SaveChanges();
                    MessageBox.Show("Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetCategories();
                    txtId.Text = txtName.Text = "";
                }
                else MessageBox.Show("Please enter category name correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please firstly choose the category to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
