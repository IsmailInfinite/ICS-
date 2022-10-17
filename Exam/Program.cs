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
        public void  Sum(int num1, int num2)
        {

            int total;
            total = num1 + num2;
            Console.WriteLine("The sum is:{0}",total);
        }

    }
    class Test
    {
       
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            box1.Sum(2,4);
            box2.Sum(4, 6);

            Console.ReadLine();

        }

    }
}

