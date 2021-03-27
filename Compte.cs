using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier22
{
    class Compte
    {
        private readonly int numCompte;
        protected static int cpt;
        public readonly Client titulaire;
        protected MAD solde;
        private static MAD plafond;
        private List<Operation> operation;
        private DateTime date_creation = DateTime.Now;

        static Compte()
        {
            cpt = 0;
            plafond = new MAD(40000);
        }

        public Compte(Client t,MAD m)
        {
            cpt++;
            this.numCompte = cpt;
            this.titulaire = t;
            this.solde = m;
            this.operation = new List<Operation>();
        }

        public virtual void afficher()
        {
            Console.WriteLine("Numero de compte : " + this.numCompte);
            Console.WriteLine("Les informations du titulaire : ");
            this.titulaire.afficher();
            Console.WriteLine("Le solde : ");
            this.solde.afficher();
            Console.WriteLine("Le plafond : ");
            plafond.afficher();
        }
        public bool crediter(MAD somme)
        {
            MAD mm = new MAD(0);
            if (somme > mm)
            {
                this.solde += somme;
                return true;
            }
            else return false;
        }
        public virtual bool debiter(MAD somme)
        {
            MAD mm = new MAD(0);
            if (this.solde >= somme)
            {
                if (somme > mm)
                {
                    if (plafond >= somme)
                    {
                        this.solde -= somme;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool verser(MAD somme, Compte c)
        {
            if (this.debiter(somme))
            {
                c.crediter(somme);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
