
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyPlan;


namespace StudyPlan
{
    public class App
    {

        public void Scenario1()
        {
            Student std1 = new Student(1, "     Ismail     ", Convert.ToDateTime("01/01/1995"));
            Student std2 = new Student(2, "     Sampreeth  ", Convert.ToDateTime("02/02/1996"));
            Student std3 = new Student(3, "     Raajesh    ", Convert.ToDateTime("03/03/1997"));
            Console.WriteLine("ID     Name        DOB");
            Console.WriteLine("_____________________________");


            Info i = new Info();
            i.display(std1);
            i.display(std2);
            i.display(std3);


            Course c1 = new Course(01, " Dotnet", "    10 Hrs", 10000);
            Course c2 = new Course(02, " HTML", "    20 Hrs", 20000);
            Course c3 = new Course(03, " JAVA", "    30 Hrs", 30000);
            Console.WriteLine("*****************************\n");
            Console.WriteLine("ID Name   Durartion   Fees");
            Console.WriteLine("_____________________________");


            i.display(c1);
            i.display(c2);
            i.display(c3);

            casestudy4.showallstudents();
        }





        public void Scenario2()
        {
            Student[] students = new Student[3];
            Console.WriteLine("*****************************\n");
            Console.WriteLine("ID\tName   \tDOB");
            Console.WriteLine("_____________________________");

            students[0] = new Student(1, "     Ismail     ", Convert.ToDateTime("   01/01/1995"));
            students[1] = new Student(2, "     Sampreeth  ", Convert.ToDateTime("  02/02/1996"));
            students[2] = new Student(3, "     Raajesh    ", Convert.ToDateTime("   03/03/1997"));

            Info i = new Info();


            i.display(students[0]);
            i.display(students[1]);
            i.display(students[2]);
        }
        public void Scenario_2()
        {
            Info i = new Info();
            Course[] courses = new Course[3];
            Console.WriteLine("*****************************\n");

            courses[0] = new Course(01, "Dotnet", "10 Hrs", 10000);

            courses[1] = new Course(02, "HTML  ", "20 Hrs", 20000);

            courses[2] = new Course(03, "JAVA  ", "30 Hrs", 30000);

            Console.WriteLine("ID Name Durartion Fees");
            Console.WriteLine("_____________________________");

            i.display(courses[0]);
            i.display(courses[1]);
            i.display(courses[2]);
        }

        public void Scenario3()
        {
            try

            {
                Console.WriteLine("__________________________________");

                Console.Write("Enter the total number of students : ");
                int SCount = Convert.ToInt32(Console.ReadLine());
                Student[] students = new Student[SCount];

                Console.WriteLine("Enter all the details of Students  : ");

                for (int i = 0; i <= SCount - 1; i++)

                {

                    Console.Write("Enter the id of student  : ", i + 1);
                    int SId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the Name of student  : ", i + 1);
                    string SName = Console.ReadLine();

                    Console.Write("Enter the DOB of Student  : ", i + 1);
                    DateTime SDob = Convert.ToDateTime(Console.ReadLine());

                    students[i] = new Student(SId, SName, SDob);
                    Info info = new Info();
                    info.display(students[i]);

                }

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            try

            {
                Console.Write("Enter the total Courses: ");
                int NoOfCourse = Convert.ToInt32(Console.ReadLine());
                Course[] courses = new Course[NoOfCourse];

                Console.WriteLine("Enter the details: ");

                for (int i = 0; i <= NoOfCourse; i++)

                {

                    Console.WriteLine("Enter the Course ID {0} : ");
                    int CourseId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the Course Name {0} : ");
                    string CourseName = Console.ReadLine();

                    Console.WriteLine("Enter the Course Duration : ");
                    string CourseDuration = Console.ReadLine();

                    Console.WriteLine("Enter the Course Fee {0} : ");
                    int CourseFees = Convert.ToInt32(Console.ReadLine());

                    courses[i] = new Course(CourseId, CourseName, CourseDuration, CourseFees);
                    Info info = new Info();
                    info.display(courses[i]);

                }

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }
        }



        static void Main(string[] args)
        {

            App a = new App();
            //a.Scenario1();
            //a.Scenario2();
            //a.Scenario3();

            AppEngine ae = new AppEngine();

            // ae.introduce();
            //ae.register();
            //ae.enroll();
            // ae.ListOfStudents(); //for student details
            //a.Scenario_2(); //for courses details
            //ae.listOfEnrollments();
            //ae.ListOfCourses();
            Class2 c2 = new Class2();
            c2.ShowFirstscreen();
            //Class3 c3 = new Class3();
            //c3.introduce();
            casestudy4 c4 = new casestudy4();


            Console.ReadKey();

        }
    }
    public class Student
    {
        public int studentid { get; set; }
        public string studentname { get; set; }
        public DateTime studentdob { get; set; }

        public Student(int sId, string sName, DateTime sDOB)
        {
            studentid = sId;
            studentname = sName;
            studentdob = sDOB;

        }
    }
}

public class Info
{
    public void display(Student student)
    {
        Console.WriteLine("{0},{1},{2}", student.studentid, student.studentname, student.studentdob.ToShortDateString());


    }
    public void display(Course course)
    {
        Console.WriteLine("{0} {1} {2}", course.id, course.name, course.duration, course.fees);

    }
}




public class Course

{
    public int id { get; set; }
    public string name { get; set; }
    public string duration { get; set; }
    public float fees { get; set; }

    public Course(int id, string name, string duration, float fees)
    {
        this.id = id;
        this.name = name;
        this.duration = duration;
        this.fees = fees;
    }
}



