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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmCategories_Load(object sender, EventArgs e)
        {

        }
        private void btnListCategory_Click(object sender, EventArgs e)
        {
            var categoryList = db.Categories.ToList();
            dataGridView1.DataSource = categoryList;

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            // textboxlardan verileri al 
            // tablo türünden nesne oluştur
            // her ilgili bilgiyi ilgili sütüna at
            // Veritabanına ekle ve kaydet

            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();

            categories.CategoryName = categoryName;
            db.Categories.Add(categories);
            db.SaveChanges();

            MessageBox.Show("Kategori Ekleme Başarılı");

            txtCategoryName.Clear();

            var categoryList = db.Categories.ToList();
            dataGridView1.DataSource = categoryList;

        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            // texboxdan idyi al
            // idye göre aradığım veriyi bul
            // veriyi sil ve kaydet

            int categoryid = int.Parse(txtCategoryId.Text);
            var deleteId = db.Categories.Find(categoryid);
            db.Categories.Remove(deleteId);
            db.SaveChanges();

            MessageBox.Show("Kategori Silme Başarılı");

            txtCategoryId.Clear();
            txtCategoryName.Clear();

            var categoryList = db.Categories.ToList();
            dataGridView1.DataSource = categoryList;

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            // idyi al ve ismi al 
            // nesne oluştur
            // Güncellenecek veri bul 

            int updateId = int.Parse(txtCategoryId.Text);
            string categoryName = txtCategoryName.Text;


            var values = db.Categories.Find(updateId);

            values.CategoryName = categoryName;
            db.SaveChanges();

            MessageBox.Show("Kategori Güncelleme Başarılı");

            txtCategoryId.Clear();
            txtCategoryName.Clear();

            var categoryList = db.Categories.ToList();
            dataGridView1.DataSource = categoryList;

        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSpending_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
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

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }
    }
}
