using System.ComponentModel.Design;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace oop_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  core requirements  :.
             *   Planet class ( properties : name, size, distance from sun, has life), (Methods: Rotate, orbit)       DONE
             *  Star class (properties : name, temperature , brightness), (Methods: shine)                                   DONE
             *  Spaceship class (properties : name, fuel, speed), (Methods: lunch, travel to planet planet)         DONE
             *  Alien planet class *inherited from Space class* (Additional properties: Alien Species), (New Method: Communicate)   DONE
             *  Override (Rotate) with costume message      DONE
              
             *  Matrix Integration 
                      create distance  matrix  showing  travel distance between planets
             * List Operation
                     store planets in planet list 
                     use loops to simulate travel/rotation
            * Enhanced Interactions
                    Fuel consumption during travel
                   Random events using Random class (asteroid encounters) 
             */
            Planet controller = new Planet("Control Center", 0, 0, false);
            List<Planet> dummyList = new List<Planet>();
            controller.DisplayPlanetInfo(dummyList);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    public class Planet
    {
        public string Name { get; set; }        // properties
        public double Size { get; set; }
        public double DistanceFromSun { get; set; }
        public bool HasLife { get; set; }
     
        public Planet(string name, double size, double distanceFromSun, bool hasLife)  // constructor
        {
            Name = name;
            Size = size;
            DistanceFromSun = distanceFromSun;
            HasLife = hasLife;
        }
        public void DisplayPlanetInfo(List<Planet> Planets)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Welcome to the SPACE first section of our journey is going to be between PLANETS! 🚀🌍 ");
            Console.WriteLine("⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐");
            Console.WriteLine("Here is the List of Planets we're going to take you to!");

            List<Planet> PlanetList = new List<Planet>
            {
                new Planet("Mercury", 4879, 57.9, false),
                new Planet("Venus", 12104, 108.2, false),
                new Planet("Earth", 12760, 149.6, true),
                new Planet("Mars", 6779, 227.9, false),
                new Planet("Jupiter", 142984, 778.5, false),
                new Planet("Saturn", 116464, 1434, false),
                new Planet("Uranus", 50724, 2871, false),
                new Planet("Neptune", 49244, 4495, false),
                new AlienPlanet("Nebulons", "Proxima B", 14500, 4022, true),
                new AlienPlanet("Na'vi", "Pandora", 11447,  347,  true),
                new AlienPlanet("Xenomorphs", "Acheron LV-426", 12000, 432.9, true),
                new AlienPlanet("Fremen", "Arrakis", 12750, 401, true),
                new AlienPlanet("Time Lords", "Gallifrey", 45000, 2100, true),
            };
            try
            {
                for (int i = 0; i < PlanetList.Count; i++)
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    string LifeIndicator = PlanetList[i].HasLife ? "🌱" : "❌";
                    Console.WriteLine($"{PlanetList[i].Name} {LifeIndicator}");
                }
                Console.WriteLine($"\nEnter planet number (1 to {PlanetList.Count}) or 'all' to visit all planets AT ONCE: ");
                string input = Console.ReadLine()?.Trim().ToLower();
                if (string.IsNullOrEmpty(input))
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("You didn't type anything 🔪");
                    return;
                }
                if (input == "all")
                {
                    Console.WriteLine("\n____ Here is all the planets ____");
                    foreach (Planet planet in PlanetList)
                    {
                        PrintPlanetInfo(planet);
                    }
                    return;
                }
                if (int.TryParse(input, out int choice))
                {
                    if (choice >= 1 && choice <= PlanetList.Count)
                    {
                        PrintPlanetInfo(PlanetList[choice - 1]);
                    }
                    else
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine($"This is not one of the choices i displayed 🔪 enter one of these 1-{PlanetList.Count} or 'all' ");
                    }
                }
                else
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("You seem insisted to ruin my project 🔪 ENTER A NUMBER OR 'all' ");
                }
            }
            catch(Exception ex)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"🚨EEERROOOR: {ex.Message}");
            }
        }
        private void PrintPlanetInfo(Planet planet)
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine($"\"\U0001FA90 PLANET: {planet.Name.ToUpper()}");
            Console.WriteLine("====================================");
            Console.WriteLine($"• Size: {planet.Size:N0} km");
            Console.WriteLine($"• Distance from sun: {planet.DistanceFromSun:N1} million km");
            Console.WriteLine($"• Supports life: {(planet.HasLife ? "Yes 🌱" : "No ❌")}");
            if (planet is AlienPlanet alienPlanet)
            {
                Console.WriteLine($"• Alien species: {alienPlanet.AlienSpecies} 👽");
            }

            if (planet.Name.Contains("LV-426"))
            {
                Console.WriteLine("\n 💀 WARNING: Xenomorph infestation detected!");
            }
            else if (planet.Name == "Gallifrey")
            {
                Console.WriteLine("\n⏳ Homeworld of the Time Lords");
            }

            Console.WriteLine("====================================\n");
        }

        public virtual void Rotate()     // i added "virtual" to be able to override this method 
        {
            //in this method we're displaying how much dose a planet take to complete a hole rotate around itself
            Console.WriteLine("here we are going to display how much days every normal planet takes to complete a rotation");
            Console.WriteLine("==============================================");
            double rotationPeriod = Name switch
            {
                "Mercury" => 58.6,
                "Venus" => 243,
                "Earth" => 1,
                "Mars" => 1.03 ,
                "Jupiter" => 0.41 ,
                "Saturn" => 0.45 ,
                "Uranus" => 0.72 ,
                "Neptune" => 0.67,
                 _ => 0 // this is unknown planet
            };
            string rotationType;
            if (Name =="Venus")
            {
                rotationType = "backward (retrograde)";
            }
            else
            {
                rotationType = "forward";
            }
            Console.WriteLine($"\n🔄 {Name} completes one rotation in {rotationPeriod} Earth days " + $"{rotationPeriod * 24} hours), spinning {rotationType}!");
        }
        public void Orbit()
        {
            //here we are going to display how much dose it take to complete a hole Orbit around the sun
            double orbitalPeriodYears = Name switch
            {
                "Mercury" => 0.24,
                "Venus" => 0.62,
                "Earth" => 1.00,
                "Mars" => 1.88,
                "Jupiter" => 11.86,
                "Saturn" => 29.46,
                "Uranus" => 84.01,
                "Neptune" => 164.8,
                _ => 0
            };
            double orbitalPeriodDays = orbitalPeriodYears * 365.25 ;
            Console.WriteLine($"{Name} completes one orbit around the sun in " +
                      $"{orbitalPeriodYears} Earth years ({orbitalPeriodDays:N0} days)!");
        }
    }
    public class Star
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public double Brightness { get; set; }
        public Star(string name, double temperature, double brightness)
        {
            Name = name;
            Temperature = temperature;
            Brightness = brightness;
        }
        public void Shine()
        {
            Console.WriteLine($"✨ {Name} shines at {Temperature}K with {Brightness} luminosity!");
        }
    }
    public class Spaceship
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public double Speed { get; set; }
        public Spaceship(string name, double fuel, double speed)
        {
            Name = name;
            Fuel = fuel;
            Speed = speed;
        }
        public void Launch()
        {
            Console.WriteLine($"🚀 {Name} LAUNCH! Fuel: {Fuel}L, Speed: {Speed} km/h");
        }
    }
    public class AlienPlanet : Planet,ICloneable
    {
        public string AlienSpecies { get; set; }
        public AlienPlanet (string alienSpecies, string name, double size, double distanceFromSun, bool hasLife) : base ( name,  size,  distanceFromSun,  hasLife)
        {
            AlienSpecies = alienSpecies; 
        }
        public void Communicate()
        {
            if (Name == "Acheron LV-426")
                Console.WriteLine("📡 Hsssssssk! Krrrrch! (Hostile alien signals)");
            else if (Name == "Gallifrey")
                Console.WriteLine("📡 Time is relative! (Complex temporal patterns)");
            else
                Console.WriteLine("📡 Peaceful greetings from the stars!");
        }
        public override void Rotate()
        {
            base.Rotate(); // to display standard rotation first

            if (Name == "Acheron LV-426")
                Console.WriteLine("👽 Xenomorph-induced tectonic shifts cause irregular rotation!");
            else if (Name == "Gallifrey")
                Console.WriteLine("⏳ Time Lord technology stabilizes rotation precisely!");
            if (Name == "Acheron LV-426")
            {
                Console.WriteLine("👽 Xenomorph-induced tectonic shifts cause irregular rotation patterns!");
            }
            else if (Name == "Gallifrey")
            {
                Console.WriteLine("⏳ Time Lord technology stabilizes rotation at exactly 24 Gallifreyan hours!");
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
    
}
