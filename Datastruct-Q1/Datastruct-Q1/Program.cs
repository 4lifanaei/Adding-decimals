using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastruct_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int[] num1 = Get_Number();
            int[] num2 = Get_Number();
            sum(num1, num2);

        }
        private static void sum(int[] num1,int[] num2)
        {
            if (num1[1] > num2[1])
            {
                while (num1[1] != num2[1])
                {
                    num1[1]--;
                    num1[0] *= 10;
                }
            }
            else if (num1[1] < num2[1])
            {
                while (num1[1] != num2[1])
                {
                    num2[1]--;
                    num2[0] *= 10;
                }
            }
            num1[0] += num2[0];
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("sum---> {0}",num1[0]*Math.Pow(10,num1[1]));
            Console.WriteLine("--------------------------------------");
        }
        private static int[] Get_Number()
        {
            Console.Write("Enter number: ");
            string[] numStr = Console.ReadLine().Split('.');

            int q = 0;
            int c = 0;

            if(numStr.Length == 2)
            {
                q = -(numStr[1].Length);
                c = int.Parse(numStr[0] + numStr[1]);
            }
            else
            {
                c = int.Parse(numStr[0]);
            }
            int[] number = { c, q };
            return number;
        }
    }
}
