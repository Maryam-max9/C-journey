namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            Calculate(num1, num2);
        }
        static void Calculate(int num1, int num2, char op)
        {
            int resul
            // calculate
            // print result
        }
        static int Add(int num1, int num2)
        {
            Console.WriteLine("Add");
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            Console.WriteLine("Subtract");
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiply");
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            Console.WriteLine("Divide");
            return num1 / num2;
        }
    }
}
