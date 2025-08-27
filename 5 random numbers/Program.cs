namespace _5_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * what type of loops we need to use depending on
               the type of data we have? 
             * i need to make the user to give me 5 inputs using a loop
             * we are going to use for loop  or while loop
            */
            Console.WriteLine("hello beautiful enter 5 numbers: ");
            double sum = 0;
            bool IsValid = false;
            while (!IsValid)
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {

                        Console.WriteLine($"number {i + 1} is: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        sum += number;
                        IsValid = true;
                    }
                    double average = sum / 5.0;
                    Console.WriteLine($"Here is your summation result: {sum} ");
                    Console.WriteLine($"\nthis is average result: {average} ");
                }
                catch (Exception)
                {
                    Console.WriteLine("JUST NNNUMMBBEERRSSSS! ");
                }
            }
        }
    }
}
