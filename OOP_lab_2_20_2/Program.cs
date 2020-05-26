using System;

namespace OOP_lab_2_20_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;

            while (x <= Math.PI)
            {
                double y = Math.Tan(x);

                Console.WriteLine("x = {0:f4} y = {1:f4}", x, y);

                x += Math.PI / 20;
            }
        }
    }
}
