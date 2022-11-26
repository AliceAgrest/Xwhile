using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer1
            //right = 0
            //middle = 1
            //left = 3
            //answer2
            int num, maxNum = 0, a, b;
            Console.WriteLine("Enter a number two digit number ");
            num = int.Parse(Console.ReadLine());
            a = num / 10;
            b = num % 10;
            while(num > 9 && num < 100)
            {
                if(num > maxNum && a != b)
                {
                    maxNum = num;
                }
                Console.WriteLine("Enter a number two digit number ");
                num = int.Parse(Console.ReadLine());
                a = num / 10;
                b = num % 10;
            }
            Console.WriteLine("Your max num is "+ maxNum);
            
            //answer3
            int num, duplicNum = 1;
            Console.WriteLine("Enter a positive number ");
            num = int.Parse(Console.ReadLine());
            while(num > -1)
            {
                if(num % 3 == 0 && num % 2 == 0 && num != 0)
                {
                    duplicNum *= num;
                }
                Console.WriteLine("Enter a positive number ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your duplicating number is "+ duplicNum);
            
            //answer4
            int numCount = 0;
            double num;
            Console.WriteLine("Enter a positive number ");
            num = double.Parse(Console.ReadLine());
            while(num > 0)
            {
                numCount++;
                Console.WriteLine("Enter a positive number ");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Count positive numbers is "+ numCount);
            
            //answer5
            int grade, highGrade = 0, lowerGrade = 100;
            Console.WriteLine("Enter a grade a grade ");
            grade = int.Parse(Console.ReadLine());
            while(grade > 0)
            {
                if (grade < lowerGrade)
                    lowerGrade = grade;
                else if (grade > highGrade)
                    highGrade = grade;
                Console.WriteLine("Enter a grade a grade ");
                grade = int.Parse(Console.ReadLine());
            }
            if (lowerGrade <= 55)
                Console.WriteLine("You are a failure your grade is " + lowerGrade);
            else if (lowerGrade >= 95)
                Console.WriteLine("Exelent your grade is " + lowerGrade);
            else
                Console.WriteLine("You are so dump dude "+ lowerGrade);
            if (highGrade <= 55)
                Console.WriteLine("You are a failure your grade is " + highGrade);
            else if (highGrade >= 95)
                Console.WriteLine("Exelent your grade is " + highGrade);
            else
                Console.WriteLine("You are so smart af you are a mf ,your grade is  " + highGrade);
            

            Console.ReadLine();
        }
    }
}