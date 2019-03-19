using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendindenOncekiSayininBirEksigiSoru32
{
    class Program
    {/*Bilinmeyen miktarda okutulan sayılardan kendisinden önce gelen sayıdan 1 eksik
        olan sayıları yazan sıfır girildiğinde duran program*/
        static void Main(string[] args)
        {
            int ilkSayi=0, sonSayi, fark;
            for (;;)
            {
                Console.WriteLine("Sayı Girin");
                sonSayi = Convert.ToInt32(Console.ReadLine());
              fark= sonSayi-ilkSayi;
                if (fark == 0)
                {
                  Console.WriteLine(args);
                }

            }
        }
    }
}
