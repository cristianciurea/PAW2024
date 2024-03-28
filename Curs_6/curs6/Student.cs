using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs6
{
    class Student
    {
        private int cnp;
        private string nume;
        private char sex;
        private float medie;

        public Student(int c, string n, char s, float m)
        {
            cnp = c;
            nume = n;
            sex = s;
            medie = m;
        }

        public int Cnp { get => cnp; set => cnp = value; }
        public string Nume { get => nume; set => nume = value; }
        public char Sex { get => sex; set => sex = value; }
        public float Medie { get => medie; set => medie = value; }

        public override string ToString()
        {
            return "Studentul " + nume + " cu cnp " + cnp +
                " sexul " + sex + " are media " + medie;
        }
    }
}
