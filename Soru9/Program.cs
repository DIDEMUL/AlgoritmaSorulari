using System;

namespace Soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen 3 basamaklı bir sayının basamaklarının küpleri toplamı sayının kendine eşit olup olmadığını bulan uygulama:
            #region Çözüm 1

            Console.WriteLine("Lütfen üç basamaklı bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            //Console.WriteLine(Basamak(sayi));

            //bool durum = Basamak(sayi);
            if (Basamak(sayi))
            {
                int _sayi = sayi;
                double kupToplam = 0;
                while (true)
                {
                    int basamak = _sayi % 10;
                    _sayi /= 10;

                    kupToplam += Math.Pow(basamak, 3);
                    //kupToplam += basamak * basamak * basamak;

                    if (_sayi < 10)
                    {
                        //basamak = _sayi % 10;
                        basamak = _sayi;
                        kupToplam += Math.Pow(basamak, 3);
                        break;
                    }
                }
                if (kupToplam==sayi)
                {
                    Console.WriteLine("Eşittir.");
                }
                else
                {
                    Console.WriteLine("Eşit Değildir");
                }
            }
            else
            {
                Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz...");
            }
            #endregion
        }
        static bool Basamak(int sayi)
        {
            //while (sayi >= 10)
            int basamakSayisi = 1;
            while (true)
            {
                basamakSayisi++;
                sayi /= 10;
                if (sayi < 10)
                    break;
            }
            //if (basamakSayisi==3)
            //    return true;
            //return false;

            return basamakSayisi == 3 ? true : false;
        }
    }
}
