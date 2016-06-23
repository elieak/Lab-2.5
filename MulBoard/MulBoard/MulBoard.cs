using System;

namespace MulBoard
{
    public class MulBoard
    {
        public static void Main()
        {
            var i = 1;
            while (i <= 10)
            {
                var j = 1;
                var line = "";
                while (j <= 10)
                {
                    line += (i*j).ToString() + "\t";
                    j++;
                }
                Console.WriteLine(line);
                i++;

            }
        }
    }
}