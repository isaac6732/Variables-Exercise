using System.Xml.Linq;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Declare and initializa variables
            string catName = "Panda";
            int catAge = 10;
            char middleInitial = 'O';
            bool heIsLazy = true;
            double weight = 13.12;
            decimal prices = 499.99m;

               // Console.WriteLine($"Cat Name: {catName}");
               //Console.WriteLine($"Cat Age: {catAge}");
               //Console.WriteLine($"Middle Initial: {middleInitial}");
               //Console.WriteLine($"He Is Lazy: {heIsLazy}");
               //Console.WriteLine($"Weight: {weight}");
               //Console.WriteLine($"Prices: {prices}");

            Console.WriteLine("Enter in your pet's name:");
            string petsName = Console.ReadLine();
           
            Console.WriteLine("Enter in your pet's age:");
            string petsAge = Console.ReadLine();
            
            Console.WriteLine("Enter in your pet's weight:");
            string petsweight = Console.ReadLine();


            Console.WriteLine("Thack you for the infomasion ");
            Console.WriteLine("Let's treat your animal well");
            
            Console.WriteLine(petsName);
            Console.WriteLine(petsAge);
            Console.WriteLine(petsweight);
        }

    }
}

