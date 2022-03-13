using System;

namespace DigerTurler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,long,float,double,string,uint,datetime,char

            //   DateTime tarih = new DateTime(2022,3,13);
            //  DateTime tarih = DateTime.Today;
            //DateTime tarih = DateTime.Now;
            //string tarihStr = tarih.ToString();
            //string tarihStr1 = tarih.ToShortDateString();

            //int yil = tarih.Year;
            //int ay = tarih.Month;
            //int gun = tarih.Day;
            //int saat = tarih.Hour;
            //int milisaniye = tarih.Millisecond;

            //DateTime yarin = tarih.AddDays(1);
            //DateTime onumuzdekiYear = tarih.AddYears(1);

            //DateTime dun = tarih.AddDays(-1);

            //DateTime test = tarih.AddHours(-14);

            Char charDegisken = 'A';

            //string strDegisken = "AS";
            //Char ilkEleman = strDegisken[0];

            //Console.WriteLine(ilkEleman);
            stringOzellikler();

            
        }

        private static void stringOzellikler()
        {
            string asd = "ibrAHim";
            string asdBuyuk = asd.ToUpper();
            string kucukHarf = asd.ToLower();

            bool iceriyorMu = asd.Contains("z");
            bool iceriyorMu2 = asd.Contains("i");

            bool strWith = asd.StartsWith("i");
            bool strWith2 = asd.StartsWith("s");

            bool endWith = asd.EndsWith("m");
            bool endWith2 = asd.StartsWith("M");

            int size = asd.Length;

            int indexof = asd.IndexOf("H");
            int indexof1 = asd.IndexOf("i");

           // asd = "  ibra him ";
            string trimmed = asd.Trim();
            // asd.TrimStart();
            // asd.TrimEnd();

            string removed=asd.Remove(3);
            removed = asd.Remove(3,2);

            string substr = asd.Substring(3);
            substr = asd.Substring(3,2);


            string[] strDizi = new string[] { "ibrahim", "Harun", "Deniz" };
            string[] strDizi1 = new string[3];
            strDizi1[0] = "ibrahim";
            strDizi1[1] = "Harun";
            strDizi1[2] = "Cem";
          //  strDizi1[3] = "asdasd";
            string degerler = "1,2,3";
            string[] dizi = degerler.Split(",");

            string birlesmisString=string.Join(",",dizi);

            string birlesmis = "";

            for(int i=0;i<dizi.Length;i++)
            {
                birlesmis += dizi[i] + ",";
            }
            // birlesmis = birlesmis.Remove(birlesmis.Length - 1);
            birlesmis = birlesmis.Substring(0,birlesmis.Length - 1);
        }
    }
}
