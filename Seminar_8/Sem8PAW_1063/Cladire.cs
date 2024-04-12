using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem8PAW_1063
{
    public class Cladire
    {
        public int codCladire;
        public int nrEtaje;
        public string adresa;
        public float suprafata;

        public Cladire(int cod, int nr, string a, float s)
        {
            codCladire = cod;
            nrEtaje = nr;
            adresa = a;
            suprafata = s;
        }

        public override string ToString()
        {
            return "Cladirea cu codul  " + codCladire + " si adresa " +
                adresa + " are " + nrEtaje + " etaje si suprafata " + suprafata;
        }
    }
}

