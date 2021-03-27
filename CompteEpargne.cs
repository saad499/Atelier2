using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier22
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;

        
        public CompteEpargne(double TI, Client t, MAD m) :base( t, m)
        {
            if(this.TauxInteret>=0 && this.TauxInteret <= 100)
            {
                this.TauxInteret = TI;
            }
        }

        public double calculInteret(double ci)
        {
            ci = (this.solde * this.TauxInteret) / 100;
            return ci;
        }

    }
}
