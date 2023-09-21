using System;

namespace Soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen pozitif sayının kaç basamaklı olduğunu söyleyen uygulama:

            #region Çözüm 1

            //Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            //float sayi = float.Parse(Console.ReadLine());

            //float sayac = 0;
            //for (; sayi >= 10;)
            //{
            //    sayi /= 10;
            //    sayac++;
            //}
            //sayac++;
            //Console.WriteLine($"{sayi} sayısının basamak değeri: {sayac}");
            #region Farklı For Döngüleri de kullanabilirsin
            //YADA

            //for (float i = 0; sayi >= 10;)
            //{
            //    sayi /= 10;
            //    i++;
            //}

            //YADA

            //for (float i = 0; sayi >= 10;i++)
            //{
            //    sayi /= 10;
            //} 
            #endregion
            #endregion

            #region Çözüm 2
            //Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            #region Alternatif yazım stili
            //int _i = 0;
            //for (int i=0; ; )
            //{
            //    sayi /= 10;
            //    i++;
            //    _i = i;
            //    if (sayi < 10)
            //        break;
            //} 
            #endregion

            //int sonuc = 0;
            //int _sayi = sayi;
            //for (; ; )//Sonsuz/Kısır döngüdür.
            //{
            //    sayi /= 10;
            //    sonuc++;
            //    if (sayi < 10)
            //        break;
            //}
            //sonuc++;
            //Console.WriteLine($"{_sayi} sayısı {sonuc} basamaklıdır...");
            #endregion

            #region Çözüm 3

            //Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int _sayi = sayi;
            //int sonuc = 0;
            //while (true)
            //{
            //    sayi /= 10;
            //    sonuc++;
            //    if (sayi < 10)
            //        break;
            //}
            //sonuc++;
            //Console.WriteLine($"{_sayi} sayısı {sonuc} basamaklıdır.");
            #endregion

            #region Çözüm 4

            //Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int _sayi = sayi;
            //int sonuc = 0;

            //while (sayi>=10)
            //{
            //    sayi /= 10;
            //    sonuc++;
            //    //if (sayi < 10)
            //        //break;
            //}
            //sonuc++;
            //Console.WriteLine($"{_sayi} sayısı {sonuc} basamaklıdır.");

            #endregion

            #region Çözüm 5

            //Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int _sayi = sayi;
            //int sonuc = 0;
            //do
            //{
            //    sayi /= 10;
            //    sonuc++;
            //    //if (sayi < 10)
            //    //break;
            //} while (sayi >= 10);
            ////sonuc++;
            //Console.WriteLine($"{_sayi} sayısı {++sonuc} basamaklıdır.");

            //Not:
            //++sonuc => Önce sonucu 1 arttırıyor, sonra yazdırıyor.
            //sonuc++ => Önce yazdırıyor, sonra sonucu 1 arttırıyor.
            #endregion

            #region Çözüm 6

            //Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = BasamakSayisi(sayi);
            //sonuc++;
            //Console.WriteLine($"{sayi} sayısı {sonuc} basamaklıdır");
            #endregion

            #region Çözüm 7

            Console.WriteLine("Lütfen basamak sayısını öğrenmek istediğiniz sayıyı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine($"{sayi} sayısının basamak değeri: {sayi.ToString().Length}");
            //Console.WriteLine($"{sayi} sayısının basamak değeri: {Convert.ToString(sayi).Length}");
            #endregion
        }
        #region Çözüm 6 Recursive Fonksiyon
        //static int BasamakSayisi(int sayi)
        //{
        //    sayi /= 10;
        //    if (sayi >= 10)
        //        return 1 + BasamakSayisi(sayi);
        //    return 1;
        //} 
        #endregion
    }
}
