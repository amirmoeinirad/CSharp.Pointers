
// Amir Moeini Rad
// August 13, 2025

// Main Concept: Pointers in C# (unsafe code)
// Pointers are used to directly access memory addresses when high performance is required (speed with large objects).

namespace Pointers
{
    internal class Program
    {
        // 'unsafe' keyword allows the use of pointers in C#
        // To compile this code, you need to enable unsafe code in your project settings.
        static unsafe void Main()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Pointers in C#.NET...");
            Console.WriteLine("---------------------\n");


            int a = 5;
            int b = 10;

            
            Console.WriteLine($"Before swapping: a = {a}, b = {b}");


            // Use pointers to swap values            
            // '*' is used to declare a pointer type. 'ptrA' is a pointer to an int.
            // '&' is used to get the address of a variable. '&' is called "address of" operator.
            int* ptrA = &a;
            int* ptrB = &b;


            // '*' is used to dereference a pointer, which means accessing the value at the address stored in the pointer.
            int temp = *ptrA;
            *ptrA = *ptrB;
            *ptrB = temp;
            

            Console.WriteLine($"After swapping:  a = {a}, b = {b}");


            Console.WriteLine("\nDone.");
        }
    }
}
