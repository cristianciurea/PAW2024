using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem8PAW_1062
{
    public class Student
    {
        public int nrMatricol;
        public string nume;
        public float medie;
        public int anStudiu;
        public string facultate;

        public Student(int nr, string n, float m, int an, string f)
        {
            nrMatricol = nr;
            nume = n;
            medie = m;
            anStudiu = an;
            facultate = f;
        }

        public override string ToString()
        {
            return "Studentul " + nume + " cu nr. matricol " + nrMatricol +
                " si media " + medie + " facultatea " + facultate +
                " este in anul " + anStudiu;
        }
    }
}
