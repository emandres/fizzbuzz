namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string Say(int n)
        {
            string result = string.Empty;
            if (IsFizz(n))
            {
                result += "Fizz";
            }
            if (IsBuzz(n))
            {
                result += "Buzz";
            }

            if (result != string.Empty)
            {
                return result;
            }

            return n.ToString();
        }

        private static bool IsFizz(int n)
        {
            return n % 3 == 0 || n.ToString().Contains("3");
        }

        private static bool IsBuzz(int n)
        {
            return n % 5 == 0 || n.ToString().Contains("5");
        }
    }
}