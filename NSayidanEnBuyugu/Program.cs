using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSayidanEnBuyugu
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 0 girilene kadar okutulan sayıların arasından en büyüğü bulan ve
             ekrana yazan program */
            int enBuyuk=0;
            int sayi=0;

            for (;;)
            {
                Console.WriteLine("Lütfen bir sayı girin");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (enBuyuk <= sayi)
                {
                    enBuyuk = sayi;
                }
                else if (sayi == 0)

                {
                    break;
                }
            }

            Console.WriteLine("En Büyük sayı {0}",enBuyuk);
            Console.ReadKey();
        }
    }
}
