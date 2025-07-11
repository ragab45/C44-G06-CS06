namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V-1
            //    // This commented-out loop seems to be from an earlier part of the code,
            //    // possibly illustrating a simple loop before introducing methods.
            //    // for (int i = 0; i < 10; i++)
            //    // {
            //    //     Console.WriteLine("$");
            //    // }

            //    // Definition of the PrintShape method
            //public static void PrintShape(string shape, int count = 10)
            //{
            //    // The #endregion here implies a #region above this method,
            //    // perhaps for "Array Methods" or a general "Methods" section,
            //    // but it's not visible in this image.
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine(shape);
            //    }
            //} // This closing brace seems to be for the PrintShape method.

            //static void Main(string[] args)
            //{
            //    #region Functions // This region clearly indicates the start of function calls or demonstrations.

            //    // Calling the PrintShape method.
            //    // The commented-out line suggests an example call:
            //    // PrintShape(shape: "%", count: 30); // This line is commented in the image.

            #endregion
            #region  V-2
            //    // This is a method designed to swap two integer values.
            //    // Note: In C#, for value types like int, passing by value means
            //    // the original variables outside this method will not be swapped
            //    // unless 'ref' or 'out' keywords are used. This example demonstrates
            //    // swapping within the scope of the method.
            //public static void Swap(int A, int B)
            //{
            //    Console.WriteLine("===================");
            //    Console.WriteLine($"Before Swapping [Inside] => A => {A}, B => {B}");

            //    // The tooltip in the image explains 'Int32' which is the underlying
            //    // type for 'int' in C#, representing a 32-bit signed integer.

            //    int temp = A;
            //    A = B;
            //    B = temp;

            //    Console.WriteLine("=================== After Swapping [Inside] ===================");
            //    Console.WriteLine($"A => {A}, B => {B}");
            //    #endregion // This #endregion seems to be misplaced or ending a region that started within the method.
            //    // Usually, regions encompass larger blocks of code.
            //}

            //static void Main(string[] args)
            //{
            //    Functions

            //    // These lines are commented out, likely from previous examples
            //    // related to the PrintShape method.
            //    //PrintShape(shape: "%", count: 30);
            //    //PrintShape("$");

            //    int X = 10, Y = 20;

            //    Console.WriteLine("=================== Before Swapping [Outside] ===================");
            //    Console.WriteLine($"X => {X}, Y => {Y}"); // This line is partially visible in the image.

            //    Swap(X, Y); // Calling the Swap method.
            //                // As X and Y are value types, their values in Main
            //                // will not change after this call.

            //    
            #endregion
            #region  V-3
            public static int SumArray(int[] array)
        {
            // Prints the hash code of the array before processing.
            // The hash code is a unique identifier for the object in memory.
            Console.WriteLine($"Before HashCode [Inside] => {array.GetHashCode()}");

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; // Adds each element of the array to the sum.
            }

            // Prints the hash code of the array after processing.
            // It should be the same as before, indicating it's the same array object.
            Console.WriteLine($"After HashCode [Inside] => {array.GetHashCode()}");
            // Prints the first item of the array from inside the method.
            Console.WriteLine($"Item Inside => {array[0]}");

            return sum; // Returns the calculated sum.
        }

        static void Main(string[] args)
        {
            //Functions

            // These lines are commented out, likely from previous examples
            // related to PrintShape and Swap methods.
            //PrintShape(shape: "%", count: 30);
            //PrintShape("$");
            //int X = 10, Y = 20;
            //Console.WriteLine("=================== Before Swapping [Outside] ===================");
            //Console.WriteLine($"X => {X}, Y => {Y}");
            //Swap(ref X, ref Y); // This line is commented out, but shows a call to a Swap method with 'ref'.

            // The image ends here, implying that the Main method would call SumArray
            // with an array as an argument in the next steps of the tut
            #endregion

            #region  V-4
            // These lines are commented out, likely from previous examples
            // related to the Swap method and array passing.
            //Console.WriteLine("===== After Swapping [Outside] =====");
            //Console.WriteLine($"X => {X}, Y => {Y}"); // Assumes X and Y were defined earlier

            // These lines are commented out, likely related to the SumArray method.
            //int[] numbers = { 5, 7, 8 };
            //Console.WriteLine($"Before HashCode [Outside] => {numbers.GetHashCode()}");
            //int result = SumArray(ref numbers); // Note: 'ref' would be needed if SumArray modified the array reference, but for passing an array, 'ref' isn't strictly necessary for the array contents to be modified by the method.
            //Console.WriteLine($"After HashCode [Outside] => {numbers.GetHashCode()}");
            //Console.WriteLine($"Result [Outside] => {result}");
            //Console.WriteLine($"Item [Outside] => {numbers[0]}");

            int X = 10, Y = 20, sum, multi; // Declares X, Y, sum, and multi variables.

            // Calls a method named SumMulti.
            // It passes X and Y by value, and 'sum' and 'multi' by 'out' keyword.
            // The 'out' keyword means that the SumMulti method is responsible for
            // assigning a value to 'sum' and 'multi' before returning.
            SumMulti(X, Y, out sum, out multi);

            // This line is commented out, suggesting that 'sum' might have been intended
            // to be used or printed, but 'multi' is being printed.
            //Console.WriteLine(sum);
            Console.WriteLine(multi); // Prints the value assigned to 'multi' by the SumMulti method.

            #endregion

        }
    }
}
