﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task222
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j; // rows

            int n = int.Parse(Console.ReadLine());
            for( i = 1; i <= n; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.WriteLine("[*]");
                }
            }
        }
    }
}
