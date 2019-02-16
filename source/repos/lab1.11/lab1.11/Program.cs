using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <=b; i++)
            {
                if (isSimple(i) && i!=1)
                {
                    Console.Write(i.ToString() );
                }
            }
            
        }
        //метод который определяет простое число или нет
        private static bool isSimple(int N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
            //число на числа до его половины
            for(int i = 2; i < (int)N / 2; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
   