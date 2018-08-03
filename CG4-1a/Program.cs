using System;

namespace CG4_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user to enter a number. Loop from 2 to 20 and multiply
            //the loop value by the number the user entered and output the value each time.
            //When the loop is finished, output the sum of all previous values.

            //Ask user to input a number.
            Console.Write("Enter a number: ");

            //Assign a variable as a integer and print it to the console.
            int x = int.Parse(Console.ReadLine());

            //Assign integer variable, sum, and initialize the value of the variable sum.
            int sum = 0;
            
            //Create a "for" statement or iteration/loop statement.
            //This is to begin with a 2 and increment up by 1 until it reaches 20. 
            for (int i = 2; i <= 20; i++)
            {
                //Write code so that the user input, x, multiplys by loop (2 to 20 by integer x) and has an answer/result.
                int result = x * i;
                //Write code to have the sum of all the results of the multiplication (2 through 20 by x).
                sum = sum + result;
                //Print each multplcation action to console.  {0} being x (user input), {1} being 2 though 20, and
                //{2} being the result.
                Console.WriteLine(" {0} * {1} = {2}", x, i, result);


            }
            //Print to console the text below and the sum result.
            Console.WriteLine("The sum of the results equals:" + sum);
            Console.ReadLine();
        }
    }
}