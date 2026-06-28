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
            Console.WriteLine("Hello, World!");
            //Console.Write("MSP");

            //data type   variable name
            //int ,  long, double ,float ,decimal 10.43243245454 ,bool = true , false
            // char
            //char n = 'f';
            //int         x              = 10;
            //string y = "Hello, World!"; // Store address (Pointer) at stack and the actual content at heap because it is an obj

            //string firstName = "Youssef";
            //string lastName = "Mohmed";

            //string fullName_1 = $"The full name is {firstName} {lastName}"; // Interpolation
            //string fullName_2 = firstName + " " + lastName; // Concatenation

            //Console.WriteLine(fullName_1);
            //Console.WriteLine(fullName_2);

            //// The Implicit Engine : The Compiler analyzes the right side of the expression and
            //// convert it to the right data type at compiletime

            var z = 10;
            Console.WriteLine(z);

            //// Dynamic Keyword : Determination of the data type to the variable is at Runtime

            //int a = 5;
            //a = "text"; // Error

            dynamic a = 5;
            a = "text"; // OK
            a = true;   // OK

            //// Operators

            int sum = 2 + 3;
            int sub = 3 - 2;
            int div = 4 / 2;
            int mul = 4 * 2;
            int power = 4 ^ 2;

            //// Logical Operators
            bool flag = true && false;
            flag = true || false;
            flag = !true;

            ////XOR
            flag = false ^ true;
            //// true ^ true => false
            //// true ^ false => true
            //// false ^ true => true
            //// false ^ false => false

            //// Comparison Operators
            //flag = 1 == 0;
            //flag = 1 != 0;
            //flag = 1 > 0;
            //flag = 1 >= 0;
            //flag = 1 < 0;
            //flag = 1 <= 0;

            double gpa = 4.1;
            string university = "Helwan";
            bool IsAccepted = (gpa < 4.0 && gpa > 3.4) || university == "Cairo";
            Console.WriteLine(IsAccepted);

            //(user != null || fun(user))

            //// Explain Short Circuit Concept
            flag = true || false;// => true direct without complete exp
            flag = false && true;// => false direct without complete exp
            // Standard Bitwise Logical (| - &) =>> force to complete the exp




        }
    }
}
