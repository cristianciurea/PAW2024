using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Leu: Animal
    {
        private char sex;
        private int nrPui;

        public Leu():base()
        {
            sex = 'F';
            nrPui = 0;
        }

        public Leu(int v, string n, float g, char s, int np):
            base(v,n,g)
        {
            sex = s;
            nrPui = np;
        }

        public char Sex { get => sex; set => sex = value; }
        public int NrPui { get => nrPui; set => nrPui = value; }

        public override string ToString()
        {
            return base.ToString()+" si sexul "+sex+
                " si are "+nrPui+" pui";
        }
    }
}
