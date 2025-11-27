class Program
{
    static void Main()
    {
        Console.Write("Please enter number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = Factorial(number);

        Console.WriteLine($"Factorial of {number} is {result}");

        static int Factorial(int n)
        {
            int result = 1;

            if (n < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Factorial cannot be Negative.");
            }
            if (n > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Number's factorial exceeds int limit");
            }
            if (n > 1)
            {
                result = n * Factorial(n - 1);
            }

            return result;
        }
    }
}
