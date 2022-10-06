using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOccurrences
{
    class Program
    {
        
        
        static void Main()
        {
            string str;
            char ch;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            Console.WriteLine("Enter the character to be searched:");
            ch = Console.ReadLine()[0];
            int res = 0;



            for (int i = 0; i < str.Length; i++)
            {



                // checking character in string
                if (str[i] == ch)
                    res++;
            }
            Console.WriteLine("The character has occured:" + res);
            Console.Read();
        }
    }

}