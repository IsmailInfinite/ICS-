using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudyPlan
{
    class casestudy4
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LAP-2215;initial catalog=students;" + "Integrated Security=True");
            con.Open();
            return con;
        }

        public static void introducenewcourse()
        {
            con = getConnection();
            Console.WriteLine("Enter CourseId, CourseName, CourseDuration, CourseFees");
            int CourseId = Convert.ToInt32(Console.ReadLine());
            string CourseName = Console.ReadLine();
            string CourseDuration = Console.ReadLine();
            double CourseFee = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("insert into course values(courseid,coursename, courseduration, coursefee);", con);
            cmd.Parameters.AddWithValue("courseid", CourseId);
            cmd.Parameters.AddWithValue("coursename", CourseName);
            cmd.Parameters.AddWithValue("courseduration", CourseDuration);
            cmd.Parameters.AddWithValue("coursefee", CourseFee);

            int records = cmd.ExecuteNonQuery();
            if (records > 0)
            {
                Console.WriteLine("sucessfully inserted");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            con.Close();
        }
        public static void showallcourse()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("CourseId  CourseName  CourseDuration  CourseFee");
                cmd = new SqlCommand("select * from course;", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "" + dr[1] + " " + dr[2] + " " + dr[3]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("server error!!");
            }
            finally
            {
                con.Close();
            }
        }

        public static void showallstudents()
        {
            con = getConnection();
            try
            {
                Console.Write("StudentId  StudentName  StudentDOB");
                cmd = new SqlCommand("select * from students;", con);
                cmd.Connection = con;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1]);
                }
            }
            catch (SqlException f)
            {
                Console.WriteLine("server error!!");
            }
            finally
            {
                con.Close();
            }

        }

        public static void enrollment()
        {
            con = getConnection();
            try
            {
                cmd = new SqlCommand("select * from course;", con);

                Console.WriteLine("Enter your StudentId: ");
                int eid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name: ");
                string ename = Console.ReadLine();

                Console.WriteLine("Enter Course Name: ");
                String cname = Console.ReadLine();

                cmd = new SqlCommand("insert into enroll values(studentid, studentname, coursename);", con);

                cmd.Parameters.AddWithValue("studentid", eid);
                cmd.Parameters.AddWithValue("studentname", ename);
                cmd.Parameters.AddWithValue("coursename", cname);


                cmd = new SqlCommand("select * from enroll;", con);
                cmd.Connection = con;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);

                }
            }
            catch (SqlException g)
            {
                Console.WriteLine("server error!!");
            }
            finally
            {
                con.Close();
            }

        }

        public static void register()
        {
            con = getConnection();
            try
            {
                Console.WriteLine("Enter your StudentId: ");
                int eid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name: ");
                string ename = Console.ReadLine();

                Console.WriteLine("Enter Student DOB: ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());

                cmd = new SqlCommand("insert into student values(studentid, studentname, studentdob);", con);

                cmd.Parameters.AddWithValue("studentid", eid);
                cmd.Parameters.AddWithValue("studentname", ename);
                cmd.Parameters.AddWithValue("studentdob", dob);

                cmd = new SqlCommand("select * from students;", con);
                dr = cmd.ExecuteReader();
                Console.WriteLine();


                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        Console.WriteLine(dr[i]);

                    }
                }
            }
            catch (SqlException h)
            {
                Console.WriteLine("server error!!");
            }
            finally
            {
                con.Close();
            }
        }

    }

}
