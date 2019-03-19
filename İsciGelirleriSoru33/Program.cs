using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsciGelirleriSoru33
{
    class Program
    {
        /*Bir araştırma kuruluşunca işçilere ait bilgiler üzerinde
         anket sonucundan her işçinin yıllık geliri bilgisayara aktarılmaktadır.
         Yıllık geliri 0 girildiğinde aşağıdaki değerleri bulup yazan programı yazın
         a) Toplam işçi sayısı
         b) Ortalama gelir
         c)Yıllık geliri 1 milyondan az olan işçi sayısı
         d)Yıllık geliri 1 ile 6 milyon arasında olan işçi sayısı
         e) Yıllık geliri 6 milyondan fazla olan işçi sayısı*/
        static void Main(string[] args)
        {
            int yillikGelir;
            int isciSayisi=0;
            int yillikToplam=0;
            int ortGelir;
            int yillikBirMilyon=0;
            int yillikBirileAltıMilyon=0;
            int yillikAltıMilyon=0;
            for (;;)
            {
                Console.WriteLine("Yıllık gelir girin");
                yillikGelir = Convert.ToInt32(Console.ReadLine());
                if (yillikGelir > 0)
                {
                    isciSayisi++;
                    if (yillikGelir <= 1000000)
                    {
                        yillikToplam += yillikGelir;
                        yillikBirMilyon++;
                    }

                    if (yillikGelir > 1000000 && yillikGelir < 6000000)
                    {
                        yillikToplam += yillikGelir;
                        yillikBirileAltıMilyon++;
                    }
                    if(yillikGelir>=6000000)
                    {
                        yillikToplam += yillikGelir;
                        yillikAltıMilyon++;
                    }
                }
                else
                {
                    ortGelir = yillikToplam / isciSayisi;
                    Console.WriteLine("Toplam işçi sayısı {0}",isciSayisi);
                    Console.WriteLine("Ortalama Gelir {0}",ortGelir);
                    Console.WriteLine("Yıllık Geliri 1 Milyondan az olan işçi sayısı {0}",yillikBirMilyon);
                    Console.WriteLine("Yıllık Geliri 1 Milyon ile 6 Milyon arasında olan işçi sayısı {0}",yillikBirileAltıMilyon);
                    Console.WriteLine("Yıllık Geliri 6 Milyondan fazla olan işçi sayısı {0}",yillikAltıMilyon);
                    break;
                    
                }
               
            }
            Console.ReadKey();
        }
    }
}
