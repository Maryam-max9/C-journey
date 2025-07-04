using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace is_it_a_leap_year_or_not_question_mark
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello my user this small program is designed to determine if a year is leap or not");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("IS IT A LEAP YEAR OR NOT That is what we are about to discover NOW!");
            Console.WriteLine("-------------------------------");
            
            bool restart = true;
            int Year = 0;
            
            while (restart)
            {
                bool IsValidInput = false;
                
                while (!IsValidInput)
                {
                    try
                    {
                        Console.WriteLine("Enter a 4-digit year: ");
                        string input = Console.ReadLine();

                        if (input.Length != 4)
                        {
                            throw new FormatException("The year must be exactly 4 digits");
                        }

                        Year = Convert.ToInt32(input);
                        IsValidInput = true;

                        if (Year % 400 == 0)
                        {
                            Console.WriteLine("Yes it is a leap year");
                        }
                        else if (Year % 100 == 0)
                        {
                            Console.WriteLine("Not a leap year");
                        }
                        else if (Year % 4 == 0)
                        {
                            Console.WriteLine("Yes it's a leap year");
                        }
                        else
                        {
                            Console.WriteLine("Not a leap year");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("I said a 4-digit year ");
                    }
                }
            }
        }  
    }
}