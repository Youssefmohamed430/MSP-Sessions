/*
                         ========>>>>> TO DO: <<<<<<========

    1. Explain Project Structure and Files
    2. The Difference between App Project and Class Library Project.
    3. The Isolation between the projects at the same solution.
    4. Explain How Namespaces work in C# and how to use them to avoid naming conflicts.
    5. Explain Why Using Namespaces is Important in Large Projects and How it Helps in Organizing Code.
    6. The place to store variables
    7. Explain Structure of create variable 
    8. Value Type (Stack,int) VS Reference Type (Heap,string,class)
    9. Data Types (int, string, bool, float, double, decimal, struct, enum)
    10.String operations 
 */

using System;

namespace Session_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = s1;

            s2 = "World";

            Console.WriteLine(s1);
        }
    }
}
