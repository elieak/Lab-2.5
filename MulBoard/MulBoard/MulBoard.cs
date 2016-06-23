using System;

namespace MulBoard
{
    public class MulBoard
    {
        public static void Main()
        {
            for (int row = 0; row < 11; row++)
            {
                for (int column = 1; column < 11; column++)
                {
                    Console.Write($"{row*column,3}");
                }
                Console.WriteLine("");
            }
        }
    }
}