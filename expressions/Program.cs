using System;

namespace Experssions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the Expressions Module of the C# Tutorial

            // Section 1: What is an Expression

                /* an expression in C# is a combination of operands (variables, literals, or 
                method calls) and operators that can be evaluated to a single value. An expression 
                must have at least one operand byt may not have any operator */

                /* in this example below, the number 15 is a expression, (age = 15) is also an expression, 
                and so is ("My age is {0}", age) */
            int age;
            age = 15;
            System.Console.WriteLine("My age is {0}", age);

                // in this next example, the only expression here is (myAge + yourAge + momAge)
            int myAge, yourAge, momAge, sum;
            myAge = 15;
            yourAge = 16;
            momAge = 56;
            sum = myAge + yourAge + momAge;

                /* in this last example, (myAge >= 15 && momAge <= 60) is an expression and so is 
                ("Go work and get some money") */
            if (myAge >= 15 && momAge <= 60)
            {
                System.Console.WriteLine("Go work and get some money");
            }

            System.Console.WriteLine("==============================================");
            // Section 2: What is an Operator

                // there are different types of operators that do different things

                // we will go over each type and all of the operators associated with each type

                // 1. Arithmetic Operators
                    
                    /* we do simple math operations with arithmetic operators, such as adding, 
                    subtracting, and even incrementing */
            
            int x = 20;
            int y = 5;
            int sumXAndY = 0;
            int difference = 0;
            double product = 0;
            float quotient = 0f;
            int remainder = 0;


            // add
            sumXAndY = x + y;
            // subtract
            difference = x - y;
            //multiplication
            product = x * y;
            //division
            quotient = x / y;
            // remainder
            remainder = x % y;
            // increment
            x += 1;
            x ++;
            // decrement
            y -= 1;
            y --;

            System.Console.WriteLine("The sum is {0}, the difference is {1}, the product is {2}, the quotient is {3}, the remainder is {4}, X after 2 increments is {5}, and Y after two decrements is {6}", sumXAndY, difference, product, quotient,remainder, x, y);
            System.Console.WriteLine("==============================================");
                // 2. Comparison Operators

                    /* comapres two variables and returns a boolean value */
                    
                    /* in the case of the example, the message will only 
                    be outputted to the screen if the boolean value returns true*/
            
            // equal
            if (x == y)
            {
                System.Console.WriteLine("X and Y are equal");
            }
            // not equal
            if (x != y)
            {
                System.Console.WriteLine("X and Y are not equal");
            }
            // greater than
            if (x > y)
            {
                System.Console.WriteLine("X is greater than Y");
            }
            // greater than or equal to
            if (x >= y)
            {
                System.Console.WriteLine("X is greather than or equal to Y");
            }
            // less than or equal to
            if (x <= y)
            {
                System.Console.WriteLine("X is less than or equal to Y");
            }
            // less than
            if (x < y)
            {
                System.Console.WriteLine("X is less than Y");
            }

            System.Console.WriteLine("==============================================");
                // 3. Assignment Operators

                    // when you assign something to a value
            // assignment
            int z = 12;
            System.Console.WriteLine("What Z is originally: {0}", z);
            // addition assignment
            z += 1;
            System.Console.WriteLine("What Z looks like after addition assignment: {0}", z);
            // subtraction assignment
            z -= 3;
            System.Console.WriteLine("What Z looks like after subtraction assingment: {0}", z);
            // multiplication assignment
            z *= 4;
            System.Console.WriteLine("What Z looks like after multiplication assingment: {0}", z);
            // division assignment
            z /= 10;
            System.Console.WriteLine("What Z looks like after division assingment: {0}", z);

            System.Console.WriteLine("==============================================");    
                // 4. Logical Operators
                    /* sort of like comparison operators, but used mostly in conditional statements to 
                    compare two value */
            // and
            if (z == 4 && x == 32)
            {
                System.Console.WriteLine("Both conditions are met");
            }
            // or
            if (z == 4 || x == 32)
            {
                System.Console.WriteLine("One or the other condition have been met");
            }
            // not
            if (!(z == 5))
            {
                System.Console.WriteLine("Condition is not true");
            }

        }
    }
}