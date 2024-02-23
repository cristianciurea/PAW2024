using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1063
{
    class Program
    {
        static void Main(string[] args)
        {
            Array

            /*Console.WriteLine("Introduceti numele: ");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti varsta: ");
            int varsta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numele este {0} si varsta {1}", nume, varsta);*/

            int[] v1 = new int[4] { 1, 2, 3, 4 };
            int[] v2 = v1; //shallow copy
            v1[1] = 100;
            for (int i = 0; i < v2.Length; i++)
                Console.Write("{0} ", v2[i]);

            //deep copy var 1
            int[] v3 = new int[v1.Length];
            for (int i = 0; i < v1.Length; i++)
                v3[i] = v1[i];
            v1[2] = 200;
            Console.WriteLine();
            for (int i = 0; i < v3.Length; i++)
                Console.Write("{0} ", v3[i]);

            //deep copy var 2
            int[] v4 = (int[])v1.Clone();
            v1[3] = 300;
            Console.WriteLine();
            for (int i = 0; i < v4.Length; i++)
                Console.Write("{0} ", v4[i]);

            //matrice var 1
            Console.WriteLine();
            int[,] mat1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            for(int i=0;i<mat1.GetLength(0);i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write("{0} ", mat1[i, j]);
                Console.WriteLine();
            }

            //matrice var 2
            int[][] mat2 = new int[2][];
            mat2[0] = new int[3] { 100, 200, 300 };
            mat2[1] = new int[4] { 400, 500, 600, 700 };
            for(int i=0;i<mat2.Length;i++)
            {
                for (int j = 0; j < mat2[i].Length; j++)
                    Console.Write("{0} ", mat2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(21, "Gigel", 9.5f);
            Student s3 = s2; //shallow copy
            Student s4 = new Student(s2); //deep copy

            s2.Nume = "Dorel";
            Console.WriteLine(s2.Nume);

            Console.WriteLine(s4.ToString());
        }
    }
}
