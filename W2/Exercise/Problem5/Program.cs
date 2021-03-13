/*
* extra exercise easy
*let user enter their grade, and then showing the relative statements
*03/05/2021
*/

using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string senior = "senior student";
            string junior = "junior student";
            decimal gpa = 4.3M;
            bool se = true;
            
            
            int grade = int.Parse(Console.ReadLine());

            while (grade != 0)
            {
                if (grade <= 2 && grade > 0)
                {
                    se = false;
                }
                else
                {
                    se = true;
                }
                if (se)
                {
                    Console.WriteLine("I am " + senior + " at NTU, \n" + "and my target GPA of this semester is " + gpa);
                    Console.WriteLine("Please key in your grade or key in 0 to exit.");
                    grade = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("I am " + junior + " at NTU, \n" + "and my target GPA of this semester is " + gpa);
                    Console.WriteLine("Please key in your grade or key in 0 to exit.");
                    grade = int.Parse(Console.ReadLine());
                }
            } 


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /* TA EXAMPLE
        static void Easy(){
            string seniorStudentString = "senior student";
            string juniorStudentString = "junior student";
            int myGrade = 4;
            decimal myTargetGPAofThisSemester = 4.3m;
            bool isSeniorStudent = myGrade > 2;
            if(isSeniorStudent){
                Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", seniorStudentString,  myTargetGPAofThisSemester);
            }else{
                 Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", juniorStudentString,  myTargetGPAofThisSemester);
            }

        }*/
    }
}