using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1062
{
    class Urs: Animal
    {
        private bool hiberneaza;
        private string rasa;

        public Urs():base()
        {
            hiberneaza = true;
            rasa = "carpatin";
        }

        public Urs(int v, string n, float g, bool h, string r):
            base(v,n,g)
        {
            hiberneaza = h;
            rasa = r;
        }

        public override string ToString()
        {
            return base.ToString()+" si rasa "+rasa+
                " si hiberneaza "+hiberneaza;
        }
    }
}
