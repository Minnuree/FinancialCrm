using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
            
            var spendingCategories = db.Spendings.Select(x => new
            {
                x.Categories.CategoryName,
                x.SpendingAmount
            }).ToList();



            var spendgroup = db.Spendings
              .GroupBy(p => p.Categories.CategoryName)
             .Select(g => new
    {
                 CategoryName = g.Key,
                 SpendingAmount = g.Sum(p => p.SpendingAmount)
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



        }
    }
}
