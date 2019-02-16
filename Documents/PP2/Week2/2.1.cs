using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine(); //print the string
            int i, j, flag=1;   // flag is a boolean type variable that can take the values 0 (false) or 1 (true)

            for (i = 0, j = s.Length - 1; i < j; i++, j--) /* For example, word "ababa" here i=0,so it means the letter a = 0,
                0->5-1, 0->4,1->3 so a=a polindrom*/
            {
                if (s[i] == s[j])  //check true or false
                {
   
                }
                else
                {
                    flag = 0;
                }
                if (flag == 1)
                { //if true then write yes
                    Console.WriteLine("YES");
                }
                else // if false then write no
                {
                    Console.WriteLine("NO");
                }
                Console.ReadLine();
            }
        }
    }
}
