using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10;
            int s2 = 30;
            s1 = s2;
            s2 = 65;
            //s1 ?

            int[] s3 = new int[] { 10, 20, 30 };
            int[] s4 = new int[] { 100, 200, 300 };
            s3 = s4;
            s4[0] = 999;
            //s3[0] ?
        }
    }
}
