using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Maimuta: Animal
    {
        private bool arePui;
        private string specie;

        public Maimuta():base()
        {
            arePui = true;
            specie = "caucaziana";
        }

        public Maimuta(int v, string n, float g, bool are, string s):
            base(v,n,g)
        {
            arePui = are;
            specie = s;
        }

        public bool ArePui { get => arePui; set => arePui = value; }
        public string Specie { get => specie; set => specie = value; }

        public override string ToString()
        {
            return base.ToString()+" si specia "+specie+
                " si are pui "+arePui;
        }
    }
}
