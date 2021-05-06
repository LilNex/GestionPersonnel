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
        private string télephone;
        private string email;       
        private string cin;
        private char situation_familiale;
        private string competence;
        private DateTime date_debut;
        private DateTime date_naissance;
        private char sex;
        private string adresse;
        private int salaire;
        private string rfid;


        public string Nom
        {
            get => nom; 
            set
            {
                if (value.All(char.IsLetter))
                {
                    nom = value;
                }
                else {
                    throw new Exception("le Prenom ne doit pas contenur des chiffres et des caracteres spécieux");
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
        public string Cin { get => cin; set => cin = value; }
    }
}