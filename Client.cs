using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier22
{
    class Client
    {
        //Les attributs
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> compte;

        //Constructeur
        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
            this.compte = new List<Compte>();
        }
        //L'aafichage
        public void afficher()
        {
            Console.WriteLine("Le nom est : " + this.nom);
            Console.WriteLine("Le prenom est : " + this.prenom);
            Console.WriteLine("L'adresse est : " + this.adresse);
        }
    }
}
