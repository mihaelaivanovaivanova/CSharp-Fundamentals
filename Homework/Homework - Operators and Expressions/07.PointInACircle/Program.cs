﻿using System;


namespace _07.PointInACircle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if ( distance <= 2)
            {
                Console.WriteLine("yes {0:F2}", distance );
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance );
            }

        }
    }   
}
