using System.Security.Cryptography.X509Certificates;

namespace Arrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Single-dimensional array
             * 
             * Compute the powers of two with exponents
             * ranging from 0 to 31
             * 
             */

            // Instantiate and fill the array with the
            // powers of two
            ulong[] powersOfTwo_SingleDimensional = new ulong[32];

            for (int i = 0; i < powersOfTwo_SingleDimensional.Length; i++)
            {
                powersOfTwo_SingleDimensional[i] = (ulong)Math.Pow(2, i);
            }

            // Write the powers of two to the console
            Console.WriteLine("Powers of Two - From a Single-Dimensional Array");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            int exponenet = 0;

            foreach (ulong result in powersOfTwo_SingleDimensional)
            {
                if (exponenet < 10)
                {
                    // Add one extra space before the exponent to
                    // align the output
                    Console.Write($"Exponenet:  {exponenet} -- ");
                    Console.Write(powersOfTwo_SingleDimensional[exponenet]);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"Exponenet: {exponenet} -- ");
                    Console.Write(powersOfTwo_SingleDimensional[exponenet]);
                    Console.WriteLine();
                }

                exponenet++;
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
             * 
             * Two-dimensional array
             * 
             * Compute the powers of two with exponents
             * ranging from 0 to 31
             * 
             */

            // Instantiate and fill the array with the
            // powers of two
            ulong[,] powersOfTwo_TwoDimensional = new ulong[32, 2];

            for (int i = 0; i < 32; i++)
            {
                powersOfTwo_TwoDimensional[i, 0] = (ulong)i;
                powersOfTwo_TwoDimensional[i, 1] = (ulong)Math.Pow(2, i);
            }

            // Write the powers of two to the console
            Console.WriteLine("Powers of Two - From a Two-Dimensional Array");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 32; i++)
            {
                if (powersOfTwo_TwoDimensional[i,0] < 10)
                {
                    // Add one extra space before the exponent to
                    // align the output
                    Console.Write($"Exponenet:  {powersOfTwo_TwoDimensional[i, 0]} -- ");
                    Console.Write(powersOfTwo_TwoDimensional[i, 1]);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"Exponenet: {powersOfTwo_TwoDimensional[i, 0]} -- ");
                    Console.Write(powersOfTwo_TwoDimensional[i, 1]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            /*
            * 
            * Jagged array
            * 
            * Build a jagged array where each array in the
            * jagged array contains the numbers in successive
            * rows of Pascal's Triangle
            * 
            */

            // Instantiate and fill the array with the
            // arrays of numbers from each row of 
            // Pascal's Triangle
            int[][] pascalsTriangle = new int[10][];

            // nCr = n! / ((n - r)! * r!)
            for (int n = 0; n < 10; n++)
            {
                int[] pascalRow = new int[n + 1];

                for (int r = 0; r <= n; r++)
                {
                    // nCr = n! / ((n - r)! * r!)
                    pascalRow[r] = ComputeFactorial(n) / (ComputeFactorial(n - r) * ComputeFactorial(r));
                }

                pascalsTriangle[n] = pascalRow;
            }

            // Write Pascal's Triangle to the console
            Console.WriteLine("Pascal's Triangle - Jagged Array");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                foreach (int num in pascalsTriangle[i])
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
        }

        static int ComputeFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * ComputeFactorial(n - 1);
            }
        }
    }
}