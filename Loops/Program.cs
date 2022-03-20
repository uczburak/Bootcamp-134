using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Sayı tahmin oyunu
               * Program rastgele bir sayı üretir.
               * Kullanıcıdan tahmin istenir.
               * Girilen tahmine göre aşağı ya da yukarı biçiminde yönlendirilir.
               * Sayı bilinene dek tahmin istenir.
             */
            bool isFinished = false;
            Random randomNumberGenerator = new Random();
            
            int randomNumber = randomNumberGenerator.Next(0, 100);
            while (!isFinished)
            {
                // Kullanıcıdan her adımda bir tahmin iste
                Console.WriteLine("Tahmininizi girin:");
                int guess = Convert.ToInt32(Console.ReadLine());

                // Aşağı ya da yukarı biçimde yönlendirme
                if (guess < randomNumber)
                {
                    Console.WriteLine("Yukarı!");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Aşağı!");
                }
                else
                {
                    Console.WriteLine("Bildiniz!");
                    isFinished = true;
                }
            }
        }
    }
}
