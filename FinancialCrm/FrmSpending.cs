using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            var categoryList = db.Categories.ToList();
            
            cmCategory.DisplayMember = "CategoryName";
            cmCategory.ValueMember = "CategoryId";
            cmCategory.DataSource = categoryList;

        }

        private void btnLSpendingList_Click(object sender, EventArgs e)
        {
            var spendingList = db.Spendings.ToList();
            dataGridView1.DataSource = spendingList;

        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            string spendingTitle = txtSpendingTitle.Text;
            decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
            var spendingDate = DateTime.Parse(SpendingDate.Text);
            int categoryId = int.Parse(cmCategory.SelectedValue.ToString());

            Spendings spendings = new Spendings();

            spendings.SpendingTitle = spendingTitle;
            spendings.SpendingAmount = spendingAmount;
            spendings.SpendingDate = spendingDate;
            spendings.CategoryId = categoryId;

            db.Spendings.Add(spendings);
            db.SaveChanges();

            MessageBox.Show("Gider Ekleme Başarılı");

            var spendingList = db.Spendings.ToList();
            dataGridView1.DataSource = spendingList;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int spendingId = int.Parse(txtSpendingId.Text);
            string spendingTitle = txtSpendingTitle.Text;
            decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
            var spendingDate = DateTime.Parse(SpendingDate.Text);
            int categoryId = int.Parse(cmCategory.SelectedValue.ToString());

            var updateSpending = db.Spendings.Find(spendingId);
            updateSpending.SpendingTitle = spendingTitle;
            updateSpending.SpendingAmount = spendingAmount;
            updateSpending.SpendingDate = spendingDate;
            updateSpending.CategoryId = categoryId;
            db.SaveChanges();

            MessageBox.Show("Gider Güncelleme Başarılı");

            txtSpendingId.Clear();
            txtSpendingTitle.Clear();
            txtSpendingAmount.Clear();

            var spendingList = db.Spendings.ToList();
            dataGridView1.DataSource = spendingList;
        }

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int deleteId =int.Parse(txtSpendingId.Text);
            var deletedSpending = db.Spendings.Find(deleteId);

            db.Spendings.Remove(deletedSpending);
            db.SaveChanges();

            MessageBox.Show("Gider Silme Başarılı");

            var spendingList = db.Spendings.ToList();
            dataGridView1.DataSource = spendingList;

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
            
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }
    }
}
