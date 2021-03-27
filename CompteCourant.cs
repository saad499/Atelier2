using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier22
{
    class CompteCourant : Compte
    {
        public MAD decouvert;

        public CompteCourant(MAD dec , Client c, MAD montant) : base (c, montant)
        {
            this.decouvert = dec;
        }

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Le découvert : ");
            decouvert.afficher();
        }

        public override bool debiter(MAD montant)
        {
            if(this.solde - montant > this.decouvert)
            {
                base.debiter(montant);
            }
        }

    }
}
