class Program
{
    static void Main()
    {

        Console.Write("Enter upper bound number for fibonacci numbers: ");
        int upperBound = int.Parse(Console.ReadLine()!);
        
        for (int i = 0; ; i++)
        {
           int j = FibonacciNumber(i);
            if (j>upperBound)
            {
                break;
            }
            Console.WriteLine(j);
        }
      

        static int FibonacciNumber(int upperBound)
        {
            if (upperBound <= 1)
            {
                return upperBound;
            }

            return FibonacciNumber(upperBound - 1) + FibonacciNumber(upperBound - 2);
        }
    }
}            
