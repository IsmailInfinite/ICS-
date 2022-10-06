using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    class Doctor
    {
        public static void Main(string[] args)
        {
            Doctor1 obj = new Doctor1();
            obj.Name = "Ismail";
            obj.RegnNo = 1;
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.RegnNo);
            Console.ReadLine();




        }
    }
    class Doctor1
    {
        public int RegnNo { get; set; }
        public string Name { get; set; }
        private int Feescharged { get; set; }
        
    }
}

