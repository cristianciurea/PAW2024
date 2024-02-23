using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /*struct Student
        {
            public int cod;
            private string nume;
            public bool integralist;
        };

        enum Importance
        {
            None, Trivial, Regular, Important, Critical
        };*/

        static void Main(string[] args)
        {
            int var1 = 5;
            unsafe
            {
                int* ptr1, ptr2;
                ptr1 = &var1;
                ptr2 = ptr1;
                *ptr2 = 20;
            }
            Console.WriteLine(var1);
            Console.Read();
        }
    }
}
