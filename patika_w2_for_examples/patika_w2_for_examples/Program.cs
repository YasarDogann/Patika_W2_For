using System;
using System.Threading.Channels;

namespace patika_w2_for_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            
            string y = "Kendime inanıyorum, ben bu yazılım işini hallederim!";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1+". "+y);
            }


            //  2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }


            //  3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            
            for (int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine(i + 1);
            }

            // 2.YÖNNTEM TERNANY İF KULLANIMI
            for (int i = 1; i <= 20; i++)
            {
               Console.WriteLine((i % 2 == 0) ? i : "");  
            }



            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            
            int sum = 0;

            for(int i =50; i<=150; i++)
            {
                sum += i;
            }
            Console.WriteLine("Toplam: {0}",sum);
            


            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

            int sumOddNum= 0, sumEvenNum = 0;

            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 1)
                {
                    sumOddNum += i;
                }
                else
                {
                    sumEvenNum += i;
                }
            }

            Console.WriteLine("Tek Sayıların toplamı: {0}",sumOddNum);
            Console.WriteLine("Çift Sayıların toplamı: {0}", sumEvenNum);

            Console.Read();

        }
    }
}
