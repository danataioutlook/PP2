using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            name = Console.ReadLine();
            string id;
            id = Console.ReadLine();
            int num;
            num = int.Parse(Console.ReadLine());




            Console.WriteLine("Name" + ":" + name);
            Console.WriteLine("ID" + ":" + id);
            if (num == 1)
            {
                num++;
            }

            Console.WriteLine("Year" + ":" + num);
            Console.ReadLine();

        }
    }
}