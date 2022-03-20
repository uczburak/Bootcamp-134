using System;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //elemanlar biliniyorsa
            string[] shoppingList = new string[] { "Elma", "Salatalık", "Domates" };
            Console.WriteLine($"ilk eleman: {shoppingList[0]}");
            Console.WriteLine($"array içindeki toplam eleman: {shoppingList.Length}");
            Console.WriteLine($"array içindeki son eleman: {shoppingList[shoppingList.Length-1]}");

            //elemanların kaç adet olacağı biliniyorsa
            string[] participants = new string[39];
            participants[0] = "Abdullah Halit";
            participants[1] = "Ahmad Hamdan";
            participants[37] = "Umut Oku";

            // 1-100 arasında verilen sayıyı sözel ifade olarak verme. E.g. 42 --> kırk iki

            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

            Console.WriteLine("1 ile 100 arasında bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int onlarBasamagi = number / 10;
            int birlerBasamagi = number % 10;

            Console.WriteLine($"{onlar[onlarBasamagi]} {birler[birlerBasamagi]}");

            List<string> anotherShopList = new List<string>();
            anotherShopList.Add("Peynir");
            anotherShopList.Add("Zeytin");
            anotherShopList.Add("Su");
        }
    }
}
