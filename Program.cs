using System;

namespace Atelier22
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client("Kammous", "Saad", "Bouskoura");
            Client cl2 = new Client("Benchakroun", "youssef", "oranger");
            Compte cpt1 = new Compte(cl,new MAD(15000));
            Compte cpt2 = new Compte(cl2, new MAD(10000));
            cpt1.afficher();

            cpt1.crediter(new MAD(9000));
            cpt1.afficher();
            cpt1.verser(new MAD(6000),cpt2 );
            cpt2.debiter(new MAD(100));
            cpt2.afficher();
            cpt2.afficher();
            Operation Op = new Operation(new MAD(1500), "débit");
            Op.afficher();
            cpt1.afficher();
            cpt2.afficher();
            Console.ReadKey();
        }
    }
}
