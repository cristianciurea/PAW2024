using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Animal: ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private float greutate;

        public Animal()
        {
            this.varsta = 0;
            this.nume = "Anonim";
            this.greutate = 0.0f;
        }

        public Animal(int v, string n, float g)
        {
            this.varsta = v;
            this.nume = n;
            this.greutate = g;
        }

        public Animal(Animal a)
        {
            this.varsta = a.varsta;
            this.nume = a.nume;
            this.greutate = a.greutate;
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public float Greutate
        {
            get { return greutate; }
            set { if (value > 0) greutate = value; }
        }

        public override string ToString()
        {
            return "Animalul " + nume + " cu varsta " + varsta +
                " are greutatea " + greutate;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Animal a = (Animal)obj;
            if (this.greutate < a.greutate)
                return -1;
            else
                if (this.greutate > a.greutate)
                return 1;
            else
                return string.Compare(this.nume, a.nume);
        }

        public static Animal operator+(Animal a, int v)
        {
            a.varsta += v;
            return a;
        }

        public static Animal operator+(int v, Animal a)
        {
            return a + v;
        }
    }
}

