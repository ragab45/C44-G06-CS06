namespace Assemente_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q-1
            static void ByValue(int x)
            {
                x = x + 10;
            }

            static void ByRef(ref int x)
            {
                x = x + 10;
            }

            static void Main()
            {
                int number = 5;
                ByValue(number);
                Console.WriteLine($"After ByValue: {number}");  // Output: 5

                ByRef(ref number);
                Console.WriteLine($"After ByRef: {number}");    // Output: 15
            }
            #endregion

        }
    }
}
