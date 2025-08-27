using System.Text;

namespace Methods
{
    internal class Program
    { 
        static void Main(string[] args)
        {

         Console.OutputEncoding = Encoding.UTF8;
            string name = "نورهان";//[ن , ]
            ///Console.WriteLine(new string(name.Reverse().ToArray()));
            Console.WriteLine("🎉 Welcome to the Emoji Console! 😀");
            Console.WriteLine("🔥 Let's code C# with fun! 🚀");

            bool IsValid = false; 
            while (!IsValid)
            {
                try
                {
                    
                    Program program = new Program();
                    Console.WriteLine("Hey if you wanna be greeted type your name: ");
                    Console.WriteLine("                       ");
                    program.GreetUser(Console.ReadLine());
                    IsValid = true;

                    (int a, int b) = program.GetUserInput();
                    int result = program.Add(a, b);
                    program.DisplayResult(result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Do NOT mess with me i said your NAME not bunch of numbers or chars!");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        ////public void GreetUser(string name)
        ////{

        ////    Console.WriteLine($"\nHello,{name}");

        ////////}
        public void GreetUser(string name)=>Console.WriteLine($"\nHello,{name}");
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public (int x, int y) GetUserInput()//Tuble
        {
            bool IsOk = false;
            while (!IsOk)
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    return (a, b);
                }
                catch (FormatException)
                {
                    Console.WriteLine("I said ONLY NUMBERS");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("you are messing with my program and that is not ok");
                }
            }
            return (0, 0);
        }
          
        public int Add (int a, int b)
        {
            return a + b;
            
        }
        public void DisplayResult(int result)=>        
            Console.WriteLine($"Sum result is: {result}");


        public int DisplayResultV2(int result) =>
          3;
    }
}
