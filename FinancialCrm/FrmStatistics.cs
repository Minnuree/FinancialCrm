using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Chart1 Kodları
            var spendingData = db.Spendings.Select(x => new
            {
                x.SpendingTitle,
                x.SpendingAmount
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Giderler");

            foreach(var item in spendingData)
            {
                series.Points.AddXY(item.SpendingTitle, item.SpendingAmount);
            }

            // Chart2 Kodları
            var bankProcesses = db.BankProcesses.Select(x => new
            {
                x.Description,
                x.Amount
            }).ToList();

            chart2.Series.Clear();
            var series2 = chart2.Series.Add("BH");

            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;

            foreach (var item in bankProcesses)
            {
                series2.Points.AddXY(item.Description, item.Amount);
            }

            // Chart3 Kodları
            
            var spendgroup = db.Spendings
              .GroupBy(x => x.Categories.CategoryName)
             .Select(y => new
    {
                 CategoryName = y.Key,
                 SpendingAmount = y.Sum(x => x.SpendingAmount)
    })
    .ToList();



            chart3.Series.Clear();
            var series3 = chart3.Series.Add("K");

            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            
            foreach (var item in spendgroup)
            {
                   series3.Points.AddXY(item.CategoryName, item.SpendingAmount);
                
                
            }

            // Chart4 Kodları

            var spendingMonthSum = db.BankProcesses
                .GroupBy(x => new { x.ProcessDate.Value.Year, x.ProcessDate.Value.Month })  // Yıla ve aya göre grupla
                .Select(y => new
                {
                    processYear = y.Key.Year,
                    processMonth = y.Key.Month,
                    Amount = y.Sum(x=>x.Amount)

                })
                .AsEnumerable() // **SQL'den sonucu aldıktan sonra işleme devam et**
                .Select(y => new
                {
                   y.processYear,
                   y.processMonth,
                    monthName = new DateTime(y.processYear, y.processMonth, 1).ToString("MMMM", new CultureInfo("tr-TR")), // Türkçe ay adı // **Bellekte işle**
                    y.Amount
                })
                .OrderBy(y => y.processYear).ThenBy(y => y.processMonth) // Kronolojik sıralama
                .ToList();




            /*  .OrderBy(y => y.processYear).ThenBy(y => y.processMonth) // Kronolojik sıralama
                 .ToList(); */


            

            
            chart4.Series.Clear();
            var series4 = chart4.Series.Add("Tutar");
            series4.ChartType = SeriesChartType.Pyramid;

            
            foreach (var item in spendingMonthSum)
            {

               series4.Points.AddXY(item.monthName, item.Amount);
            }


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

        private void btnSpending_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
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
