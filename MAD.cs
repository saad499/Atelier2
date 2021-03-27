using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier22
{
    class MAD
    {
        private double valeur;

        //Constructeur
        public MAD(double v)
        {
            this.valeur = v;
        }
        public void afficher()
        {
            Console.WriteLine("La somme est : " + this.valeur);
        }

        public static implicit operator double(MAD v)
        {
            throw new NotImplementedException();
        }

        public static MAD operator +(MAD m1, MAD m2)
        {
            MAD mm = new MAD(0);
            mm.valeur = m1.valeur + m2.valeur;
            return mm;
        }
        public static MAD operator -(MAD m1, MAD m2) => new MAD(m1.valeur - m2.valeur);

        public static bool operator >(MAD m1, MAD m2)
        {
            if (m1.valeur > m2.valeur) return true;
            else return false;
        }
        public static bool operator <(MAD m1, MAD m2)
        {
            if (m1.valeur < m2.valeur) return true;
            return false;
        }

        public static bool operator >=(MAD m1, MAD m2)
        {
            if (m1.valeur >= m2.valeur) return true;
            else return false;
        }
        public static bool operator <=(MAD m1, MAD m2)
        {
            if (m1.valeur <= m2.valeur) return true;
            else return false;
        }
    }
}
