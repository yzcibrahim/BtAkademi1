using System;

namespace BtAkademi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //string abc="Cem";


            ////Console.WriteLine("isim giriniz");
            ////abc = Console.ReadLine();

            ////abc = "test";


            ////Console.WriteLine("merhaba " + abc);

            ///*
            //string s1 = "5";
            //string s2 = "4";
            //Console.WriteLine(s1 + s2);
            //*/




            //long asd = 5;

            ////  int sayi = Convert.ToInt32("5");

            ////string sayiStr = Console.ReadLine();
            ////int sayi1 = Convert.ToInt32(sayiStr);

            ////Console.WriteLine("Birinci Sayıyı Giriniz:");
            ////int sayi1 = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine("İkinci Sayıyı Giriniz:");
            ////int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Birinci Sayıyı Giriniz:");
            //double sayi1 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("İkinci Sayıyı Giriniz:");
            //double sayi2 = Convert.ToSingle(Console.ReadLine());


            //double toplam = sayi1 + sayi2;
            //double fark = sayi1 - sayi2;
            //double carpim = sayi1 * sayi2;
            //double bolum = sayi1 / sayi2;

            ////  float bolumf =(float)sayi1 / (float)sayi2;
            //// float bolumf = (float)sayi1 / sayi2;
            //double bolumf = sayi1 / (double)sayi2;


            //Console.WriteLine("tolplam:"+toplam);
            //Console.WriteLine("fark:" + fark);
            //Console.WriteLine("carpim:" + carpim);
            //Console.WriteLine("bolum:" + bolum);
            //Console.WriteLine("bolumf:" + bolumf);
            //Console.WriteLine("mod:" + sayi1%sayi2);

            //int tamsayi1 = 2147483647;


            //long logngsayi = 2147483648;


            //bool boolDeger = false;
            //boolDeger = true;

            //boolDeger = toplam > 50;
            //if (boolDeger)
            //{
            //    Console.WriteLine("Toplamın değeri 50 den büyüktür");
            //    Console.WriteLine("evet");
            //}
            //else if(toplam<50)
            //{
            //    Console.WriteLine("Toplamın değeri 50 den küçüktür");
            //}
            //else if(toplam==50)
            //{
            //    Console.WriteLine("sayı 50 dir");
            //}

            //if (toplam % 2 == 0)
            //{
            //    Console.WriteLine("SAyı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("SAyı Tektir");
            //}

            //switch(toplam)
            //{
            //    case double n when n > 50:
            //        Console.WriteLine("50 den büyük");
            //        break;
            //    case double n when n < 50:
            //        Console.WriteLine("50 den küçük");
            //        break;
            //    default:
            //        Console.WriteLine("sayı 50");
            //        break;
            //}

            ////|| &&
            ////if(toplam > 50 || toplam == 50)
            ////{
            ////    Console.WriteLine("ifade doğru");
            ////}
            //if (toplam > 50 && toplam == 50)
            //{
            //    Console.WriteLine("ifade doğru");
            //}

            int index = 0;
            for (index = 0; index < 50; index=index+2)
            {
                Console.WriteLine(index + "Günaydın sınıf");
            }

            index = 50;
            while (index < 50)
            {
                Console.WriteLine(index + "Günaydın sınıf while");
                index++;
                //index = index + 1;
                //index += 1;
            }

            index = 50;
            do
            {
                Console.WriteLine(index + "Günaydın sınıf while");
                index++;

            }
            while (index < 50);

            Console.ReadLine();

        }

    }
}
