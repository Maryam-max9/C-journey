namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coding");
            Console.Write(" Is magical");
            //this is not the first time i write a code btw
            Console.WriteLine("\nWith me");

            int age; //declaration
            age = 84; //initialization

            int Random = 0918384; //declaration + initialization

            int concatenation = age + Random;

            bool alive = false;

            char symbol = '@';

            Console.WriteLine("\n" + age);
            Console.WriteLine(Random);
            Console.WriteLine(concatenation);
            Console.WriteLine("\nYour Age is " + age);
            Console.WriteLine("The Random Number YOU Asked For Is " + Random);
            Console.WriteLine("The Concatenation Of Your Name And The Random Number Is " + concatenation);
            Console.WriteLine("\nAre YOU Alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.ReadKey();
        }
    }
}
