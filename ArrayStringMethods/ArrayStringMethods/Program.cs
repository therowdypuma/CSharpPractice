using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStringMethods
{
    class Program
    {
        private static void myMethod()     // Void No Return Method
        {
            Console.WriteLine("This is My Method");
        }

        private static int returnNumber() // Integer Retun Method
        {
            return 20;
        }

        private static int squareNumber(int num) // Method with argument
        {
            return num * num;
        }

        private static int sumNumbers(int x, int y, int z)
        {
            return x + y + z;
        }

        private static int sumNumbers(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //// Arrays in C-Sharp

            ////Declarations
            //int[] ArrayInit1 = new int[5];
            //int[] ArrayInit2 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] ArrayInit3 = { 6, 7, 8, 9, 10 };

            //Console.WriteLine(ArrayInit2[2]); // Accesssing elemts using the index {Starts from zero}

            //Console.WriteLine("Enter Values in Array");
            //for (int indexer = 0; indexer < ArrayInit1.Length; indexer++) // Input in Array
            //{
            //    ArrayInit1[indexer] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nHere are values of Array 1\n");
            //foreach (var valueHolder in ArrayInit1)      // Output from Array
            //{
            //    Console.Write($"{valueHolder}\t");
            //}

            //Console.WriteLine("\nHere are values of Array 2\n");
            //foreach (var valueHolder in ArrayInit2)      // Output from Array
            //{
            //    Console.Write($"{valueHolder}\t");
            //}

            //Console.WriteLine("\nHere are values of Array 3\n");
            //foreach (var valueHolder in ArrayInit3)      // Output from Array
            //{
            //    Console.Write($"{valueHolder}\t");
            //}
            //Console.WriteLine("\n\n");


            //// Array Methods
            //Console.WriteLine($"\nAvg of Array1\t{ArrayInit1.Average()}");
            //Console.WriteLine($"\nMax in Array2\t{ArrayInit2.Max()}");
            //Console.WriteLine($"\nMin in Array3\t{ArrayInit3.Min()}");
            //Console.WriteLine($"\nSum of Array1\t{ArrayInit1.Sum()}");
            //Console.Read();

            //// 2-D Arrays

            //int[,] arr2d = new int[3, 2]{
            //                                {1, 2},
            //                                {3, 4},
            //                                {5, 6}
            //                            };
            //int arrayItem = arr2d[2,1];
            //Console.WriteLine(arrayItem);
            //Console.Read();


            //// Strings in C-Sharp
            
            //string str1 = @"C\Pumagodstylin\C-Sharp Practice\ArrayStringMethods.sln"; // Use '@' To Escape Sequences
            //string str2 = "Heelo Puma \" haha"; // Escape Characters using '/'
            //int strlen = str1.Length;
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine($"Length of String 1 is {strlen}");
            //Console.Read();


            // Methods or Functions in C-Sharp

           
            //myMethod();
            //int aNumber = returnNumber();
            //Console.WriteLine(aNumber);
            //int number = squareNumber(4);
            //Console.WriteLine(number);

            //Console.WriteLine(sumNumbers(4, 5, 6));
            //Console.WriteLine(sumNumbers(4, 5)); // Method Overloading
            
            //Console.Read();



        }
    }
}
