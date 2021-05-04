using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personnel
{
    public partial class frmPrincipal_Directeur : Form
    {
        public frmPrincipal_Directeur()
        {
            InitializeComponent();
            pnlActive.Height = btnDashboard.Height;
            pnlActive.Top = btnDashboard.Top;
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
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnEmployes.Top;
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
    }
}
