using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Write a C# program that prints your name, age, and favorite hobby on separate lines.
            Console.WriteLine("Task 1");
            Console.WriteLine("Name: Arwa Ahmed Ammosh");
            Console.WriteLine("Age: 22");
            Console.WriteLine("my favorite hobby: reading");
            #endregion
            #region  Question 2: Write a C# program that declares variables of different data types (int, double, string, bool) and assigns them values. Then, print these values to the console.
            Console.WriteLine("Task 2");
            int num1;
            bool istrue;
            double num2;
            string name;
            num1 = 1;
            num2 = 2.5;
            istrue = false;
            name = "Arwa";
            Console.WriteLine($"num1: {num1}\nnum2: {num2}\nisTrue: {istrue}\nname: {name}");
            #endregion
            #region Question 3: Write a C# program that converts a temperature value from Celsius to Fahrenheit. The Celsius temperature should be stored in a variable.
            Console.WriteLine("Task 3");
            Console.Write("Celsius value: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine($"Fahrenheit value: {fahrenheit}");
            #endregion
            #region Question 4: Write a C# program that takes two numbers as input and performs the following operations: addition, subtraction, multiplication, and division. Print the results of each operation.
            Console.WriteLine("Task 4");
            Console.Write("Enter number1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Summation: {number1 + number2}");
            Console.WriteLine($"Subtruction: {number1 - number2}");
            Console.WriteLine($"Multiplication: {number1 * number2}");
            Console.WriteLine($"Divsion: {number1 / number2}");
            #endregion
            # region Question 5: Write a C# program that calculates the area of a rectangle. The program should prompt the user to enter the length and width of the rectangle, and then calculate and display the area.
            Console.WriteLine("Task 5");
            Console.Write("Enter the value of length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of rectangle: {length * width}");

            #endregion
            #region Question 6: Write a C# program that takes an integer as input and checks if it is even or odd. Print a message indicating whether the number is even or odd.
            Console.WriteLine("Task 6");
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");

            }
            #endregion
            #region  Question 7: Write a C# program that prompts the user to enter their age. If the age is 18 or older, print "You are eligible to vote." If the age is less than 18, print "You are not eligible to vote."
            Console.WriteLine("Task 7");
            Console.Write("Enter your Age :");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            #endregion

            #region Question 8: Write a C# program that simulates a simple grading system. The program should prompt the user to enter a score (0-100), and then print the corresponding grade based on the following criteria:
            //90 - 100: A
            //80 - 89: B
            //70 - 79: C
            //60 - 69: D
            //Below 60: F
            Console.WriteLine("Task 8");
            char grade = ' ';
            Console.Write("Enter degree: ");
            double degree = Convert.ToDouble(Console.ReadLine());
            if (degree >= 90 && degree <= 100)
            {
                grade = 'A';
            }
            else if (degree >= 80 && degree <= 89)
            {
                grade = 'B';

            }
            else if (degree >= 70 && degree <= 79)
            {
                grade = 'C';

            }
            else if (degree >= 60 && degree <= 69)
            {
                grade = 'D';

            }
            else if (degree < 60)
            {
                grade = 'F';

            }
            Console.WriteLine($"Grade: {grade}");
            #endregion

            #region  Write a C# program that checks if a number entered by the user is positive, negative

            Console.WriteLine("Task 9");
            Console.Write("Enter number: ");
            double checkNum = Convert.ToDouble(Console.ReadLine());
            if (checkNum > 0)
            {
                Console.WriteLine($"{checkNum} is postive");
            }
            else if (checkNum < 0)
            {
                Console.WriteLine($"{checkNum} is negative");

            }
            #endregion

            #region Write a C# program that checks if a rectangle with given length and width is a square.
            Console.WriteLine("Task 10");
            Console.Write("Enter the value of length: ");
            double recLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of width: ");
            double recWidth = Convert.ToDouble(Console.ReadLine());
            if (recWidth == recLength)
            {
                Console.WriteLine("It is a Sequare");
            }
            else
            {
                Console.WriteLine("It isn't a Sequare");

            }
            #endregion

            Console.ReadKey();


        }
    }
}
