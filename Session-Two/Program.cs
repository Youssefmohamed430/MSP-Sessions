/*
                         ========>>>>> TO DO: <<<<<<========

    
 */

using System;

namespace Session_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = new string[5]; // ==> Explicit Size    

            //string[] y = {"Hello", "World", "from", "C#"}; // ==> Implicit Size
            //Console.WriteLine(y.Length);

            //string[] z = new string[] {"Hello", "World", "from", "C#"}; // ==> Implicit Size

            //Console.WriteLine(y[0]);
            //y[0] = "Hi";
            //Console.WriteLine(y[0]);

            //x[0] = "Hello";
            //Console.WriteLine(x[0]);

            ////Extracting Sub Array from an Array
            //string[] subArray = new string[2];
            //subArray = y[1..3]; // C# 8.0 Range Operator
            //Console.WriteLine(string.Join(", ", subArray));

            //// Multi-Dimensional Array
            //int[,] multiDimensionalArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(multiDimensionalArray[1, 2]); // Output: 6
            ///*
            //               0  1  2

            // *          0  1  2  3
            // *          1  4  5  6
            // */


            ////Jagged Array
            //int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 4, 5 };
            //Console.WriteLine(jaggedArray[1][1]); // Output: 5
            //Console.WriteLine(jaggedArray[1][2]); // Output: IndexOutOfRangeException

            /*
                           0  1  2
                            
             *          0  1  2  3
             *          1  4  5  
             */

            // Statements 

            //   1. IF Else Statement

            //double GPA = 3.2;
            //string university = "Helwan";
            //string AIGrade = "A";

            //if (GPA > 3.0 && university == "Helwan")
            //{
            //    Console.WriteLine("Accepted");
            //}
            ////else if(AIGrade == "A" || AIGrade == "A+")
            ////{
            ////    Console.WriteLine("Accepted at AI Department");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Accepted");
            ////}

            //  2. Switch Statement

            /*
             * Switch Statement
             * Syntax:
                switch (expression) ==> expression : It is used to evaluate the value of a variable or an expression and compare it against different cases.
                {
                    case value1: ==> case : It is used to define a specific value that the expression can match. If the expression matches this value, the code block associated with this case will be executed.
                        // Code
                        break; ==> break : It is used to exit the switch statement after executing the code block for a specific case. If you don't include a break statement, the program will continue to execute the code for the next case(s) until it encounters a break or reaches the end of the switch statement.

                    case value2:
                    case value3: ==> case value2 and case value3 : You can have multiple cases that share the same code block. If the expression matches any of these values, the same code block will be executed.
                        // Code
                        break;

                    default: ==> default : It is an optional case that will be executed if none of the specified cases match the value of the expression. It acts as a fallback option.
                        // Code
                        break;
                }
             */

            //string department = "AI";

            //switch(department)
            //{
            //    case "AI":
            //        Console.WriteLine("Accepted at AI Department");
            //        break;
            //    case "CS":
            //        Console.WriteLine("Accepted at CS Department");
            //        break;
            //    default:
            //        Console.WriteLine("Not Accepted");
            //        break;
            //}


            // Anoter Syntax of Switch Statement in C# 8.0 and later versions using switch expressions
            //int number = 2;

            //string result = number switch
            //{
            //    1 => "One",
            //    2 => "Two",
            //    3 => "Three",
            //    _ => "Unknown"
            //};

            //Console.WriteLine(result);


            // 3. Ternary Operator
            //string Flag = GPA > 3.0 && university == "Helwan" ? "Accepted" : "Not Accepted";

            // 4. Loops Operators

            // Why are we using loops?


            /*    
                  1. For Loop
                      1.1 For Loop Syntax
                      for (initialization; condition; increment/decrement)
                      {
                          // Code to be executed
                      }
                   2. While Loop
                      2.1 While Loop Syntax
                      while (condition)
                      {
                          // Code to be executed
                      }
                   3. Do-While Loop
                      3.1 Do-While Loop Syntax
                      do
                      {
                            // Code to be executed
                      } while (condition);
                   4. Foreach Loop
                        4.1 Foreach Loop Syntax
                        foreach (type variable in collection)
                        {
                            // Code to be executed
                        }
            */
            // Examples: 
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"For Loop Iteration: {i}");
            //}

            //int j = 0;
            //while (j < 5)
            //{
            //    Console.WriteLine($"While Loop Iteration: {j}");
            //    j++;
            //}

            //int k = 0;
            //do
            //{
            //    Console.WriteLine($"Do While Loop Iteration: {k}");
            //    k++;

            //} while (k < 5);

            //string word = "Hello";
            //foreach(var w in word)
            //{
            //    Console.WriteLine(w);
            //}


            // Null Safe Operator
            //string? name = null;
            //// Null Coalescing Operator
            //string message = name?.ToUpper() ?? "Name is null";

            //// Casting
            //int num = 10;
            //long bignum = num; // Implicit Casting (Automatic)
            //int smallnum = (int)bignum; // Explicit Casting possible data loss

            // Boxing and Unboxing
            //int value = 42;
            //object boxedValue = value; // Boxing
            //int unboxedValue = (int)boxedValue; // Unboxing

            // Operator to check casting

            //object obj = "Hello";

            //if (obj is string)
            //{
            //    Console.WriteLine("It's String");
            //}

            // [ as ] operator to convert types but for reference types only

            //object obj = "Hello";

            //string text = obj as string;

            //if (text != null)
            //{
            //    Console.WriteLine(text);
            //}

            // Parsing is converting [ String -> Data Type ]

            //string s = "25";

            //int x = int.Parse(s);

            //int.Parse("ABC"); // ==>> FormatException

            //double d = double.Parse("5.75");

            //DateTime date = DateTime.Parse("2025-06-01");

            // Try Parse : is a safer way to convert strings to data types without throwing exceptions

            //string s = "100";
            //string s = "ABC";

            //if (int.TryParse(s, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            // Converting Data Types using Convert Class

            //string s = "15";

            //int x = Convert.ToInt32(s);
            //double d = Convert.ToDouble("5.5");
            //bool b = Convert.ToBoolean("true");
            //char c = Convert.ToChar("A");
            //int x = 15;
            //string s = Convert.ToString(x);

            // The difference between Convert.ToString() and Parseing
            //string s = null;

            //Convert.ToInt32(s);   // 0
            //int.Parse(s); // throw exception if s is null


        }
    }
}
