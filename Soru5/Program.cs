using System;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının faktöriyelini hesaplayan uygulama:

            //3!=3*2*1 örnek faktöriyel hesaplama

            #region Çözüm 1

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = sayi; i > 0; i--)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Çözüm 2

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;

            //while (sayi > 0)
            //{
            //    sonuc *= sayi;
            //    sayi--;
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Çözüm 3

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //do
            //{
            //    if (sayi == 0) break;
            //    sonuc *= sayi;
            //    sayi--;
            //    //if (sayi == 0) break;
            //} while (true);
            //Console.WriteLine(sonuc);
            #endregion

            #region Çözüm 4

            //Sonucu bu formatta göstersin istedik:
            //5x4x3x2x1=120

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 1;
            //string _sonuc = "";

            //while (sayi > 0)
            //{
            //    sonuc *= sayi;
            //    if (sayi != 1)
            //        _sonuc += $"{sayi} X ";
            //    else
            //        _sonuc += $"{sayi}={sonuc}";
            //    sayi--;
            //}
            //Console.WriteLine(_sonuc);
            #endregion

            #region Çözüm 5
            //öncelikle Faktoriyel methodunu tanımladık.

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi));
            #endregion
        }
        static int Faktoriyel(int sayi)
        {
            if (sayi > 1)
                return sayi * Faktoriyel(--sayi);
            return sayi;
        }
    }
}
