namespace CSharpMethodsEX1Console
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hi, What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"{favoriteColor} is such a beautiful color,");
            Console.WriteLine("What is your favorite kind of animal");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("Awesome!, Okay last question: What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Okay {userName}, here is a story that I made up using your responses:");
            Console.WriteLine($"One summer evening there was a {favoriteAnimal} named {userName}.");
            Console.WriteLine($"{userName} was a curious little guy and wanted to know how high he could fly");
            Console.WriteLine($"So he turned on some '{favoriteBand}', hopped in a {favoriteColor} rocket, and he took to the sky");

          
        }
    }
}