using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, m1, m2, m3, total;
            float percentage;
            string n;
            Console.WriteLine("Enter Student Roll Number :");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();
            Console.WriteLine("Enter C# Marks : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter html Marks :");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SQL Marks :");
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
            percentage = total / 3.0f;
            Console.WriteLine("Final result of {0} is:", n);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage : " + percentage);
            if (percentage <= 50)
            {
                Console.WriteLine(" failed");
            }
            else
            {
                Console.WriteLine("passed");
            }
            Console.ReadKey();
        }
    }
}
