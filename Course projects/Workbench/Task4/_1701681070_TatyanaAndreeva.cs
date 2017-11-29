﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   public static class _1701681070_TatyanaAndreeva
    {
        public static void CountingPoints()
        {
                int count = 0;
            int lowestPointForX = -13;
            int highestPointForX = 13;
            int lowestPointForY= -16;
            int highestPointForY = 16;
                for (int x = lowestPointForX; x <= highestPointForX; x++)
                {
                    for (int y = lowestPointForY; y <= highestPointForY; y++)
                    {
                        double a= (Math.Pow(Math.Abs(x), 2) / 169) + (Math.Pow(Math.Abs(y), 2) / 256);
                        if (a < 1)
                        {
                            Console.WriteLine("A[{0},{1}]", x, y);
                            count++;
                        }
                    }
                }
                Console.WriteLine("Броят на точките в елипсата е {0}", count);
        }
    }
}
