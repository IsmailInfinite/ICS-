using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPlan
{
    public class Class2
    {

        public void ShowFirstscreen()
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Select the below: \n1. Student \n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());



            switch (op)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;

                default:

                    Console.WriteLine("Sorry wrong input ");
                    ShowFirstscreen();
                    break;
            }
        }
        public void ShowStudentScreen()
        {
            Console.WriteLine("Welcome to Student's page");
            Console.WriteLine("Enter your requirement: \n1.Display student details \n2.Display the list of courses available \n3.Enrollment\n4.Go back");
            Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    App a = new App();
                    a.Scenario2(); // display the stu details in ino class
                    break;
                case 2:
                    App b = new App();
                    b.Scenario_2();//array value in enroll class of list courses
                    break;
                case 3:
                    showStudentRegistrationScreen();
                    break;
                case 4:

                    ShowFirstscreen();
                    break;
                default:

                    Console.WriteLine("\nSorry wrong input\n ");
                    ShowStudentScreen();
                    break;




            }
        }
        public void showallstudentsscreen()
        {
            //Student.display();
            App a = new App();

            // app class's scenario's are displayed here
            a.Scenario2();

            casestudy4.showallstudents();


        }
        public void showStudentRegistrationScreen()
        {
            // AppEngine.register();
            //int sid;
            //string sname;
            //string sdob;
            //Console.WriteLine("please provide the following details");
            //Console.WriteLine("Enter the student id:");
            //Console.WriteLine("Enter the name of student:");
            //Console.WriteLine("Enter the date fo birth of student: (MM/DD/YYYY)");


            //sid = Convert.ToInt32(Console.ReadLine());
            //sname = Console.ReadLine();
            //sdob = Console.ReadLine();

            //Console.WriteLine("\nStudent ID:" + sid + "\nStudent Name:" + sname + "\nDate of birth:" + sdob);

            casestudy4.register();
        }
        public void ShowAdminScreen()
        {
            Console.WriteLine("Select the below \n1.introduceNewCourseScreen \n2. showallstudentsscreen\n3. showAllCoursesScreen\n4.Go back");
            Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());



            switch (op)
            {
                case 1:
                    Console.WriteLine("Details on new Courses");
                    introduceNewCourseScreen();
                    break;
                case 2:
                    showallstudentsscreen();
                    break;
                case 3:
                    showAllCoursesScreen();
                    break;
                case 4:

                    ShowFirstscreen();
                    break;

                default:

                    Console.WriteLine("\nSorry wrong input\n");
                    ShowAdminScreen();
                    break;

            }
        }

        public void introduceNewCourseScreen()
        {
            Console.WriteLine("list of courses:");
            Console.WriteLine("1.B.Tech \n2.B.Ed \n3.B.C.A \n4.B.E\n5.Go back ");
            Console.WriteLine("Enter your choice ( 1, 2, 3, 4 )Must be within limit   ");
            int op = Convert.ToInt32(Console.ReadLine());



            switch (op)
            {
                case 1:
                    Console.WriteLine("B.Tech \nBachelor in Technology is the 4 year course which offers a wide rage of placement possibiity\n" +
                        "even if you have arrear and you have a proper skillset job is yours");
                    Console.WriteLine("Fees: Rs.23,000 per year untill 4years" +
                        "Semester exam fees and book fees are not covered in this");



                    break;
                case 2:
                    Console.WriteLine("B.Ed \nBachelor in Education is the 3 year course which offers a placement in who loves to teach other and who are all good speaker and thos who can able to get attraction\n" +
                       "can get help from veterient person who around's you.");
                    Console.WriteLine("Fees: Rs.20,000 per year untill 3years" +
                        "Semester exam fees and book fees are not covered in this");
                    break;
                case 3:
                    Console.WriteLine("B.C.A \nBachelor in Computer application is the 3 year course which offers subject covered in b.tech with in 3 year\n" +
                       "skillset and communication are the main in this feild if you opted for placements");
                    Console.WriteLine("Fees: Rs.18,000 per year untill 4years" +
                        "Semester exam fees and book fees are not covered in this");
                    break;
                case 4:
                    Console.WriteLine("B.E \nBachelor in Engineering is the 4 year course which offers a wide rage of placement in any sector which is non relavent that you studied\n" +
                       "complete course is with good mark lead to selected by top recruiters or tech giants");
                    Console.WriteLine("Fees: Rs.44,000 per year untill 4years" +
                        "Semester exam fees and book fees are not covered in this");
                    break;
                case 5:
                    ShowAdminScreen();
                    break;
                default:

                    Console.WriteLine("\nSorry wrong input\n");
                    introduceNewCourseScreen();
                    break;




            }

        }
        public void showAllCoursesScreen()
        {
            App a = new App();
            a.Scenario_2();
            casestudy4.showallcourse();
            //enroll.listofcourses();
        }
    }
}

