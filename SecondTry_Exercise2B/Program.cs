using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaluculatingAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user how many grades to calculate
            Console.WriteLine("How many grades will you enter?");
            
            // convert response string to int
            int response = Convert.ToInt32(Console.ReadLine());

            //initialize an array to store test scores using # of grades response as array size
            int[] testScores = new int[response];

            //declaring variable to count while loop
            int count = 0;

            //declaring variable to 
            int sum = 0;


            //loop will execute until count matches users' number of grades
            while (count < response)
            {
                //user enters as many test scores as stated before
                Console.WriteLine("enter test score");

                //Tell array with predetermined size to fill itself with the test scores entered 
                //previously by user convert test scores to integer from string
                testScores[count] = int.Parse(Console.ReadLine());

                //check if values enter are with the range of 0 and 100
                if (testScores[count] < 0 || testScores[count] > 100)
                {
                    //notify user of invalid entry. will not execute loop until valid entry
                    Console.WriteLine("you entered an invalid score");

                }
                //if valid number is entered loop will continue requesting/accepting results until it
                //equals the predetermined number grades to be calculated
                else
                {
                    //if valid number is entered
                    count++;
                }
                
            }
            //execute for loop to step through array
            for (int i = 0; i < testScores.Length; i++)
            {
                //give sum of grades entered using array values
                sum += testScores[i];

            }
            //give average of total grades entered
            var average = sum / response;

            Console.WriteLine($"The average is {average}");

            //if range between 90 - 10 is A
            if (average < 100 && average > 89)
            {
                Console.WriteLine("This is a A average");
            }
            //if range between 80-89 is B average
            if (average < 90 && average > 79)
            {
                Console.WriteLine("This is a B average");
            }
            //if range between 70-79 is C average
            if (average < 80 && average > 69)
            {
                Console.WriteLine("This is a C average");
            }
            //if range between 60-69 is D average
            if (average < 70 && average > 59)
            {
                Console.WriteLine("This is a D average");
            }
            //if range is between 0-59 is F average
            if (average < 60)
            {
                Console.WriteLine("This is a F average");
            }





        }
    }
}
