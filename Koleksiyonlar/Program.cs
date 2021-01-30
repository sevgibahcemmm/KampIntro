using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil", "Emrullah" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string>
            { 
                "Engin","Murat","Kerem","Halil","Emrullah"
            };

            isimler2.Add("Batuhan");

            for (int i = 0; i < isimler2.Count; i++)
            {
                Console.WriteLine(isimler2[i]);
            }
            Console.WriteLine(isimler2[0]);
        }
    }
}
