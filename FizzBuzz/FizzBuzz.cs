namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string Say(int n)
        {
            string result = string.Empty;
            if (n % 3 == 0)
            {
                result += "Fizz";
            }
            if (n % 5 == 0)
            {
                result += "Buzz";
            }

            if (result != string.Empty)
            {
                return result;
            }

            return n.ToString();
        }
    }
}