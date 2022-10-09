using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    abstract class Student
    {
        public int studentid;
        public string name;
        public float grade;
        public abstract bool Ispassed(float grade);

    }

class Undergradute : Student
    {
        public override bool Ispassed(float grade)
        {
            if (grade > 70.0f)
            {
                Console.Write("Under Graduate\nPassed");
                return true;


            }
            else
            {
                Console.Write("Under Graduate\nFailed");
                return false;
            }
        }
    }

class Graduate : Student
    {
        public override bool Ispassed(float grade)
        {
            if (grade > 80.0f)
            {
                Console.Write("Graduate\nPassed");
                return true;

            }
            else
            {
                Console.Write("Graduate\nFailed");
                return false;
            }
        }
    }


class studentdetails
    {
        public static void Main(string[] args)

        {
            Student s1 = new Undergradute();
            Console.WriteLine("Name of Under Gradute:");
            s1.name = Console.ReadLine();

            Console.WriteLine("Enter ID:");
            s1.studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Grade:");
            s1.grade = Convert.ToInt32(Console.ReadLine());
            s1.Ispassed(s1.grade);



            Student s2 = new Undergradute();
            Console.WriteLine("Name of Under Gradute:");
            s2.name = Console.ReadLine();

            Console.WriteLine("Enter ID:");
            s2.studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Grade:");
            s2.grade = Convert.ToInt32(Console.ReadLine());
            s2.Ispassed(s2.grade);

            Console.Read();

        }
    }

}

