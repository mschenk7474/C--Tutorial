using System;
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the Conditionals Module of the C# Tutorial

            // we will be speaking of two different types of condtionals

            // 1. If/Else Statements
                /* now, you have probably already seen this in other modules, but if/else 
                statements are the way to compare two things to one another, and then be able 
                to do something when that comparison is made */

                /* the if statements only work if the values make the condition of the if 
                true/false, depending on what you are doing*/ 

            int x = 0;
            int y = 0;

            if (x == y)
            {
                System.Console.WriteLine("X and Y are equal to one another");
            }


            /* you can also use else if to say if the first if statement's conditional didn't return true, 
            then it would give another option to be displayed */

            else if (x != y)
            {
                System.Console.WriteLine("X and Y are not equal to one another");
            }

            /* we can also use else as well when we don't have a specific condition we want the end to be. 
            It is kind of like a "everything else" kind of way of lumping everything else together that is not 
            in the scope of the previous if and else if statements*/

            else
            {
                System.Console.WriteLine("I don't know what X and Y are");
            }
            
            System.Console.WriteLine("==============================================");
            // 2. Switch Statements
                /* switch statements are different from if/else statements because although they may have a conidtional, 
                the cases will not allow for operators to be used */
            
                // simple menu for the user to get some choices
            System.Console.WriteLine("Choose your favorite car brand:");
            System.Console.WriteLine("1. Ford");
            System.Console.WriteLine("2. Nissan");
            System.Console.WriteLine("3. Kia");
            System.Console.WriteLine("4. Alfa Romeo");
            System.Console.Write("Enter your selection here: ");
            int choice = Convert.ToInt32(Console.ReadLine());

                /* where the switch comes into play. As you can see below, with the cases for a switch statement, you have 
                to be very specific with what you want */ 

                /* if you are looking for a conditional statements that is very specific with its cases and doesn't need 
                operators, use the switch. Any other time, use if/else statements. Usage might differ depending on what you
                would like to do in your personal software*/
            switch (choice)
            {
                // Ford option
                case 1:
                    System.Console.WriteLine("Ford is a okay car brand");
                    break;
                // Nissan option
                case 2:
                    System.Console.WriteLine("Nissan is a cool car brand");
                    break;
                // Kia option
                case 3:
                    System.Console.WriteLine("Kia is a family car brand");
                    break;
                // Alfa Romeo option
                case 4:
                    System.Console.WriteLine("Alfa Romeo is a luxury car brand");
                    break;
                // invalid choice option
                default:
                    System.Console.WriteLine("Invalid choice, please try again");
                    break;
            }
            
        }
    }
}