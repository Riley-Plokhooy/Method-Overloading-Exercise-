namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo) 
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo) 
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isMoney) 
        {
            var sum  = numOne + numTwo;


            if (isMoney && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isMoney && sum == 1)
            {
                return $"{sum} dollar";
            }
            else 
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args) 
        {
            Console.WriteLine(Add(2, 2, true));
        }
        
    }
}
