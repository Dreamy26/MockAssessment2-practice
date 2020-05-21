using System;

namespace MockAss2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i > ints.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
