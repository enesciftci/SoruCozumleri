using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru24BolumKalan
{
    static class Program
    {
        static void Main(string[] args)
        {/* Bilgisayara okutulan pay,payda sayıları üzerinde pay/payda işlemini
            bölme yerine çıkarma metodu kullanılarak sonuçta elde edilecek bölüm
            ile kalan değerlerini bulan ve yazan program*/
            Console.WriteLine("Payı girin");
            int pay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Paydayı Girin");
            int payda = Convert.ToInt32(Console.ReadLine());
            int son=0;
            int i;
            for ( i=0; payda<=pay; i++)
            {
            pay = pay - payda;
            }
          Console.WriteLine("Bölüm {0}",i);
            Console.WriteLine("Kalan {0}",pay);
            Console.ReadKey();
        }
    }
}
