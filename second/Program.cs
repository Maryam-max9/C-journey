namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we r talking about type casting 
            // we can use convert.ToInt32 or "the data type we are converting from".parse 
            // for example string.parse 

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            int e = 321;
            string f = Convert.ToString(e);

            string g = "$";
            char k = Convert.ToChar(g);

            string l = "true";
            bool j = Convert.ToBoolean(l);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(k.GetType());
            Console.WriteLine(j.GetType());
            Console.ReadKey();
        }
    }
}
