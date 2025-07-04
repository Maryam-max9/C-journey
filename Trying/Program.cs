using System.Threading.Channels;

namespace Trying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writing the game flow first
            // Forest -> (1) open chest -> Get reward -> (2) Run away -> Meet goblin;
            Console.WriteLine("Hello sir and welcome to your ULTIMATE game!");
            Console.WriteLine("How would you like to start your game?");
            Console.WriteLine("\n1. The Magical forest 🌳");
            Console.WriteLine("2. The Hot desert 🏜️");
            Console.WriteLine("3. The Refreshing sea 🌊");

            Console.Write("\nEnter your choice (1-3): ");
            string input = Console.ReadLine();
            Console.WriteLine($"\nYou selected option {input}! Let's begin...");
        }
        
    }
    
}   

//الفتره الجايه هتبق كلها تطبيق بس تعلم المزيد مع اهمال التطبيق ليس حلا