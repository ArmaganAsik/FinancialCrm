using FinancialCrm.Common;
using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void GetBills()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmBills_Load(object sender, EventArgs e)
        {
            GetBills();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResultHelper.LogOut(this);
        }

        private void bntList_Click(object sender, EventArgs e)
        {
            GetBills();
            txtId.Text = txtTitle.Text = txtAmount.Text = txtPeriod.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtAmount.Text != "" && txtPeriod.Text != "")
            {
                Bills b = new Bills();
                b.BillTitle = txtTitle.Text;
                try
                {
                    b.BillAmount = Convert.ToDecimal(txtAmount.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter bill amount correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                b.BillPeriod = txtPeriod.Text;
                db.Bills.Add(b);
                db.SaveChanges();
                MessageBox.Show("Bill added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBills();
                txtTitle.Text = txtAmount.Text = txtPeriod.Text = "";
            }
            else MessageBox.Show("Please enter bill data correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPeriod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Bills bDelete = db.Bills.Find(id);
                db.Bills.Remove(bDelete);
                db.SaveChanges();
                MessageBox.Show("Bill deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetBills();
                txtId.Text = txtTitle.Text = txtAmount.Text = txtPeriod.Text = "";
            }
            else MessageBox.Show("Please firstly choose the bill to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (txtTitle.Text != "" && txtAmount.Text != "" && txtPeriod.Text != "")
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Bills bUpdate = db.Bills.Find(id);
                    bUpdate.BillTitle = txtTitle.Text;
                    try
                    {
                        bUpdate.BillAmount = Convert.ToDecimal(txtAmount.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please enter bill amount correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bUpdate.BillPeriod = txtPeriod.Text;
                    db.SaveChanges();
                    MessageBox.Show("Bill updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetBills();
                    txtId.Text = txtTitle.Text = txtAmount.Text = txtPeriod.Text = "";
                }
                else MessageBox.Show("Please enter bill data correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please firstly choose the bill to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            Close();
        }
    }
}
