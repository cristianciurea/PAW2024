using System;
using System.Collections.Generic;
using System.Text;

namespace TransferParametri
{
    class Program
    {
        public static void Interschimb1(int p, int q)
        {
            int t = p;
            p = q;
            q = t;
        }

        public static unsafe void Interschimb2(int* p, int* q)
        {
            int t = *p;
            *p = *q;
            *q = t;
        }

        public static void Interschimb3(ref int p, ref int q)
        {
            int t = p;
            p = q;
            q = t;
        }

        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 20;

            Interschimb1(var1, var2);
            Console.WriteLine("var1={0}, var2={1}", var1, var2);

            Interschimb3(ref var1, ref var2);
            Console.WriteLine("var1={0}, var2={1}", var1, var2);

            unsafe
            {
                /*int var3 = 10;
                int var4 = 20;
                Interschimb2(&var3, &var4);
                Console.WriteLine("var3={0}, var4={1}", var3, var4);*/
                Interschimb2(&var1, &var2);
                Console.WriteLine("var1={0}, var2={1}", var1, var2);
            }
        }
    }
}
