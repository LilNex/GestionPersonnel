﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personnel
{
    class clsPoste
    {
        private  string nom;
        private string num;
        private List<ClsEmploye> listeDesEmployé = new List<ClsEmploye>();


        public string Nom { get => nom; set => nom = value; }
        public string Num { get => num; set => num = value; }

        public clsPoste(string nom,string num)
        {
            this.nom = nom;
            this.num = num;
        }
        public int rechercheNum(int num)
        {
            for (int i = 0; i < listeDesEmployé.Count(); i++)
            {
                if (listeDesEmployé[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter(ClsEmploye p)
        {
            if (rechercheNum(p.Num) != -1)
            {
                return false;
            }
            else
            {

                listeDesEmployé.Add(p);
                return true;
            }
        }


    }
}
