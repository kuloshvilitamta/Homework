namespace G10_20251125
{
    internal class Program
    {
        static void Main()
        {
            string?[] names = { "Alice", "Bob", "Charlie" };
            Resize(ref names, 4);
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names[{i}] = {names[i] ?? "(null)"}");
            }
        }

        static void Resize(ref string?[] array, int newLength)
        {
            if(newLength < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newLength), "New length must be non-negative.");
            }

            if (array.Length == newLength)
            {
                return;
            }

            string?[] newArray = new string?[newLength];
            int length = array.Length < newLength ? array.Length : newLength;
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
