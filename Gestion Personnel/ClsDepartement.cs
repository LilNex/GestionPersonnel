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
        private int num;
        public  static List<clsPoste> listePoste;

        public string Nom { get => nom; set => nom = value; }
        public int Num { get => num; set => num = value; }
        public ClsDepartement(string nom,int num)
        {
            Nom = nom;
            Num = num;
        }
        public int rechercheNum(int num)
        {
            for (int i = 0; i < listePoste.Count(); i++)
            {
                if(listePoste[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter(clsPoste p)
        {
            if(rechercheNum(p.Num) != -1)
            {
                return false;
            }
            else
            {

                listePoste.Add(p);
                return true;
            }
        }

    }
}
