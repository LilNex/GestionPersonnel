using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personnel
{
    class ClsEmploye
    {
        private string nom;
        private String prenom;
        private int num;

        public string Nom
        {
            get => nom; set
            {
                bool okey = false;
                foreach (char c in value)
                {
                    if (char.IsLetter(c) == false)
                    {
                        okey = false;
                    }
                }
                if (okey == false)
                {
                    throw new Exception("le Nom ne doit pas contenur des chiffres et des caracteres spécieux");
                }
                else
                {
                    nom = value;
                }
            }
        }
        public string Prenom
        {
            get => prenom; set
            {
                bool okey = false;
                foreach (char c in value)
                {
                    if (char.IsLetter(c) == false)
                    {
                        okey = false;
                    }
                }
                if (okey == false)
                {
                    throw new Exception("le Prenom ne doit pas contenur des chiffres et des caracteres spécieux");
                }
                else
                {
                    prenom = value;
                }
            }
        }

        public int Num { get => num; set => num = value; }
    }
}