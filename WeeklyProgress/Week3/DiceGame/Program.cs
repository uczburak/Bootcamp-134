using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Oyunda İki Oyuncu olacak
            * Her bir oyuncuda iki adet zar olacak
            * Oyuncular sırasıyla zar atar
            * Zarlar karşılaştırılır
            * Büyük atan kazanır
            */
            do
            {


                Game game = new Game();
                game.PlayerOne = new Player { Name = "Türkay Ürkmez" };
                game.PlayerTwo = new Player { Name = "Ahmet Necdet" };
                game.PlayAndTurn();
                game.ShowWinner();
                Console.WriteLine("Oyunu bitirmek ister misin?");
            } while (Console.ReadLine() != "E");

        }
    }
}
