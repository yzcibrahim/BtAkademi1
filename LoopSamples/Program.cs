using System;

namespace LoopSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for(int i=0;i<sayi;i++)
            //{
            //    Console.WriteLine((i+1)+"Günaydın sınıf");
            //}

            #region sayıların toplamı
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            ////int sonuc = sayi * (sayi + 1) / 2;
            //int sonuc=0;
            //for(int i=1;i<=sayi;i++)
            //{
            //  //   sonuc = sonuc + i;
            //   sonuc += i;
            //}

            //Console.WriteLine(sonuc);
            #endregion

            #region faktoriyel
            //int sonuc = 1;
            //for(int i=1;i<=sayi;i++)
            //{
            //    //sonuc = sonuc * i;
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);

            #endregion

            //for(int i=1;i<=sayi;i++)
            //{
            //    Console.WriteLine(i + " karesi:" + (i * i));
            //}

            //int i = 1;
            //while(i<=sayi)
            //{
            //    Console.WriteLine(i + " karesi:" + (i * i));
            //    i++;
            //}

            //kare
            //for (int i = 0; i < sayi; i++)
            //{
            //    for (int j = 0; j < sayi; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //üçgen
            //for (int i = 0; i < sayi; i++)
            //{
            //    for (int j = 0; j < sayi-i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            string tekmiCiftmi = "tek";
            for(int i=0;i<=sayi;i++)
            {
                //if(i%2==0)
                //{
                //    tekmiCiftmi = "çift";
                //}
                //else
                //{
                //    tekmiCiftmi = "tek";
                //}
                tekmiCiftmi = i % 2 == 0 ? "çift" : "tek";
                Console.WriteLine(i + " :" + tekmiCiftmi);

            }

            Console.WriteLine("Teşekkürler");


        }
    }
}
