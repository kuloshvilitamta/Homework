namespace Discriminant_formula

{
    internal class Program
    {
        static void Main()
        {
            Discriminant d1 = new Discriminant();

            Console.Write("Enter value for A: ");
            d1.A = double.Parse(Console.ReadLine());

            Console.Write("Enter value for B: ");
            d1.B = double.Parse(Console.ReadLine());

            Console.Write("Enter value for C: ");
            d1.C = double.Parse(Console.ReadLine());

            double result = d1.FormulaDiscriminant();

            PrintEquation(d1, result);
            Console.WriteLine();
            d1.Roots();

        }
        static void PrintEquation(Discriminant d1, double result)
        {
            Console.WriteLine($"A={d1.A}");
            Console.WriteLine($"B={d1.B}");
            Console.WriteLine($"C={d1.C}");
            Console.WriteLine($"Discriminant = {result}");
        }
    }

    class Discriminant
    {
        private double _discriminant;
        private double _a;
        public double A
        {
            get { return _a; }
            set
            {

                while (value == 0)
                {
                    Console.WriteLine("You cannot use 0 here, please enter another number.");
                    int newValue = int.Parse(Console.ReadLine());

                    if (newValue != 0)
                    {
                        value = newValue;
                    }
                }
                _a = value;
            }
        }

        private double _b;
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        private double _c;
        public double C
        {
            get { return _c; }
            set { _c = value; }
        }
        public double FormulaDiscriminant()
        {

            _discriminant = (B * B) - (4 * A * C);
            return _discriminant;
        }


        public void Roots()
        {
            double x1;
            double x2;

            if (_discriminant > 0)
            {
                x1 = (-B + Math.Sqrt(_discriminant)) / (2 * A);
                x2 = (-B - Math.Sqrt(_discriminant)) / (2 * A);

                Console.WriteLine($"Two real roots: x1={x1},x2={x2}");
            }

            else if (_discriminant == 0)
            {
                x1 = -B / (2 * A);

                Console.WriteLine($"One real root: x={x1}");

            }
            else
            {
                Console.WriteLine($"There are no real Roots");
            }
        }
    }
}



