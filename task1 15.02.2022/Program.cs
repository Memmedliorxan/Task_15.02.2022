using System;

namespace task1_15._02._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1


            //Console.WriteLine("uc eded daxil et");
            //string b = Console.ReadLine();
            //int eded = int.Parse(b);


            //Console.WriteLine("ikinci ededi daxil et");
            //string c = Console.ReadLine();
            //int eded1 = int.Parse(c);
            //Console.WriteLine("ucuncu ededi daxil et ve netice en boyuk reqemi gostersin");
            //string d = Console.ReadLine();
            //int eded2 = int.Parse(d);
            //if (eded == eded1 && eded1 == eded2)
            //{
            //    Console.WriteLine("beraberlik var");

            //}

            //else Console.WriteLine(Biggernumber(eded, eded1, eded2));

            #endregion
            #region Task-2
            //Console.WriteLine("eded daxil et");
            //string eded = Console.ReadLine();
            //int eded2 = int.Parse(eded);
            //Console.WriteLine(ededcemi(eded2));
            #endregion
            #region Task-3
            //Console.WriteLine("supermarketde endirimler davam edir,sadece iki bahali malin qiymeti odenilecek.");
            //string malinsayi = Console.ReadLine();
            //int say = int.Parse(malinsayi sayi1);
            //int[] arr2 = new int
            #endregion
        }
        #region Task-1
        static int Biggernumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;

            }

            else if (b > a && b > c)
            {

                return b;
            }
            else return c;
        }
        #endregion
        #region Task-2
        static int ededcemi(int a)
        {
            int count;
            int cem = 0;
            while (a > 0)
            {
                count = a % 10;
                a /= 10;
                cem += count;

            }
            return cem;

        }
        #endregion
        #region Task-3

        #endregion
    }
}
