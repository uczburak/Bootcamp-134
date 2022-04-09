using System;

namespace ClassVsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person trainerOfBootcamp = new Person();
            trainerOfBootcamp.Name = "Türkay";
            trainerOfBootcamp.LastName = "Ürkmez";
            trainerOfBootcamp.Salary = 100000;

            Person cooker = new Person();
            cooker.Name = "Sebahat";
            cooker.LastName = "Kırmızıtaş";

            Person student1 = new Person();
            student1.Name = "Ahmet Arslan";

            Person student2 = student1;
            student2.Name = "İrem Derici";

            Console.WriteLine(student1.Name);
            Console.WriteLine(trainerOfBootcamp.LastName);
        }
    }
}
