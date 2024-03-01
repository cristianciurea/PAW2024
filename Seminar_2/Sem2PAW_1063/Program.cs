using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Azorel", 9.5f);
            Animal a3 = new Animal(a2);
            a3.Greutate = 7;
            a3.Nume = "Grivei";
            Animal a4 = (Animal)a2.Clone();
            a4.Greutate = 9;
            a4.Nume = "Rex";

            a2 = a2 + 10;
            a3 = 10 + a3;
            a4 += 10;

            Leu l1 = new Leu(15, "Simba", 120, 'M', 1);
            Maimuta m1 = new Maimuta(3, "Glenda", 12, true, "cimpanzeu");

            Animal[] vectAnimale = { a1, a2, a3, a4, l1, m1 };
            for (int i = 0; i < vectAnimale.Length; i++)
                Console.WriteLine(vectAnimale[i]);

            Zoo z1 = new Zoo();
            for (int i = 0; i < vectAnimale.Length; i++)
                z1.ListaAnimale.Add(vectAnimale[i]);
            z1.ListaAnimale.Sort();

            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            Console.WriteLine("Greutatea media din z2 este {0}", (float)z2);
            Console.WriteLine("Animalul de pe pozitia 2 din z2 este {0}", z2[1]);
        }
    }
}
