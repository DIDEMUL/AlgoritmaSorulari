using System;

namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            //iki sayının toplamını veren uygulama:

            #region Çözüm 1

            //int sayi1 = 10, sayi2 = 20;
            //Console.WriteLine(sayi1+sayi2);

            #endregion

            #region Çözüm 2

            //Console.WriteLine("lütfen sayi1 değerini giriniz");
            //Console.ReadLine();
            //int sayi1 = Convert.ToInt32(Console.ReadLine());//Convert ile de stringi int e çevirebilirsin.
            //Console.WriteLine("lütfen sayi2 değerini giriniz");
            //Console.ReadLine();
            //int sayi2 = int.Parse(Console.ReadLine());//Parse ile de stringi int e çevirebilirsin.Parse=>sadece stringte kullanılır.
            //Console.WriteLine(sayi1 + sayi2);
            #endregion

            #region Çözüm 3

            try
            {
                Console.WriteLine("lütfen sayi1 değerini giriniz");
                Console.ReadLine();
                int sayi1 = Convert.ToInt32(Console.ReadLine());//Convert ile de stringi int e çevirebilirsin.
                Console.WriteLine("lütfen sayi2 değerini giriniz");
                Console.ReadLine();
                int sayi2 = int.Parse(Console.ReadLine());//Parse ile de stringi int e çevirebilirsin.Parse=>sadece stringte kullanılır.
                Console.WriteLine(sayi1 + sayi2);
            }
            catch
            {

                Console.WriteLine("Lütfen doğru bir sayı değeri giriniz!");
            } 
            #endregion

        }
    }
}
