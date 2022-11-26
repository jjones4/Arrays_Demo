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
        }
    }
}