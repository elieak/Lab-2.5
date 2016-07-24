using System;

namespace MulBoard
{
    //The first line prints zeros.
    public class MulBoard
    {
        public static void Main()
        {
            for (var row = 0; row < 11; row++)
            {
                for (var column = 1; column < 11; column++)
                {
                    Console.Write($"{row*column,4}");
                }
                Console.WriteLine("");
            }
        }
    }
}