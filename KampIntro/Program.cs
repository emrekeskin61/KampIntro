using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip ggüvenliği
            string kategoriEtiketi = "kategori";
            int ogrenciSyısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısmı = true;
            double dolarDun = 7.35;
            double dolarNugun = 7.45;
            if (dolarDun<dolarNugun)
            {
                Console.WriteLine("artıs butonu");

            }
            else if (dolarNugun<dolarDun)
            {
                Console.WriteLine("azalıs");
            }
            else
            {
                Console.WriteLine("degısmedi");
            }
            if (sistemeGirisYapmısmı==true)
            {
                Console.WriteLine("kulanıcı ayarı butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


        }
    }
}
