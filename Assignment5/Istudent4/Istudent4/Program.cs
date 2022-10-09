using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student5

{

    class IStudent1

    {

        public static void Main(string[] args)

        {

            Resident r1 = new Resident();
            r1.Resident1();
            r1.ShowDetails();
            DaysScholar d1 = new DaysScholar();
            d1.DayScholar1();
            d1.ShowDetails();
            Console.ReadKey();

        }

    }


    interface IStudent
    {

        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();

    }


    public class DaysScholar : IStudent

    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int _StudentId

        {

            set { StudentId = value; }
            get { return StudentId; }

        }

        public string Names

        {

            set { Names = value; }
            get { return Names; }

        }




        public void DayScholar1()

        {

            Console.Write("Enter DayScholar Student Id :");

            StudentId = Convert.ToInt32(Console.ReadLine());




            Console.Write("Enter DayScholar Student Name : ");

            Name = Console.ReadLine();

        }


        public void ShowDetails()

        {

           Console.WriteLine("StudentId : {0}\nName : {1}", StudentId, Name);

        }

    }


   public class Resident : IStudent

    {

        public int StudentId {get;set;}
        public string Name {get;set;}


        public int StudentId1

        {
            set {StudentId1 = value;}
            get {return StudentId1;}
        }



        public string _Name

        {
            set { Name = value;}
            get { return Name; }
        }




        public void Resident1()

        {
            Console.Write("Enter Resident Student Id :");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Resident Student Name : ");
            Name = Console.ReadLine();

        }


        public void ShowDetails()
        {

            Console.WriteLine("StudentId : {0}\nName : {1}", StudentId, Name);

        }

    }
}
