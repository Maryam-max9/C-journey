namespace _5_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
            
            int SumResult = num1 + num2 + num3 + num4 + num5;
            int AverageResult = SumResult / 5;
            int DividedBy = 5;
            Console.WriteLine("Hi our game is all about you entering 5 numbers and i will calculate the Average and the Sum of them ");
            Console.WriteLine("________________________________");

            Console.WriteLine("Enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3: "); 
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num4: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num5: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum for the numbers is:{num1} + {num2} + {num3} + {num4} + {num5} = {SumResult}");
            Console.WriteLine($"The Average for the numbers is:{SumResult} / {5} {AverageResult}");
           
          
        }
    }
}
