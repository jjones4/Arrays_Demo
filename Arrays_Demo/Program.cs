namespace Arrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Single-dimensional array
             * Compute the powers of two with exponents
             * ranging from 0 to 63
             * 
             */

            // Instantiate and fill the array with the
            // powers of two
            ulong[] powersOfTwo = new ulong[64];

            for (int i = 0; i < powersOfTwo.Length; i++)
            {
                powersOfTwo[i] = (ulong)Math.Pow(2, i);
            }

            // Write the powers of two to the console
            int exponenet = 0;

            foreach (ulong result in powersOfTwo)
            {
                Console.WriteLine($"Exponenet: {exponenet}: Result: {powersOfTwo[exponenet]}");

                exponenet++;
            }
        }
    }
}