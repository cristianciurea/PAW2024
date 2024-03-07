using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1063
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(100, 'M', "Gigel", 21, 
                new int[] { 8, 9, 10 });
            Student s3 = (Student)s2.Clone();
            s3.Nume = "Dorel";
            s3 += 10;
            s3 = 7 + s3;
            s3[2] = 1;
            Console.WriteLine("Anul nasterii lui s3 este {0}", 
                s3.spuneAnNastere());
            Console.WriteLine("Media notelor lui s3 este {0}",
                (float)s3);

            int[] note = { 5, 6, 7 };
            s1.Note = note;

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);
        }
    }
}
