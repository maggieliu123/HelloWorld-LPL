using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;  // explicitly tell compiler to treat number as float not double
            char character = 'M';       // single quote for chars
            string firstName = "Maggie";
            bool isWorking = true;
            var general = 'H';
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
