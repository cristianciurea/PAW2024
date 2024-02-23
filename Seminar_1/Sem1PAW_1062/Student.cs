using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1062
{
    class Student
    {
        public int varsta;
        private string nume;
        protected float medie;

        public string Nume { get => nume; set => nume = value; }

        public Student()
        {
            varsta = 0;
            this.nume = "Anonim";
            this.medie = 0.0f;
        }

        public Student(int v, string n, float m)
        {
            varsta = v;
            nume = n;
            medie = m;
        }

        public Student(Student s)
        {
            this.varsta = s.varsta;
            this.nume = s.nume;
            this.medie = s.medie;
        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} cu varsta {1} are media {2}",
                nume, varsta, medie);
        }

        public override string ToString()
        {
            return "Studentul "+nume+" cu varsta "+varsta+" are media "+medie;
        }

        /*public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }*/
    }
}
