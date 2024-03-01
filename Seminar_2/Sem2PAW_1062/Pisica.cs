using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1062
{
    class Pisica: Animal
    {
        private string culoare;
        private char sex;
        private bool areStapan;

        public Pisica():base()
        {
            culoare = "maro";
            sex = 'F';
            areStapan = true;
        }

        public Pisica(int v, string n, float g, string c, char s, bool a):
            base(v,n,g)
        {
            culoare = c;
            sex = s;
            areStapan = a;
        }

        public string Culoare { get => culoare; set => culoare = value; }
        public char Sex { get => sex; set => sex = value; }
        public bool AreStapan { get => areStapan; set => areStapan = value; }

        public override string ToString()
        {
            return base.ToString()+" si culoarea "+culoare+
                " si sexul "+sex+" si are stapan "+areStapan;
        }
    }
}
