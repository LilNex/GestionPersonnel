using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personnel.CustomControls
{
    public partial class UCEmployes : UserControl
    {
        public UCEmployes()
        {
            InitializeComponent();
        }

        private void btnListeEmployes_Click(object sender, EventArgs e)
        {
            ucListeEmployes1.BringToFront();
        }
    }
}
