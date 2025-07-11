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
            // This is a method designed to swap two integer values.
            // Note: In C#, for value types like int, passing by value means
            // the original variables outside this method will not be swapped
            // unless 'ref' or 'out' keywords are used. This example demonstrates
            // swapping within the scope of the method.
        public static void Swap(int A, int B)
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Before Swapping [Inside] => A => {A}, B => {B}");

            // The tooltip in the image explains 'Int32' which is the underlying
            // type for 'int' in C#, representing a 32-bit signed integer.

            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine("=================== After Swapping [Inside] ===================");
            Console.WriteLine($"A => {A}, B => {B}");
            #endregion // This #endregion seems to be misplaced or ending a region that started within the method.
            // Usually, regions encompass larger blocks of code.
        }

        static void Main(string[] args)
        {
            #region Functions

            // These lines are commented out, likely from previous examples
            // related to the PrintShape method.
            //PrintShape(shape: "%", count: 30);
            //PrintShape("$");

            int X = 10, Y = 20;

            Console.WriteLine("=================== Before Swapping [Outside] ===================");
            Console.WriteLine($"X => {X}, Y => {Y}"); // This line is partially visible in the image.

            Swap(X, Y); // Calling the Swap method.
                        // As X and Y are value types, their values in Main
                        // will not change after this call.

            #endregion
#endregion
        }
    }
}
