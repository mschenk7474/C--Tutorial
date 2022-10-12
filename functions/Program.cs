using System;

namespace Functions
{
    public class Example 
    {
        public void display()
        {
            System.Console.WriteLine("Hello World");
        }
        public void display(int x, int y)
        {
            System.Console.WriteLine("X = {0} and Y = {1}", x, y);
        }

        public int add(params int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the Functions Module of the C# Tutorial

            // Section 1: Introduction to Functions

                /* functions, also known as methods, are blocks of code where the purpose is to 
                comeplete a certain task, often denoted by the name of the function */

                /* for example, we have the Main function here, which acts as the main function
                of the entirity of the piece of software. Almost always, Main is where the program
                starts and end, and everything flows around it*/

                /* there are two things to the signature of method, or in simpler terms, parts of 
                a method:
                    1. name
                    2. number and type of parameters*/
                int x = 0;
                int y = 1;
                var demonstration = new Example();

            // in this example, the name is (display) and the num and types of params are (2 and int)
            demonstration.display(x, y);
            System.Console.WriteLine("==============================================");

            // Section 2: Overloading Methods

                /* what overloading a method means is when you have a method with the same name but it 
                has different signatures */
            demonstration.display();
            demonstration.display(x, y);

                /* as you can see, although the methods are named the same, the types and number of parameters
                taken are different. This is useful for situations like this when we might want to display different
                things that are dependent on what we pass to the function as parameters*/
            System.Console.WriteLine("==============================================");
            // Section 3: Methods with Varying Number of Parameters

                /* sometimes, we may want to pass display more than 2 ints to display back to the user. How can we do
                that so it can be dynamically changed everytime we want to display?*/

                /* we use the params key word to solve this issue*/

                /* as you can see here, since we used params in the add function above, we can pass it as many nums as we want
                in whichever way we want, as listed below */ 
            var sum = demonstration.add(new int[]{1,2,3,4,5,6,7,8,9});
            var sumTwo = demonstration.add(1,2,3,4,5,6,7,8,9);

            System.Console.WriteLine("1st sum is {0} and the 2nd sum is {1}", sum, sumTwo);

            
        }
    }
}