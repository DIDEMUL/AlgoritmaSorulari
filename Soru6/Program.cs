using System;

namespace Soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pozitif sayılarda çarpma işlemini toplama kullanarak bulan uygulama:

            #region Çözüm 1

            //Console.WriteLine("Lütfen birinci sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int carpmaSonucu = 0;
            //for (int i = 0; i < sayi1; i++)
            //{
            //    carpmaSonucu += sayi2;
            //}
            //Console.WriteLine($"{sayi1} X {sayi2} = {carpmaSonucu}");
            #endregion

            #region Çözüm 2

            //Console.WriteLine("Lütfen birinci sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sayac = sayi2;
            //int sonuc = 0;
            //while (sayac > 0)
            //{
            //    sonuc += sayi1;
            //    sayac--;
            //}
            //Console.WriteLine($"{sayi1} X {sayi2} = {sonuc}");
            #endregion

            #region Çözüm 3

            //Console.WriteLine("Lütfen birinci sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sonuc = 0;
            //int sayac = sayi2;

            //do
            //{
            //    sonuc += sayi1;
            //    sayac--;

            //} while (sayac > 0);
            //Console.WriteLine($"{sayi1} X {sayi2} ={sonuc}");
            #endregion

            #region Çözüm 4
            //öncelikle Topla methodunu tanımladık.

            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Topla(sayi1, sayi2));
            #endregion
        }
        //Bir fonsiyon kendi içerisinde kendini çağırıyorsa => "recursive fonksiyon"
        static int Topla(int sayi1, int sayi2)
        {
            if (sayi2 > 1)
                return sayi1 + Topla(sayi1, --sayi2);//recursive fonksiyonlar döngüsel işlemler yapmamızı sağlar.
            return sayi1;
        }
    }
}
