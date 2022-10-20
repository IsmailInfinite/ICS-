using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{

    class Stationery

    {
        static void Main(string[] args)
        {

           List<string> stationeryItems = new List<string>();

            stationeryItems.Add("Books");
            stationeryItems.Add("Charts");
            stationeryItems.Add("Pen");
            stationeryItems.Add("Sharpner");
            Console.WriteLine("The new items of Stationary:  ");


            foreach (string items in stationeryItems)

            {

                Console.WriteLine(items);

            }

            Console.ReadKey();

        }

    }

}