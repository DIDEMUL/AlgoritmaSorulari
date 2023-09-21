﻿using System;

namespace Soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pozitif sayılarda bölme işlemini çıkarma kullanarak yapan uygulama:

            #region Çözüm 1

            //Console.WriteLine("Lütfen bölünen sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen böleceğiniz sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int _sayi1 = sayi1;
            //int sonuc = 0;
            //int kalan = 0;
            //for (int i = 0; i < _sayi1; i++)
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;

            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc} | Kalan ={kalan}");
            #endregion

            #region Çözüm 2

            //Console.WriteLine("Lütfen bölünen sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen böleceğiniz sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            ////int sayac = sayi1;
            //int _sayi1 = sayi1;
            //int sonuc = 0;
            //int kalan = 0;
            //while (true)
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;

            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }
            //    //sayac--;
            //}
            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc} | Kalan={kalan}");
            #endregion

            #region Çözüm 3

            //Console.WriteLine("Lütfen bölünen sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen böleceğiniz sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int _sayi1 = sayi1;
            //int sonuc = 0, kalan = 0;
            //do
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;
            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }

            //} while (true);
            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc} |Kalan={kalan}");
            #endregion

            #region Çözüm 4

            Console.WriteLine("Lütfen bölünen sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen böleceğiniz sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            int bolmeSonucu = Bol(sayi1, sayi2);
            int kalan = Kalan(sayi1, sayi2);

            Console.WriteLine($"{sayi1} / {sayi2} = {bolmeSonucu} | Kalan = {kalan}");
            #endregion
        }
        static int Bol(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if (sayi1 > sayi2)

                return 1 + Bol(sayi1, sayi2);
            return 1;
        }
        static int Kalan(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if (sayi1 >= sayi2)
                return Kalan(sayi1, sayi2);
            return sayi1;
        }
    }
}
