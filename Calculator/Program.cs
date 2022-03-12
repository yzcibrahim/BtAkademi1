using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoş geldiniz");
            Console.WriteLine("Birinci Sayıyı Giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            string islemTipi;

            Console.WriteLine("Toplama için t, fark için f, çarpma için c,  bolme icin b giriniz");
            islemTipi = Console.ReadLine();

            #region ifelse
            //if (islemTipi == "t" || islemTipi=="T")
            //{
            //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            //}
            //else if (islemTipi == "f" || islemTipi == "F")
            //{
            //    Console.WriteLine("Fark:" + (sayi1 - sayi2));
            //}
            //else if (islemTipi == "c" || islemTipi == "C")
            //{
            //    Console.WriteLine("çarpım:" + (sayi1 * sayi2));
            //}
            //else if (islemTipi == "b" || islemTipi == "B")
            //{
            //    Console.WriteLine("Bölüm:" + (sayi1 / sayi2));
            //}
            //else
            //{
            //    Console.WriteLine("Bilinmeyen işlem");
            //}
            #endregion

            #region switch case
            switch (islemTipi)
            {
                case "t":
                case "T":
                    Console.WriteLine("toplam:" + (sayi1 + sayi2));
                    break;
                case "f":
                    Console.WriteLine("fark:" + (sayi1 - sayi2));
                    break;
                case "c":
                    Console.WriteLine("çarpım:" + (sayi1 * sayi2));
                    break;
                case "b":
                    Console.WriteLine("bölüm:" + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("bilinmeyen işlem tipi");
                    break;
            }
            #endregion



        }
    }
}
