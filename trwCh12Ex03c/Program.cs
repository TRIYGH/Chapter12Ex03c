using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trwCh12Ex03c
{
    class Program
    {
        static void Main(string[] args)
        {
            int numScores = 0;

            Console.WriteLine("**************** Score Averager ******************\n");            

            do
            {
                numScores = GetNumScoresFromUser();
            }
            while (numScores <= 0);


            int[] scores = new int[numScores];
            string input;
            int sumOfScores = 0;

            for (int i = 0; i < numScores; i++)
            {
                Console.Write("Enter in Score #{0}: ",i+1);
                input = Console.ReadLine();
                scores[i] = int.Parse(input);
                sumOfScores += scores[i];

            }

            double average = 0.00;
            try
            {
                average = sumOfScores / (double) numScores;
                Console.WriteLine("\n\nThe AVERAGE of your scores is: {0:f2}",average);
            }
            catch ( System.DivideByZeroException e )
            {
                Console.WriteLine("\n\n*** you dumb ! ***\n\n");
            }

            // Assign a letter grade
            char letterGrade = 'X';
            if (average >= 60)
                letterGrade = 'D';

            if (average >= 70)
                letterGrade = 'C';

            if (average >= 80)
                letterGrade = 'B';

            if (average >= 90)
                letterGrade = 'A';

            if (average < 60)
                letterGrade = 'F';

            Console.WriteLine("\nYOUR GRADE IS A {0}.\n\n", letterGrade);
            if (average > 100)
                Console.WriteLine("Please check your grades and ascertain this average \nis consistent with your grades.");

            Console.ReadLine();

        }


        // Get # of grades to enter:

        public static int GetNumScoresFromUser()
        {
            try
            {
                Console.Write("How many scores do you want to enter? ");
                string nmScr;
                nmScr = Console.ReadLine();
                int count = int.Parse(nmScr);
                return count;
            }
            catch (System.FormatException e)
            {
                Console.Error.WriteLine("\n\n**** You must enter in a number ****\n{0}\n\n", e.Message);
                return 0;
            }
            catch (System.Exception e)
            {
                Console.Error.WriteLine("\n\n**** ERROR!! ****\n{0}\n\n", e.Message);
                return 0;
            }
        }
    }
}
