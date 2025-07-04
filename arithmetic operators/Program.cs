namespace arithmetic_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // simple hypotenuse calculator program

            Console.WriteLine("Enter aide A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter aide B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The hypotenuse is: " + c);
            Console.ReadKey();
        }
    }
}
