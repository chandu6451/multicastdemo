using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public class Calculate
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} => {2}", num1, num2, (num1 + num2));
        }

        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine("{0} - {1} => {2}", num1, num2, (num1 - num2));
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine("{0} * {1} => {2}", num1, num2, (num1 * num2));
        }

        public void Divide(int num1, int num2)
        {
            Console.WriteLine("{0} / {1} => {2}", num1, num2, (num1 / num2));
        }
    }
}
