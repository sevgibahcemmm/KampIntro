using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;// değer tipler
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayialr1 = new int[] { 10, 20, 30 };//referans tipler
            int[] sayialr2 = new int[] { 100, 200, 300 };
            sayialr1 = sayialr2;
            sayialr2[0] = 999;
            Console.WriteLine(sayialr1[0]);

           // stack            heap               bellekte açılan yerler
           //değerler          referanslar
        }
    }
}
