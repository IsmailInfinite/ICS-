using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales1
{
    
     class Saledetails
        {
            int salesNo;
            int productNo;
            decimal price;
            DateTime dateOfSale;
            int Qty;
            int TotalAMount;

            public static void Sales(int qty, int pr)
            {

                Console.WriteLine(qty * pr);
            }
            public static void Main(string[] args)
            {
                Sales(5, 3);
            Console.ReadLine();
            }
        }
    }
    
