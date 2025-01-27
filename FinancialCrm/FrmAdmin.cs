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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var tuserName = txtUserName.Text;
            var tpassword = txtPassword.Text;
            var adminName = db.Users.Where(x => x.UserId == 1).Select(y=>y.UserName).FirstOrDefault();
            var password = db.Users.Where(x => x.UserId == 1).Select(y => y.Password).FirstOrDefault();
            if(tuserName == adminName && tpassword == password)
            {
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre");
            }
        }
    }
}
