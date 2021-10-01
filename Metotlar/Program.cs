using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Name = "elma";
            urun1.Price = 1.30;
            urun1.Explanation = "kırmızı taze";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Name = "armut";
            urun2.Price = 2.30;
            urun2.Explanation = "deveci armut";


            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Explanation);
              
            }
            Console.WriteLine("------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
        }
    }
}
