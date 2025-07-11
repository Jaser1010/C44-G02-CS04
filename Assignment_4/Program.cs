using System;
using System.Text;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Print all numbers between 1 and a given number.
            /*
            Console.WriteLine("Q1: Print numbers from 1 to N");
            Console.Write("Input: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            for (int i = 1; i <= number1; i++)
            {
                Console.Write(i);
                if (i < number1)
                {
                    Console.Write(", ");
                }
            }
            */
            #endregion

            #region Q2 - Print a multiplication table up to 12.
            /*
            Console.WriteLine("Q2: Multiplication Table up to 12");
            Console.Write("Input: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number2 * i + " ");
            }
            */
            #endregion

            #region Q3 - Print all even numbers between 1 and a given number.
            /*
            Console.WriteLine("Q3: Print Even Numbers");
            Console.Write("Input: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            for (int i = 2; i <= number3; i += 2)
            {
                Console.Write(i + " ");
            }
            */
            #endregion

            #region Q4 - Calculate the power of a number.
            /*
            Console.WriteLine("Q4: Calculate Power");
            Console.Write("Input: ");
            string[] inputs4 = Console.ReadLine().Split(' ');
            int baseNum = int.Parse(inputs4[0]);
            int exponent = int.Parse(inputs4[1]);
            long result4 = 1; // Use long to prevent overflow with large results
            for (int i = 0; i < exponent; i++)
            {
                result4 *= baseNum;
            }
            Console.WriteLine("Output: " + result4);
            */
            #endregion

            #region Q5 - Calculate total, average, and percentage of five subjects.
            /*
            Console.WriteLine("Q5: Calculate Total, Average, and Percentage");
            Console.Write("Input - Enter Marks of five subjects: ");
            string[] marksInput = Console.ReadLine().Split(' ');
            double totalMarks = 0;
            for(int i = 0; i < marksInput.Length; i++)
            {
                totalMarks += Convert.ToDouble(marksInput[i]);
            }
            double averageMarks = totalMarks / marksInput.Length;
            double percentage = ( averageMarks / totalMarks ) * 100;

            Console.WriteLine("Output: Total marks = " + totalMarks);
            Console.WriteLine("Average Marks = " + averageMarks);
            Console.WriteLine("Percentage = " + percentage + "%");
            */
            #endregion

            #region Q6 - Reverse a string.
            /*
            Console.WriteLine("Q6: Reverse a String");
            Console.Write("Input a string: ");
            string originalString = Console.ReadLine();
            string reversedString = "";
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reversedString += originalString[i];
            }
            Console.WriteLine("Reversed string: " + reversedString);
            */
            #endregion

            #region Q7 - Reverse an integer.
            /*
            Console.WriteLine("Q7: Reverse an Integer");
            Console.Write("Input an integer: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int reversedNum = 0;
            int remainder;
            while (num7 != 0)
            {
                remainder = num7 % 10;
                reversedNum = reversedNum * 10 + remainder;
                num7 /= 10;
            }
            Console.WriteLine("Reversed integer: " + reversedNum);
            */
            #endregion

            #region Q8 - Find prime numbers within a range.
            /*
            Console.WriteLine("Q8: Find Prime Numbers in a Range");
            Console.Write("Input starting number of range: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range: ");
            int endNum = int.Parse(Console.ReadLine());

            Console.Write($"The prime numbers between {startNum} and {endNum} are: ");
            for (int i = startNum; i <= endNum; i++)
            {
                if (i <= 1) continue; // 0 and 1 are not prime
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            */
            #endregion

        }
    }
}
