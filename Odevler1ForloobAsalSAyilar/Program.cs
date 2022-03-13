using System;

namespace Odevler1ForloobAsalSAyilar
{
    class Program
    {
        static void Main(string[] args)
        {
          //  UcgenCiz();
            int asalsayiCount = 0;

            for (int j = 2; asalsayiCount < 10; j++)
            {
                 bool isAsal=AsalSayiHesapla(j);
                if(isAsal)
                {
                    Console.WriteLine(j + " sayısı Asaldır");
                    asalsayiCount++;
                }
            }


        }

        static bool AsalSayiHesapla(int sayi)
        {
            bool asalMi = true;

            for (int i = 2; i < sayi; i++)
            {
                int kalan = sayi % i;
                if (kalan == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            return asalMi;
        }

        static void UcgenCiz()
        {
            Console.WriteLine("Yıldız Sayısı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
