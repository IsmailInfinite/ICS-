using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstnLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            string fstr, lstr;
            char ch;
            char[] arr1;
            int l, i = 0;
            Console.WriteLine("Enter the first Name:");
            fstr = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            lstr = Console.ReadLine();
            l = fstr.Length;
            arr1 = fstr.ToCharArray(0, l); // Converts string into char array.



            Console.Write("\nAfter conversion, the string is : ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                Console.Write(Char.ToUpper(ch));
                Console.Read();
            }
        }
    }
}
