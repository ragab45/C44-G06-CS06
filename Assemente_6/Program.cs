namespace Assemente_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q-1
            //static void ByValue(int x)
            //{
            //    x = x + 10;
            //}

            //static void ByRef(ref int x)
            //{
            //    x = x + 10;
            //}

            //static void Main()
            //{
            //    int number = 5;
            //    ByValue(number);
            //    Console.WriteLine($"After ByValue: {number}");  // Output: 5

            //    ByRef(ref number);
            //    Console.WriteLine($"After ByRef: {number}");    // Output: 15
            //}
            #endregion
            #region  Q-2
            //    class MyClass
            //{
            //    public int Value;
            //}


            //    static void RefTypeByValue(MyClass obj) 
            //    {
            //        obj.Value = 10;       // Works
            //        obj = new MyClass();  // Only local change
            //        obj.Value = 99;
            //    }

            //    static void RefTypeByRef(ref MyClass obj)
            //    {
            //        obj = new MyClass();  // Changes original object
            //        obj.Value = 100;
            //    }

            //    static void Main()
            //    {
            //        MyClass a = new MyClass();
            //        RefTypeByValue(a);
            //        Console.WriteLine($"ByValue: {a.Value}");  // Output: 10

            //        RefTypeByRef(ref a);
            //        Console.WriteLine($"ByRef: {a.Value}");    // Output: 100

            #endregion
            #region Q-3


            //static void Main()
            //{
            //    Console.Write("Enter 4 numbers: ");
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    int c = int.Parse(Console.ReadLine());
            //    int d = int.Parse(Console.ReadLine());

            //    Calc(a, b, c, d, out int totalSum, out int totalDiff);
            //    Console.WriteLine($"Sum: {totalSum}, Difference: {totalDiff}");
            //}
            //static void Calc(int a, int b, int c, int d, out int sum, out int diff)
            //{
            //    sum = a + b;
            //    diff = c - d;
            //}
            #endregion
            #region  Q-4
            //static int SumDigits(int number)
            //{
            //    int sum = 0;
            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;
            //    }
            //    return sum;
            //}

            //static void Main()
            //{
            //    Console.Write("Enter a number: ");
            //    int num = int.Parse(Console.ReadLine());
            //    int result = SumDigits(num);
            //    Console.WriteLine($"The sum of the digits of {num} is: {result}");
            //}
            #endregion
            #region Q-5
            //static bool IsPrime(int num)
            //{
            //    if (num < 2) return false;

            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //            return false;
            //    }
            //    return true;
            //}

            //static void Main()
            //{
            //    Console.Write("Enter number: ");
            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
            //}
            #endregion
            #region Q-6
            //static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    min = max = arr[0];
            //    foreach (int x in arr)
            //    {
            //        if (x > max) max = x;
            //        if (x < min) min = x;
            //    }
            //}

            //static void Main()
            //{
            //    int[] numbers = { 4, 7, 1, 9, 3 };
            //    int min = 0, max = 0;

            //    MinMaxArray(numbers, ref min, ref max);
            //    Console.WriteLine($"Min = {min}, Max = {max}");
            //}
            #endregion
            #region Q-7
            static long Factorial(int n)
            {
                if (n <= 1) return 1;
                return n * Factorial(n - 1);
            }

            static void Main()
            {
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial of {n} is: {Factorial(n)}");
            }
            #endregion

        }
    }
    }
