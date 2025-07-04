namespace User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("What are you going to do in your vacation?");
            string Answer = Console.ReadLine();
            Console.WriteLine("This seems interesting!");

            Console.WriteLine("Ok what about your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So you are " + age + " Years old");

            Console.ReadKey();
        }
    }
}
