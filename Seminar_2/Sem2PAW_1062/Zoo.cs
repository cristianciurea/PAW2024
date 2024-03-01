using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1062
{
    class Zoo: ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale;

        public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }

        public string Denumire { get => denumire; set => denumire = value; }
        internal List<Animal> ListaAnimale { get => listaAnimale; set => listaAnimale = value; }

        public object Clone()
        {
            Zoo clona =(Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                listaNoua.Add((Animal)a.Clone());
            clona.listaAnimale = listaNoua;
            return clona;
        }

        public override string ToString()
        {
            string rezultat = "Zoo " + denumire + " are urmatoarele animale: " +
                Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString() + Environment.NewLine;
            return rezultat;
        }

        public static explicit operator float(Zoo z)
        {
            float total = 0.0f;
            foreach (Animal a in z.ListaAnimale)
                total += a.Greutate;
            return total / z.listaAnimale.Count;
        }

        public Animal this[int index]
        {
            get
            {
                if (listaAnimale != null && index >= 0 &&
                    index < listaAnimale.Count)
                    return listaAnimale[index];
                else
                    return null;
            }
        }
    }
}
