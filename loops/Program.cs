using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the Loops Module of the C# Tutorial

            // There are four different types of loops that are used in the C# language

            // We will talk about each and give an example for you to see how to use them while you write your software

            // 1. For Loops
                
                // with for loops in C#, they are set up like C and C++ for loops if you are familar with those languages

                // if not, no worries because we are going to go over it

                /* so a for loop in C# has 3 main parts when you call it: a before (intialization), 
                a condition that needs to be met, and an after(what happens during thee loop) */

                // this example will display all numbers bewtween 1-10 using what was spoken of above
                //before,   cond.,  after
            for (int i = 1; i < 11; i++)
            {
                System.Console.WriteLine("The number is {0}", i);
            }

            System.Console.WriteLine("==============================================");
            // 2. While Loops

                // with while loops, it is the same as above, C# while loops are the same as C and C++

                // while loops are loops that only go until they hit a certain condition.
                // referencing the for loop example, it only has the condtion statement

                // when using a while loop, the loop checks the condition *every* time before running what is inside the loop

                // in most cases, you can use a for loop and while loop interchangably, but it is up to you on which you would like to use

                // for example, this loop will also display the numbers 1-10
            
            int x = 1;
            while (x <= 10)
            {
                System.Console.WriteLine("The number is {0}", x);
                x += 1;
            }

            System.Console.WriteLine("==============================================");
            // 3. Do... While Loops

                // with do while loops, it's the same exact thing a while loops is, but with a twist

                /* when you use a while loop, the condition is at the beginining of the statement while in a do while loop, the condition 
                is at the end of the statement */

                /* this means that when you use a do while loop, whatever is in the do part of the loop will get ran once before the condition 
                is checked */

                // we will again show all the numbers from 1-10 as an example

            int y = 1;
            do
            {
                System.Console.WriteLine("The number is {0}", y);
                y ++;
            }
            while (y <= 10);

            System.Console.WriteLine("==============================================");
            // 4. Foreach Loops

                // with foreach loops, they are specifically used for accessing values of an array or a collection

                // this is nice when you want to hit every element of a list, say like numbers 1 - 10

            int[] oneThroughTen = {1,2,3,4,5,6,7,8,9,10};

            foreach (var value in oneThroughTen)
            {
                System.Console.WriteLine("The number is {0}", value);
            }

        }
    }
}