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
            
            //answer6
            int num, num1, numCount = 0, duplicNum = 1, sumNum = 0;
            Console.WriteLine("Enter a positive number ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                if (num % 10 >= 0)
                {
                    numCount++;
                    num1 = num % 10;
                    duplicNum = num1*duplicNum;
                    sumNum += num1;
                    num /= 10;
                }
            }
            Console.WriteLine($"The count of your numbers is {numCount}\n" +
                    $"The sum of your numbers is {sumNum}\n" +
                    $"The duplicating of your numbers is {duplicNum}");

            //q1
            /*
            int num, maxNum = 0, lowNum = 0, diffrence = 0;

            Console.WriteLine("Enter a number ");
            num = int.Parse(Console.ReadLine());
            lowNum = num;
            maxNum = num;
            while(num != 0)
            {
                Console.WriteLine("Enter a number ");
                num = int.Parse(Console.ReadLine());
                if (num < lowNum && num != 0)
                    lowNum = num;

                if (num > maxNum)
                    maxNum = num;
            }
            diffrence = maxNum - lowNum;
            Console.WriteLine($"The diffrence between The highest number and the lowest num is {diffrence}");
            
            //q2
            int temp = 0,sum = 0, dayCount = 0;
            double avg;

            while(temp != 999)
            {
                Console.WriteLine("Enter a temp ");
                temp = int.Parse(Console.ReadLine());

                if (temp != 999)
                {
                    sum += temp;
                    dayCount++;
                }
            }
            avg = (double)sum / dayCount;
            Console.WriteLine($"The temp average is {avg}");
            */
            //q3

            int startNum1 = 1, startNum = 0, N, fibonach = 0;
            Console.WriteLine("Enter a number ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("1");


            fibonach = startNum + startNum1;

            while(N > fibonach)
            {
                fibonach = fibonach + startNum;
                startNum++;
                Console.WriteLine(fibonach);
            }
            
            //q4
            int x, y;
            Console.WriteLine("Enter a number ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number ");
            y = int.Parse(Console.ReadLine());

            while(x >= 0)
            {
                x = x - y;
            }
            Console.WriteLine($"{x+y}");
            
            Console.ReadLine();
        }
    }
}
