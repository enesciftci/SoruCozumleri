using System;

namespace KoordinataGoreSekilTespiti
{
    class Program
    {
        /*Bilinmeyen miktarda okutulan A,B,C,D koordinat değerleri için 
                a)A,B,C,D değerlerinden biri sıfırdan küçükse "Yanlış",
                b)A<>D ise "Dörtgen",
                c)A=D ve A=B ise "Kare" değilse "Dikdörtgen mesajını yazan ve bu değerlerden
                biri 0 olduğunda programı durduran program.*/
        static void Main(string[] args)
        {
            int A, B, C, D;
            for (;;)
            {
                Console.WriteLine("A değerini girin");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B değerini girin");
                B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("C değerini girin");
                C = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("D değerini girin");
                D = Convert.ToInt32(Console.ReadLine());
                if (A == 0 || B == 0 || C == 0 || D == 0)
                {
                    break;
                }
                if (A < 0 || B < 0 || C < 0 || D < 0)
                {
                    Console.WriteLine("Girilen değer hatalı");
                }
                else
                {

                    if (A != D)
                    {
                        Console.WriteLine("Bu bir Dörtgen");
                    }
                    else if (A == D && A == B)
                    {
                        Console.WriteLine("Bu bir Kare");

                    }
                    else if (A != D || A != B)
                    {
                        Console.WriteLine("Bu bir Dikdörtgen");
                    }

                }
            }
        }
    }
}
