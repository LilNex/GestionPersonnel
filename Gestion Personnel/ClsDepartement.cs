using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personnel
{
    class ClsDepartement
    {
        private string nom;
        private string num;
        private List<clsPoste> listePoste = new List<clsPoste>();
        public static List<ClsDepartement> ListeDepartement = new List<ClsDepartement>();

        public string Nom { get => nom; set => nom = value; }
        // CONDITION format : XXX000
        public string Num { get => num; set => num = value; }
        internal List<clsPoste> ListePoste { get => listePoste; set => listePoste = value; }

        public ClsDepartement(string nom,string num)
        {
            Nom = nom;
            Num = num;
        }
        public int rechercheNum(string num)
        {
            for (int i = 0; i < ListePoste.Count(); i++)
            {
                if(ListePoste[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Ajouter(clsPoste p)
        {
            if(rechercheNum(p.Num) != -1)
            {
                return false;
            }
            else
            {

                ListePoste.Add(p);
                return true;
            }
        }

    }
}
