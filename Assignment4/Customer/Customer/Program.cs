using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customerdetails

{

    public class Customer

    {

        public int Customerid, Age;
        public string Name, Phone, City;

        static void Main(string[] args)

        {
            Customer c1 = new Customer(7, "Ismail", 18, "100", "Hyderabad");
            c1.Display();
            Console.ReadKey();

        }
        public Customer()
        {
        }

        public Customer(int id, string name, int age, string number, string city)

        {

            Customerid = id;
            Name = name;
            Age = age;
            Phone = number;
            City = city;
        }




        public void Display()

        {
            Console.WriteLine("Customer Id : {0}\nName: {1}\nAge: {2}\nPhone: {3}\nCity: {4}", Customerid, Name,Age,Phone,City);
            
            
        }

    }

}
