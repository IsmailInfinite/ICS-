using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IRCTC

{
    class traveller

    {

        public int age,ticket;
        public string name;

        public void Passenger()

        {

            Console.WriteLine("How many tickets : ");
            ticket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Passenger name: ");
            name = Console.ReadLine();

            Console.WriteLine("Age :");
            age = Convert.ToInt32(Console.ReadLine());



            TicketBooking(no_of_tickets);

        }


    public void TicketBooking(int no_of_tickets)

        {

            
            if (ticket > 2)

            {
                throw (new TicketBooking("cannot book more than 2 tickets"));
            }

            else

            {
                Console.WriteLine("Ticket Booked Successfully");
            }
           
        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Passengers p = new Passengers();




            try

            {
                TicketBooking.Passengers();
            }

            catch (TicketBooking)

            {
                Console.WriteLine(t1.Message);
            }
            Console.Read();
        }

    }

}


