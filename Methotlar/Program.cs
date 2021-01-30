using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 150;


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 100;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı        :"+urun.Adi);
                Console.WriteLine("Ürün Fiyatı     :" + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması : " + urun.Aciklama);
                Console.WriteLine("Ürün Açıklaması : " + urun.StokAdedi);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("----------------Methotlar------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            Console.WriteLine("----------------------------------");
            sepetManager.Ekle(urun2);

            Console.WriteLine("----------------------------------");
            sepetManager.Ekle2("Armut","Yeşil Armut",12,50);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 10,70);
            sepetManager.Ekle2("Karpuz", "Diyarbakır KArpuzu", 20,60);

            Console.WriteLine("Hello World!");

            
        }
    }
}
// Dont repeat yourself -DRY --kendini tekrar etme
// clean code -Temiz kod
// Best Practice-En iyi pratik