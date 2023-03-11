using System.Text.Json;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many dog records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Dog>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myDog = new Dog();

                Console.WriteLine("Enter the dog's name:");
                myDog.Name = Console.ReadLine();
                Console.WriteLine("Enter the dog's age in years:");
                myDog.AgeYears = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dog's breed:");
                myDog.DogBreed = Console.ReadLine();
                Console.WriteLine("Enter how many years the dog has been owned:");
                myDog.YearsOwned = int.Parse(Console.ReadLine());

                recordList.Add(myDog);
            }


            // Print out the list of records using Console.WriteLine()
            Console.WriteLine("All dog records you have entered: ");
            foreach (var myDog in recordList)
            {
                Console.WriteLine(JsonSerializer.Serialize(myDog));
            }

        }
    }
}