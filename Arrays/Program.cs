using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // diziOrnek1();

            // DiziOrnek2();

            //  Ornek3Max();
            //   Ornek4StringInterpolation();
            //  Ornek4YerDegistir();
            // Ornek5DizininMinelemaniniBul();
            // Ornek6DiziyiTersYazdirma();
            //    TerstenYazdirmaV1();
            //   TerstenYazdirmaV1("asdasd");
            diziOkumaAlternatif();

        }
        static void TerstenYazdirmaV1()
        {
            int[] a = DiziOku();
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.Write($"{a[i]},");
            }

        }

        static void TerstenYazdirmaV1(string test)
        {
            Console.WriteLine("overloaded method");

        }
        static void Ornek6DiziyiTersYazdirma()
        {
            int[] a = DiziOku();

            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.WriteLine(a[a.Length-1-i]);
                }
                else
                {
                    Console.Write($"{a[a.Length-1-i]},");
                }
            }
            
        }
        static void Ornek5DizininMinelemaniniBul()
        {
            int[] a = DiziOku();
            int min = a[0];
            int minIndex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if(a[i]<min)
                {
                    min = a[i];
                    minIndex = i;
                }
            }
            int temp = a[0];
            a[0] = a[minIndex];
            a[minIndex] = temp;

        }
        static void Ornek4YerDegistir()
        {
            int sayi1 = IntOku("birinci sayıyı giriniz:");
            int sayi2 = IntOku();
            ///değiştir
            int gecici = sayi1;
            sayi1 = sayi2;
            sayi2 = gecici;
            ///

            Console.WriteLine($"sayı1 yeni değeri:{sayi1}");
            Console.WriteLine($"sayı2 yeni değeri:{sayi2}");
        }
        static void Ornek4StringInterpolation()
        {
            string ad = "ibrahim";
            string soyad = "yazıcı";

            //string tamAd1 = "Merhaba "+ad + " " + soyad;
           // tamAd1 = string.Concat("Merhaba",ad," " ,soyad);
            string tamAd = String.Format("Merhaba {0} {1}", ad, soyad);

            tamAd = $"Merhaba {ad} {soyad}";

            Console.WriteLine(tamAd);
        }

        static void Ornek3Max()
        {
            int sayi1 = IntOku("sayi1 giriniz.");
            int sayi2 = IntOku("sayi2 giriniz.");
           // int sayi3 = IntOku();
           if(sayi1>sayi2)
            {
                Console.WriteLine($"büyüksayı: {sayi1}");
            }
           else
            {
                Console.WriteLine($"büyüksayı: {sayi2}");
            }

        }

        static int IntOku(string aciklama="Sayı giriniz.")
        {
            Console.WriteLine(aciklama);
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            return sayi1;
        }

        private static void DiziOrnek2()
        {
            int[] dizi = DiziOku();

            int[] dizi2 = new int[dizi.Length];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi2[i] = dizi[i] * 2;
            }
            DiziYazdir(dizi);
            DiziYazdir(dizi2);
        }

        static void DiziYazdir(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.WriteLine(a[i]);
                }
                else
                {
                    Console.Write(a[i] + ",");
                }
            }
        }

        static int[] DiziOku()
        {
            Console.WriteLine("dizi boyutu giriniz:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for(int i=0;i<size;i++)
            {
                Console.WriteLine($"dizinin {i}.elemanını giriniz:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            return a;
        }

        static int[] diziOkumaAlternatif()
        {

            Console.WriteLine("dizinin elemanlarını aralarda virgül olacak şekilde girin:");
            string girilenDeger = Console.ReadLine();
            string[] a = girilenDeger.Split(",");

            int[] b = new int[a.Length];
            for(int i=0;i<b.Length;i++)
            {
                b[i] = Convert.ToInt32(a[i]);
            }
            return b;
        }
        static void diziOrnek1()
        {
            Console.WriteLine("dizi boyutu giriniz");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Dizinin elemanlarını Giriniz:");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Dizinin " + i + ". elemanını giriniz:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //    Console.WriteLine(a[10]);index was outside of bounds array
            int diziToplami = diziToplam(a);
            Console.WriteLine("dizi toplamı " + diziToplami);
        }

        static int diziToplam(int[] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }

            return toplam;
        }
    }
}

