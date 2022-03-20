using System;
using System.Collections.Generic;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            products.Add("Samsung");
            products.Add("Xiaomi");
            products.Add("Oppo");
            products.Add("Iphone");
            products.Add("Ibilmemne");

            List<string> storage = new List<string>();

            foreach (string product in products)
            {
                Console.WriteLine(product);
                if (product.StartsWith("I"))
                {
                    storage.Add(product);
                }
            }

            foreach (string item in storage)
            {
                products.Remove(item);
            }

            Console.WriteLine("Son hali: ");
            Console.WriteLine("-----------------");

            foreach (string product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
