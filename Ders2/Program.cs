using System;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("sayı girin: çıkış için C");
                string deger = Console.ReadLine();

                if (deger == "C")
                    return;

                int sayi = Convert.ToInt32(deger);
                bool asal = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asal = false;
                    }
                }

                if (asal)
                {
                    Console.WriteLine("SAyı asaldır");
                }
                else
                {
                    Console.WriteLine("asal değil");
                } 
            }
            
            Console.ReadLine();
        }
    }
}
