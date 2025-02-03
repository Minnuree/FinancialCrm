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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var processList = db.Banks.ToList();
            cmBanks.DisplayMember = "BankTitle";
            cmBanks.ValueMember = "BankId";
            cmBanks.DataSource = processList;
        }

        private void btnProcessList_Click(object sender, EventArgs e)
        {
            var processList = db.BankProcesses.ToList();
            dataGridView1.DataSource = processList;
        }

        private void btnCreateProcess_Click(object sender, EventArgs e)
        {
            string description = txtDecsription.Text;
            string processType = txtProcessType.Text;
            int processAmount = int.Parse(txtProcessAmount.Text);
            var processDate =DateTime.Parse(ProcessDate.Text);
            int bankId = int.Parse(cmBanks.SelectedValue.ToString());

            BankProcesses bankProcesses = new BankProcesses();

            bankProcesses.Description = description;
            bankProcesses.ProcessType = processType;
            bankProcesses.ProcessDate = processDate;
            bankProcesses.Amount = processAmount;
            bankProcesses.BankId = bankId;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();

            MessageBox.Show("Banka Hareketleri Ekleme Başarılı");
            txtDecsription.Clear();
            txtProcessType.Clear();
            txtProcessAmount.Clear();
            var processList = db.BankProcesses.ToList();
            dataGridView1.DataSource = processList;
        }

        private void btnUpdateProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessesId.Text);

            var values = db.BankProcesses.Find(id);

            values.Description = txtDecsription.Text;
            values.ProcessType = txtProcessType.Text;
            values.Amount = int.Parse(txtProcessAmount.Text);
            values.ProcessDate = DateTime.Parse(ProcessDate.Text);
            values.BankId = int.Parse(cmBanks.SelectedValue.ToString());

            db.SaveChanges();

            MessageBox.Show("Banka Hareketleri Güncelleme Başarılı");
            txtProcessesId.Clear();
            txtDecsription.Clear();
            txtProcessType.Clear();
            txtProcessAmount.Clear();
            var processList = db.BankProcesses.ToList();
            dataGridView1.DataSource = processList;
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessesId.Text);

            var deleteValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(deleteValue);
            db.SaveChanges();

            MessageBox.Show("Banka Hareketini Silme Başarılı");
            txtProcessesId.Clear();
            txtDecsription.Clear();
            txtProcessType.Clear();
            txtProcessAmount.Clear();
            var processList = db.BankProcesses.ToList();
            dataGridView1.DataSource = processList;

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();

        }

        private void btnSpending_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }
    }
}
