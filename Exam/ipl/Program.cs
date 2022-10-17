using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipl
{
    class cricket
    {
        private static int no_of_matches;

        static void Main(string[] args)
        {
            int nofmatch, scores, sum=0;
            double avg;
            
            Console.WriteLine("Enter number of matches");
           

                no_of_matches = Convert.ToInt32(Console.ReadLine());
                
            
            Console.WriteLine("Enter the scores");
            for (int j=1; j<=10; j++)
            {
                scores = Convert.ToInt32(Console.ReadLine());
                sum += scores;
            }

            avg = sum / 10.0;
            
            Console.ReadLine();
            Console.WriteLine("The sum of scores is:{0}\nThe average is:{1}\n",sum,avg);
            Console.ReadLine();
            int PointsCalcualtion(int no_of_matches)
            {
                int input = no_of_matches;
                no_of_matches = Convert.ToInt32(Console.ReadLine());

                return input;
                
            }


        }
        
        
     
        }
    }

