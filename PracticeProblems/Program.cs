using System;


namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, j, k;
            for (int i = 1; i <= 7; i++)
            {
                for (j = 1; j<= i; ++j)
                    Console.Write(j);
                for(k = 7 - i; k >=1; k--)
                    Console.Write("");
                Console.Write("\n");
            }
            Console.ReadLine();

            /* Console.WriteLine("Please enter your student's score: ");
            int studentScore = int.Parse(Console.ReadLine());

            if (studentScore >= 90)
                Console.WriteLine("The student's letter grade for a(n) {0} is an A", studentScore);
            if (studentScore >= 70 && studentScore < 90)
                Console.WriteLine("The student's letter grade for a(n) {0} is a B", studentScore);
            if (studentScore >= 50 && studentScore < 70)
                Console.WriteLine("The student's letter grade for a(n) {0} is a C", studentScore);
            if (studentScore < 50)
                Console.WriteLine("The student's letter grade for a(n) {0} is an F", studentScore);
            else
            {
                Console.WriteLine("Please renter the grade.");
            }
            Console.ReadLine();
            */
            /*int x, y, z;
            Console.WriteLine("Please enter three values");
            Console.WriteLine("Value for integer 1: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Value for integer 2: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Value for integer 3: ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered the following integers {0}, {1}, {2}", x, y, z);
            if (x > y)
                Console.WriteLine(x + " is greater than " + y);
            if (x > z)
                Console.WriteLine(x + " is greater than " + z);
            if (y > x)
                Console.WriteLine(y + " is greater than " + x);
            if (z > x)
                Console.WriteLine(z + " is greater than " + x);
            if (y > z)
                Console.WriteLine(y + " is greater than " + z);
            if (z > y)
                Console.WriteLine(z + " is greater than " + y);
            else 
                Console.WriteLine("I'm not sure how to compare those numbers");
            Console.ReadLine();
            */
        }
    }
}
