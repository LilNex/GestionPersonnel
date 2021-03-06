using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personnel.CustomControls
{
    public partial class UCDepartements : UserControl
    {
        private List<ClsDepartement> listDeparts = new List<ClsDepartement>();

        private List<clsPoste> tempPostes = new List<clsPoste>();

        internal List<ClsDepartement> ListDeparts { get => listDeparts; set => listDeparts = value; }

        public UCDepartements()
        {
            InitializeComponent();
        }

        public void loadForm()
        {
            tempPostes.Clear();
            Functions.clearForm(ucListeDepartement);
            ucListeDepartement.dgvListeEmploye.DataSource = ClsDepartement.ListeDepartement;

        }
        private void UCDepartements_Load(object sender, EventArgs e)
        {
            loadForm();
            ucListeDepartement.BringToFront();
        }

        private void btnListeDeps_Click(object sender, EventArgs e)
        {
            Functions.clearForm(ucListeDepartement);
            ucListeDepartement.loadForm();
            ucListeDepartement.BringToFront();
        }

        private void btnAjouterDeps_Click(object sender, EventArgs e)
        {
            Functions.clearForm(ucAjoutDepartement);
            ucAjoutDepartement.BringToFront();
        }

        private void btnListePostes_Click(object sender, EventArgs e)
        {
            Functions.clearForm(ucListePoste);
            ucListePoste.BringToFront();
        }

        private void ucAjoutDepartement_Load(object sender, EventArgs e)
        {
            ucListeDepartement.dgvListeEmploye.DataSource = ClsDepartement.ListeDepartement;
        }
    }
}
