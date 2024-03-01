using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1062
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Azorel", 7.5f);
            Animal a3 = new Animal(a2);
            a3.Nume = "Grivei";
            a3.Greutate = 5.5f;
            Animal a4 = (Animal)a3.Clone();
            a4.Nume = "Pipo";
            a4.Greutate = 8.5f;

            List<Animal> listaAnimale = new List<Animal>();
            listaAnimale.Add(a1);
            listaAnimale.Add(a2);
            listaAnimale.Add(a3);
            listaAnimale.Add(a4);
            listaAnimale.Sort();
            foreach (Animal a in listaAnimale)
                Console.WriteLine(a);
            for (int i = 0; i < listaAnimale.Count; i++)
                Console.WriteLine(listaAnimale[i]);

            Pisica p1 = new Pisica(7, "Samira", 4.5f, "alb", 'F', true);
            Urs u1 = new Urs(12, "Balloo", 200, true, "grizly");

            a1 = a1 + 5;
            a2 = 5 + a2;
            a3 += 5;

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(a4);
            z1.ListaAnimale.Add(p1);
            z1.ListaAnimale.Add(u1);
            z1.ListaAnimale.Sort();

            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            Console.WriteLine("Greutate medie animale din z1 = {0}", (float)z1);
            Console.WriteLine("Animalul de pe pozitia 2 din z1 este {0}", z1[1]);
        }
    }
}
