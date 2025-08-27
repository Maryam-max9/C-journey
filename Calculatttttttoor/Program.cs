namespace Calculatttttttoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            double result = 0;
            bool restart = true;
            bool validOperation = true;
            while (restart)
            {
                restart = false;

                try
                {
                    ///NEW

                    Console.WriteLine("\n Hello and welcome to The calculator");
                    Console.WriteLine("    *********************************");

                    Console.WriteLine("\nEnter first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("\nEnter the operation: ");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                    switch (Console.ReadLine())
                {

                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($" Result is :{num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($" Result is :{num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($" Result is :{num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($" Result is :{num1} / {num2} = {result}");
                    break;
                        default:
                            validOperation = false;
                            break;
                }

                    if (!validOperation)
                    {
                        Console.WriteLine("I already gave you a generous amount of choices why are you doing that?");
                        Console.WriteLine("\nPress any key to restart ");
                        Console.ReadKey();
                        restart = true;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nEnter only numbers -_- "+e.Message);
                    Console.WriteLine("Press any key to restart ");
                    Console.ReadKey();
                    restart = true;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("\n why are you dividing by zero? IT IS NOT A THING ");
                    Console.WriteLine("Press any key to restart ");
                    Console.ReadKey();
                    restart = true;
                }
                

                Console.ReadKey();
            }
        }
    }
}
