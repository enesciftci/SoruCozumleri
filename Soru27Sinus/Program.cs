using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru27Sinus
{
    class Program
    {
        static double usAl(double taban, double us)
        {
            double sonuc = 1;
            for (int i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }

            return sonuc;
        }
      static double faktoriyel(double sayi)
        {
            double fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak = fak * i;

                // sayi--;
            }


            return fak;
        }

        private static double N, X;
        static void Main(string[] args)
        {
            Console.WriteLine("Sinüsünü hesaplamak istediğiniz değeri girin");
            N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hangi kuvveti hesaplamak istiyorsunuz");
            X = Convert.ToDouble(Console.ReadLine());
          double sonuc=  (usAl(-1, N) * X * 2 * N + 1) / faktoriyel(2 * N + 1);
           Console.WriteLine("İstediğiniz değer {0}",sonuc);
            Console.WriteLine("İstediğiniz değer {0}",Math.Sin(N));
        
            Console.ReadKey();
        }
    }
}
