using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "yazılım geliştirici kampı",
             "prohramlamaya başlangıç için temel kurs",
             "java"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
