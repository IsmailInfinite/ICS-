
using System;
//using Infinite.casestudy1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudyPlan
{
    public class AppEngine : App
    {


        Course[] s = new Course[3];
        public void introduce()
        {
            App a = new App();
            a.Scenario_2();

        }

        public void register(Student student)
        {
            App a = new App();
            a.Scenario2();
            Student[] std = new Student[3];
            std[0] = new Student(1, "     Ismail     ", Convert.ToDateTime("01/01/1995"));
            Info i = new Info();
            i.display(std[0]);

        }

        public Student[] ListOfStudents()
        {
            Console.WriteLine("\n\n\nlist of students");
            App a = new App();
            //a.Scenario1();
            // a.Scenario2();
            AppEngine a1 = new AppEngine();
            Student[] std = new Student[3];
            a1.register(std[0]);
            return std;



        }



        public Course[] ListOfCourses()
        {
            Console.WriteLine("\n\n\nlist of Courses");
            App a = new App();
            //a.Scenario1();
            a.Scenario_2();
            AppEngine a1 = new AppEngine();
            Course[] cour = new Course[3];
            //a1.register(cour[0]);
            return cour;
            //Course[] sres = new Course[3];
            //for (int i = 0; i < s.Length; i++)
            //{
            //    sres[i] = new Course(s[i].id,s[i].name,s[i].duration,s[i].fees)
            //    {
            //        id = s[i].id,
            //        name = s[i].name,
            //        duration = s[i].duration,
            //        fees=s[i].fees
            //    };
            //}
            //return sres;


        }

        public void enroll()
        {
            App a = new App();
            a.Scenario1();

            casestudy4.enrollment();

        }

        public void listOfEnrollments()
        {
            AppEngine ae = new AppEngine();
            ae.ListOfStudents();
            ae.ListOfCourses();


        }

    }
}