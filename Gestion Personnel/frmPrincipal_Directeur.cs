using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personnel
{
    public partial class frmPrincipal_Directeur : Form
    {
        public CultureInfo cultureInfo = new CultureInfo("fr-FR");
        public frmPrincipal_Directeur()
        {
            InitializeComponent();
            setupForm();
        }
        public void setupForm()
        {
            timer.Start();
            pnlActive.Height = btnDashboard.Height;
            pnlActive.Top = btnDashboard.Top;
            ucDashboard1.BringToFront();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDashboard.Top;
            ucDashboard1.BringToFront();
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnEmployes.Top;
            ucEmployes.BringToFront();


        }

        private void btnGstPaie_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnGstPaie.Top;
        }

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDemandes.Top;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnX.Top;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ucDashboard1.DateNow = DateTime.Now.ToString("F", cultureInfo).ToUpper();
        }

        private void pnlEmployé_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
