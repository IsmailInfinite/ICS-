using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Reportcard
{

    static void Main(string[] args)
    {

      
        int roll, marks1, marks2, marks3, marks4, marks5, total;

        float percentage;
        string n, c,s,b;
        Console.WriteLine("Roll No :");
        roll = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter Student Name :");
        n = Console.ReadLine();
        Console.WriteLine("Class :");
        c = Console.ReadLine();
        Console.WriteLine("Semester :");
        s = Console.ReadLine();
        Console.WriteLine("Branch :");
        b = Console.ReadLine();
        Console.WriteLine("Subject 1 Marks : ");
        marks1 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Subject 2 Marks : ");
        marks2 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Subject 3 Marks :");
        marks3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Subject 4 Marks : ");
        marks4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Subject 5 Marks : ");
        marks5 = Convert.ToInt32(Console.ReadLine());

        total = marks1 + marks2 + marks3 + marks4 + marks5;
        percentage = total / 5.0f;

        Console.WriteLine("Name: {0}", n);
        Console.WriteLine("class: {0}", c);
        Console.WriteLine("Semister: {0}", s);
        Console.WriteLine("Branch: {0}", b);
        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Percentage : " + percentage);

         if (percentage <= 35)
        {
            Console.WriteLine("Fail");
        }
        else if (percentage >= 35 && percentage <= 50)
        {
            Console.WriteLine("Fail");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("Passed");
        }
        else 
        {
            Console.WriteLine("Wrong data");
        }
        
        Console.ReadLine();
    }
}