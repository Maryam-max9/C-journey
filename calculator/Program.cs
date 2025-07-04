namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;


            Console.WriteLine("===========");
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("===========");

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"The result : {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"The result : {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"The result : {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"The result : {num1} / {num2} = " + result);
                    break;

            }
            Console.WriteLine("\n Say thank you that i gave you the permission to use my calculator *_*");
            Console.WriteLine("\n Would you say thank you?");
            Console.ReadLine();
            Random random = new Random();
            bool condition = random.Next(0, 2) == 0; // Randomly sets condition to true or false

            if (condition)
            {
                Console.WriteLine("good girl/boy");
            }
            else
            {
                Console.WriteLine("you have to check your mental health Don't use my calculator again, it is not made for your type of creatures");
            }

            Console.ReadKey();
        }
    }
}
