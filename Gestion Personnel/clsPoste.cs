using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personnel
{
    class clsPoste
    {
        private  string nom;
        private int num;
        public static List<ClsEmploye> listeDesEmployé;

        public string Nom { get => nom; set => nom = value; }
        public int Num { get => num; set => num = value; }

        public clsPoste(string nom,int num)
        {
            this.nom = nom;
            this.num = num;
        }
       
       
    }
}
