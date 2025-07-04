namespace i_still_don_t_know
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop repeats something in order to take 
            // any type of input from the user if not it's going to continue

            // Create an instance of the Random class
            //  Random random = new Random();

            // Generate a random number between 1 and 10 (inclusive)
            //   int randomNumber = random.Next(1, 11); // Note that the upper bound is exclusive

            // Output the random number
            // Console.WriteLine("Randomly chosen number: " + randomNumber);

            //  Console.ReadKey();


            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Shut uppppppppp");
            //Console.ReadKey();

            Console.Write("How many rows? :");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns? :");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();




        }
    }
}
