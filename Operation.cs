using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier22
{
    class Operation
    {
        private static int cmp = 0;
        private int numero;
        private DateTime date;
        private MAD montant;
        private string libelle;

        public Operation(MAD mnt, string libelle)
        {
            this.numero = cmp;
            this.date = DateTime.Now;
            this.montant = mnt;
            while(this.libelle == "créditation" && this.libelle == "débit")
            {
                Console.WriteLine("Le libelle d'une opération doit etre soit débit soit créditation");
                this.libelle = Console.ReadLine();
            }
            this.libelle = libelle;
        }

        public void afficher()
        {
            Console.WriteLine(this.date + "| n ° " + this.numero + "||" + this.montant + " MAD");
        }
    }
}
