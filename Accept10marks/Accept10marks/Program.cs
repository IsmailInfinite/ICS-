using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept10marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0,j,tmp;
            int[] arr = new int[10];
            double avg;
            int minimal = int.MaxValue;
            int maximal = int.MinValue;

            Console.Write("\n\n");
            Console.Write("Enter 10 numbers and calculate sum and average:\n");
            Console.Write("\n\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            avg = sum / 10.0;
            Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minimal)
                {
                    minimal = arr[i];
                }
                if (arr[i] > maximal)
                {
                    maximal = arr[i];
                }
            }
            Console.WriteLine("minimal={0}", minimal);
            Console.WriteLine("maximal={0}", maximal);
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr[j] < arr[i])
                    {

                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.Write("\nDescending order:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Read();
        }

    }
}
