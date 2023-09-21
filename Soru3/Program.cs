using System;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den 10 a kadar olan sayıların küplerinin toplamını bulan uygulama:

            #region Çözüm 1

            //double toplamSonucu=0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    //toplamSonucu += i * i * i;
            //    toplamSonucu += Math.Pow(i, 3);
            //}
            //Console.WriteLine(toplamSonucu);
            #endregion

            #region Çözüm 2

            //double toplamSonuc = 0;
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    toplamSonuc += Math.Pow(sayac, 3);

            //    //if (sayac == 10)
            //    //break;

            //    sayac++;
            //}
            //Console.WriteLine(toplamSonuc);
            #endregion

            #region Çözüm 3

            //int sayac = 1;
            //double toplamSonuc = 0;
            //do
            //{
            //    toplamSonuc += Math.Pow(sayac, 3);
            //    //if (sayac == 10)
            //        //break;

            //    sayac++;
            //} while (sayac<=10);
            //Console.WriteLine(toplamSonuc);
            #endregion

            #region Çözüm 4
            int sayac = 1;
            double toplamSonuc = 0;
            string sonuc = "";
            while (sayac <= 10)
            {
                toplamSonuc += Math.Pow(sayac, 3);
                if (sayac !=10)
                {
                    sonuc += $"{sayac}³ +";
                }
                else
                {
                    sonuc += $"{sayac}³={toplamSonuc}";
                }
                sayac++;
            }
            Console.WriteLine(sonuc);
            #endregion
        }
    }
}
