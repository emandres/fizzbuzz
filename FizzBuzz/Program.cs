using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(FizzBuzz.Say(i + 1));
            }
        }
    }
}
