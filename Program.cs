using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    delegate void CalculateDelegate(int val1, int val2);

    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();

            CalculateDelegate calDel = new CalculateDelegate(c.Add);
            calDel += new CalculateDelegate(c.Divide);
            calDel += new CalculateDelegate(Calculate.Subtract);
            calDel += c.Add;
            calDel += Calculate.Multiply;

            calDel(35, 5);

            Delegate[] invList = calDel.GetInvocationList();
            Console.WriteLine("\nInvocation List : ");
            for (int i = 0; i < invList.Length; i++)
            {
                Console.WriteLine(invList[i].Method);
            }

            calDel -= c.Add;
            calDel(30, 3);

            Console.ReadKey();
        }
    }
}
