using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 1;
            kurs1.KursAdi = "java";
            Console.WriteLine(kurs1.KursAdi+" "+kurs1.IzlenmeOrani+" "+kurs1.Egitmen);
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
