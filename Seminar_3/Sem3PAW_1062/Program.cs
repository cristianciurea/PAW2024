using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1062
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(100, 'M', 21, "Gigel",
                new int[] { 8, 9, 10 });
            Student s3 = (Student)s2.Clone();
            s3.Nume = "Dorel";
            s3 += 10;
            s3 = 7 + s3;
            s3[3] = 1;
            int[] note = { 5, 6, 7 };
            s1.Note = note;
            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);

            Console.WriteLine("Anul nasterii lui s2 este {0}", 
                s2.spuneAnNastere());
            Console.WriteLine("Media notelor lui s3 este {0}", 
                (float)s3);
        }
    }
}
