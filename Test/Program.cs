using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Art_Gallery_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create 3 classes and 1 struct  first thing to do [DONE]
            // inherit 2 of the classes from the abstract one [DONE]
            //  fill with content [DONE]
            // make a list of choices + a choice gives a random pick [DONE]
            // handle exceptions [DONE]
            Console.WriteLine("Hey you do you wanna see some art? yes/no");
            bool Continue = true;
            while (Continue)
            {
                try
                {


                    string response = Console.ReadLine();
                    if (response.ToLower() == "yes")
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("\nAlright LET'S GO! we're going to my ✨Art Gallery 🏛️✨");
                    }
                    else if (response.ToLower() == "no")
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("Get out! 🔪 ");
                        return;
                    }
                    else
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("\nit is YES or NO why it is so hard to understand? 🔪");
                        Continue = false;
                        return;
                    }
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("\nThe list of things we can do💫");
                    Console.WriteLine("1. go to Painting section 🎨🖌️");
                    Console.WriteLine("2. hit Sculping section 🗿");
                    Console.WriteLine("3. Surprise me! 🌀");  // get a random choice
                    string Choice = Console.ReadLine();
                    GallerySection selectedArt = null;
                    Random random = new Random();
                    switch (Choice)
                    {
                        case "1":
                            selectedArt = new PaintingSection();
                            break;
                        case "2":
                            selectedArt = new SculptureSection();
                            break;
                        case "3":
                            int randomChoice = random.Next(1, 3); // 1 to 2
                            if (randomChoice == 1)
                                selectedArt = new PaintingSection();
                            else if (randomChoice == 2)
                                selectedArt = new SculptureSection();
                            Console.OutputEncoding = Encoding.UTF8;
                            Console.WriteLine("GET YOUR RANDOM PICK! 🎲");
                            break;
                        default:
                            Console.WriteLine("I swear i knew it i KNOW your intention is ruining my system 🔪");
                            Continue = false;
                            break;
                    }
                    if (selectedArt != null)
                    {
                        selectedArt.DisplayInfo();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("if i caught you trying to ruin my program one more time you're not going to like it  ☠️ 🔪");
                    Continue = false;
                }
                Console.ReadKey();
            }
        }
    }
    abstract class GallerySection   //  the abstracted class it's like our MAMA has a public method inside of it so we can call it when ever we need to display something's info
    {
        public abstract void DisplayInfo();
    }
     class PaintingSection : GallerySection  // first inherited class that displays only paintings 
     {
        public override void DisplayInfo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            (string title, string artist, int date) painting;
             painting = ("The Scream", "Edvard Munch", 1893);  // --> The Scream , Edvard Munch , 1893
            Console.WriteLine("Welcome to the ✨ painting ✨ section");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"\nPainting title 🎨 : {painting.title}");
            Console.WriteLine($"Artist name 🧑‍🎨 : {painting.artist}");
            Console.WriteLine($"Date of release 🗓️ : {painting.date}");

            painting = ("Prefer the Bump", "Maryam Elanani", 2025);
            Console.WriteLine($"\nPainting title 🎨 : {painting.title}");
            Console.WriteLine($"Artist name 🧑‍🎨 : {painting.artist}");
            Console.WriteLine($"Date of release 🗓️ : {painting.date}");

            painting = ("The Persistence of Memory", "Salvador Dali", 1931); // the same as her sister
            Console.WriteLine($"\nPainting title 🎨 : {painting.title}");
            Console.WriteLine($"Artist name 🧑‍🎨 : {painting.artist}");
            Console.WriteLine($"Date of release 🗓️ : {painting.date}");

            painting = ("Starry Night", "Vincent van Gogh", 1889);
            Console.WriteLine($"\nPainting title 🎨 : {painting.title}");
            Console.WriteLine($"Artist name 🧑‍🎨 : {painting.artist}");
            Console.WriteLine($"Date of release 🗓️ : {painting.date}");

            painting = ("Girl with a Pearl Earring", "Johnnes Vermeer", 1665);
            Console.WriteLine($"\nPainting title 🎨 : {painting.title}");
            Console.WriteLine($"Artist name 🧑‍🎨 : {painting.artist}");
            Console.WriteLine($"Date of release 🗓️ : {painting.date}");
        }
     }
    class SculptureSection : GallerySection // second one specialized in sculping 
    {
        public override void DisplayInfo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            (string name, string artist, int date) sculpture;
            sculpture = ("David", "Michelangelo", 1504);  // -->  David , Michelangelo , 1504
            Console.WriteLine("Welcome to the ✨ Sculping ✨ section");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"\nSculpture name 🗿 : {sculpture.name}");
            Console.WriteLine($"The artist 🧑‍🎨 : {sculpture.artist}");
            Console.WriteLine($"Date of release 🗓️ : {sculpture.date}");

            sculpture = ("The Thinker", "Auguste Rodin", 1904);
            Console.WriteLine($"\nSculpture name 🗿 : {sculpture.name}");
            Console.WriteLine($"The artist 🧑‍🎨 : {sculpture.artist}");
            Console.WriteLine($"Date of release 🗓️ : {sculpture.date}");

            sculpture = ("Venus de Milo", "Alexandros of Antioch", 130-100);  
            Console.WriteLine($"\nSculpture name 🗿 : {sculpture.name}");
            Console.WriteLine($"The artist 🧑‍🎨 : {sculpture.artist}");
            Console.WriteLine($"Date of release 🗓️ : {sculpture.date} BC");

            sculpture = ("Drowning", "Maryam Elanani", 2022);
            Console.WriteLine($"\nSculpture name 🗿 : {sculpture.name}");
            Console.WriteLine($"The artist 🧑‍🎨 : {sculpture.artist}");
            Console.WriteLine($"Date of release 🗓️ : {sculpture.date}");

            sculpture = ("Pieta", "Michelangelo", 1498-1499);
            Console.WriteLine($"\nSculpture name 🗿 : {sculpture.name}");
            Console.WriteLine($"The artist 🧑‍🎨 : {sculpture.artist}");
            Console.WriteLine($"Date of release 🗓️ : {sculpture.date}");
        }
    }
}
