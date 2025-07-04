namespace training
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("What is your name?");
            string x = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + x);
        static void MakeSomeGarabge()
        {
                Version v;
                for (int i = 0; i < 1000; i++)
                {
                    v = new Version();
                }
        }     
       }
    }
  //  public class Person
   // {
   //     public string name = "Maryam";
   //     public int age = 18;
    //}
   
}
