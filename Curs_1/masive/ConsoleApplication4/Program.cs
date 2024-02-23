using System;
using System.Collections.Generic;
using System.Text;

namespace Masive
{
    class Vectori : ICloneable
    {
        
        static public void AfisareMasiv(int[] v)
        {
            Console.WriteLine("Masivul unidimensional este:");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }

        //metoda Clone() standard/implicita
        object ICloneable.Clone()
        {
            return this.MemberwiseClone(); //creaza o copie superficiala a obiectului curent
        }

        static void Main(string[] args)
        {
            //definire vectori
            int[] v1;
            int[] v2 = { 1, 2, 3, 4, 5, 6 };
            int[] v3 = new int[5];
            int[] v4 = new int[3] { 10, 20, 30 };

            //shallow copy - copiere de referinte
            v1 = v2;

            AfisareMasiv(v1);
            AfisareMasiv(v2);

            v1[2] = 100;
            AfisareMasiv(v1);
            AfisareMasiv(v2);

            //deep copy - copiere de valori
            v1 = new int[3];
            for (int i = 0; i < v4.Length; i++) 
                v1[i] = v4[i];

            v1[1] = 200;
            AfisareMasiv(v1);
            AfisareMasiv(v4);

            //apel metoda Clone() - copiere de valori
            v1 = (int[])v4.Clone();

            v1[1] = 300;
            AfisareMasiv(v1);
            AfisareMasiv(v4);

            Console.WriteLine("---------------");
            int[,] matrice = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (int i = 0; i < matrice.GetLength(0); i++)
                for (int j = 0; j < matrice.GetLength(1); j++)
                    Console.WriteLine(matrice[i, j]);

            Console.WriteLine("---------------");
            matrice = new int[3, 2];
            for (int i = 0; i < matrice.GetLength(0); i++)
                for (int j = 0; j < matrice.GetLength(1); j++)
                    Console.WriteLine(matrice[i, j]);

            Console.WriteLine("---------------");
            int[][] matr = new int[3][];
            for (int i = 0; i < matr.Length; i++)
            {
                matr[i] = new int[2];
                for (int j = 0; j < matr[i].Length; j++)
                    Console.WriteLine(matr[i][j]);
            }

            Console.Read();
        }
    }
}
