namespace looooooooooooops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age == 18)
            {
                Console.WriteLine("You are signed up!");
            }
            else if (age >= 70)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age <= 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18 and up try it again when your older");
            }


            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name == " ")
            {
                Console.WriteLine("You didn't enter your name enter iittt!");
            }
            else
            {
                Console.WriteLine("you have such a pretty name!");
            }

            Console.WriteLine("Did you enter it ? (true/false) ");
            string UserInput = (Console.ReadLine());
            bool yes;
            if (bool.TryParse(UserInput, out yes))
            {
                if (yes)
                {
                    Console.WriteLine("good person *_*");
                }

            }
            if (!yes)
            {
                Console.WriteLine("You seem to need a punishment");
            }



            Console.ReadKey();
        }
    }
}
