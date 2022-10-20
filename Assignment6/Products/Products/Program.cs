using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
    }
    public class Program
    {
        int[] id = new int[10];
        string[] name = new string[10];
        float[] amount = new float[10];


    static void Main(string[] args)
        {
            Program p1 = new Program();


            for (int i = 0; i < 9; i++)

            {

                Console.WriteLine("Product {0}: ", i + 1);
                program.id[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Product name {0}: ", i + 1);
                program.name[i] = Console.ReadLine();

                Console.WriteLine("Enter product Price for product {0}: ", i + 1);
                program.amount[i] = Convert.ToSingle(Console.ReadLine());
                Console.ReadLine();

            }




            List<Product> products = new List<Product>
            
           {

               new Product { ProductId = program.id[0], ProductName = program.name[0], Price = program.price[0] }
               new Product { ProductId = program.id[1], ProductName = program.name[1], Price = program.price[1] }
               new Product { ProductId = program.id[2], ProductName = program.name[2], Price = program.price[2] }
               new Product { ProductId = program.id[3], ProductName = program.name[3], Price = program.price[3] }
               new Product { ProductId = program.id[4], ProductName = program.name[4], Price = program.price[4] }          
               new Product { ProductId = program.id[5], ProductName = program.name[5], Price = program.price[5] }
               new Product { ProductId = program.id[6], ProductName = program.name[6], Price = program.price[6] }
               new Product { ProductId = program.id[7], ProductName = program.name[7], Price = program.price[7] }
               new Product { ProductId = program.id[8], ProductName = program.name[8], Price = program.price[8] }
               new Product { ProductId = program.id[9], ProductName = program.name[9], Price = program.price[9] }

           }

            Display(products);
            Console.Read();

        }
        
    public static void Display(List<Product> products)

        {

            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();

            foreach (var p in val)

            {

                Console.WriteLine("name: {0}\tid: {1}\tprice: {2} ", p.ProductName, p.ProductId, p.Price);
                Console.ReadLine();

            }

        }

    }

}
