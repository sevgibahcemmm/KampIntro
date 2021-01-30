using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatagoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CatagoryId = 5,
                ProductName = "Kalem",
                UnitsInStock = 5,
                UnitPrice = 35
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
           // Console.WriteLine(product1.ProductName);
            productManager.Update(product2);
            //  Console.WriteLine(product2.ProductName);

            productManager.Topla2(3, 6);
            int sonuc=productManager.Topla(3, 6);
            Console.WriteLine(sonuc*2);


            //int sayi = 100;
            //productManager.BirseyYp(sayi);
            //Console.WriteLine( sayi);
        }
    }
}
