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
            class MyClass
        {
            public int Value;
        }

        
            static void RefTypeByValue(MyClass obj) 
            {
                obj.Value = 10;       // Works
                obj = new MyClass();  // Only local change
                obj.Value = 99;
            }

            static void RefTypeByRef(ref MyClass obj)
            {
                obj = new MyClass();  // Changes original object
                obj.Value = 100;
            }

            static void Main()
            {
                MyClass a = new MyClass();
                RefTypeByValue(a);
                Console.WriteLine($"ByValue: {a.Value}");  // Output: 10

                RefTypeByRef(ref a);
                Console.WriteLine($"ByRef: {a.Value}");    // Output: 100
            
            #endregion
        }
    }
}
