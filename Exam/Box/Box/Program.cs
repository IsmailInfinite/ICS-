using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box
    {
        public int length;
        public int breadth;
       
       
    }
    class Test
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        static void Main(string[] args)
        {
            Test box1 = new Test();
            Test box2 = new Test();
            Console.WriteLine("Enter the Length and Breadth");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two boxes is:{0}",Sum(n1,n2));
            Console.ReadLine();

        }

    }
}

