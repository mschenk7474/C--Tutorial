using System;

namespace Variables
{
    class Program
    {
        // enum from the last section
        enum Difficulty
            {
                Easy,
                Medium,
                Hard
            }
        static void Main(string[] args)
        {
            // ** Welcome to the Variables Module of the C# Tutorial! **
            
            // To start, we have two different ways to store data to use later in our programs

                // 1. A variable - which is a name given to a storage location in memory
                    // example of variable
            int number = 0;
            System.Console.WriteLine("The variable is {0}", number);
                // 2. A constant - which is an immutable value
                    // you would use constants when you wouldn't want the value changed
                    // example of constant
            const float Pi = 3.14f;
            System.Console.WriteLine("The constant is {0}", Pi);

            System.Console.WriteLine("==============================================");

            // Section 2 - Declaring Variables

                // C# is a case-sensitive language, meaning that in the following example, n and N are two different variables:
                // word of the wise: pay close attention to what you name your variables
            int n = 0;
            int N = 1;
            System.Console.WriteLine("The value of n is {0}, and the value of N is {1}", n, N);

                // Also, you have to intialize variables before using them, or the compiler will throw an error at you

                // You can also intialize variables in 2 different ways
                    // you can either intialize with the type, such as
                    int b = 0;
                    // or say something to the effect of
                    var c = 0;

                    // in both of these instances, each of these variables mean the same thing

                    // when we use var, the compiler infers what type we want to make the variable

                    // if you ever want to make sure your variable is a certain type, declare it
                    System.Console.WriteLine("The int is {0} and the var is {1}", b, c);

            System.Console.WriteLine("==============================================");
            // Section 3 - Identifiers

                // With identifiers, or better known as variable names, you can't start them with the following things:
                    // can't start with a number, have spaces, be a reserved word (like String)
                    // make sure to use meaningful names
            int age = 40;
            String myName = "Bob";

            System.Console.WriteLine("My meaningful name is {0} and my age is {1}", myName, age);

            System.Console.WriteLine("==============================================");
            // Section 4 - Naming Conventions

                // We have two different types of naming conventions that are used the most in C#
                    // 1. Camel Case - used for local vairables
            int localZipcode = 37167;
                    // 2. Pascal Case - used for constants
            const int MaxZoom = 5;
            System.Console.WriteLine("My Camel Case variable is {0} and my age is {1}", localZipcode, MaxZoom);

                // there is also another convention used sometimes in C# called Hungarian Notation
                    // it is not used often but you may see it around, so I thought I would include it in this tutorial

            System.Console.WriteLine("==============================================");
            // Section 5 - Primitive Types
                
                // A primitive type is one that is built into a programming language, or can be catergorized as a basic structure

                // There are 4 different types of primitive types
                    // 1. Integral Numbers
                        // 1. Byte
                            // C# type: Byte
                            // .Net type: Byte
                            // Bytes: 1
                            // Range: 0-255
            byte byteNumber = 1;
                        // 2. Short
                            // C# type: Short
                            // .Net type: Int16
                            // Bytes: 2
                            // Range: -32768 to 32,767
            short shortNumber = 15150;
                        // 3. Int
                            // C# type: Int
                            // .Net type: Int32
                            // Bytes: 4
                            // Range: -2.1B to 2.1B
                            // * default type used by C# *
            int integerNumber = 1000000000;
                        // 4. Long
                            // C# type: Long
                            // .Net type: Int64
                            // Bytes: 8
                            // Range: really big number to really big number
            long longNumber = 1000000000000000;

            System.Console.WriteLine("The byte is {0}, the short is {1}, the int is {2}, and the long is {3}", byteNumber, shortNumber, integerNumber, longNumber);
                    // 2. Real Numbers
                        // 1. Float
                            // C# type: Float
                            // .Net type: Single
                            // Bytes: 4
                            // Range: -3.4 x 10^38 to 3.4 x 10^38
            float floatNumber = 3.141561f; // have to include the f per not being default type
                        // 2. Double
                            // C# type: Double
                            // .Net type: double
                            // Bytes: 8
                            // Range: really big number to really big number
                            // * default type in C# when it comes to real numbers*
            double doubleNumber = 14.5451616451;
                        // 3. Decimal
                            // C# type: Decimal
                            // .Net type: decimal
                            // Bytes: 16
                            // Range: -7.9 x10^28 to 7.9 x 10^28
            decimal decimalNumber = 7.51245m; // have to use m per not being default type

            System.Console.WriteLine("The float is {0}, the double is {1}, and the decimal is {2}", floatNumber, doubleNumber, decimalNumber);
                    // 3. Character
                        // 1. Char
                            // C# type: Char
                            // .Net type: char
                            // Bytes: 2
                            // Range: unicode characters
            char oneChar = 'm'; // denoted by the single quotes, double quotes is reserved for string
                    // 4. Boolean
                        // 1. Bool
                            // C# type: Bool
                            // .Net type: boolean
                            // Bytes: 1
                            // Range: t/f
            bool isBool = true;

            System.Console.WriteLine("The char is {0}, and the bool is {1}", oneChar, isBool);

            System.Console.WriteLine("==============================================");
            // Section 6 - Non-Primititve Types

                // Non-primitive types are ones that are not prebuilt into the language, which you have to call libraries to use
                
                // There are 4 different types of non-primitive types
                    // 1. String
                        // a string is a collection of characters 
            String myNameInAString = "BillyBob";
            System.Console.WriteLine("My string is {0}", myNameInAString);
                    // 2. Array
                        // an array is a collection of values all contained in a single variable
            int[] integerArray = {1,2,3,4,5};
            foreach(var value in integerArray)
            {
                System.Console.WriteLine("The value is {0}", value);
            }
                    // 3. Enum
                        // enum is a special class that represents a group of constants
                            // look above main for enum 
            var easyRating = Difficulty.Easy;
            System.Console.WriteLine("The Enum rating is {0}", easyRating);
                    // 4. Class (which will be covered in a different module titled 'classes')



        }
    }
}
