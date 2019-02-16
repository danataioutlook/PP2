using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;


           for(int i = 0; i < a.Length; i++)
            {
                for(int j = 2; j <= i; j++)
                {
                    Console.WriteLine(a[i] + " ");
                }
            }
        }
    }
}
