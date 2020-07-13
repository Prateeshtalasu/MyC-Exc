using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class Avgof3
    {
        static void Main(string[] args)
        {
            double num1, num2, num3; 
            double res;
            Console.WriteLine("enter three numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            res = (num1 + num2 + num3) / 3;
            Console.WriteLine("the avg is :" + res);

        }
    }
}
