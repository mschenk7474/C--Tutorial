using System;

namespace Inheritance
{
    public class Major
    {
        // field pertaining to anyone who is attending BYU-I
        public string byuiMajor = "My Brigham Young University Major is ";
        public void displayChant() // chant method for those who attend BYU-I
        {
            System.Console.WriteLine("Go Vikings!");
        }
    }

    public class SoftwareEngineering : Major 
    {
        // field pertaining to just software engineers
        public string myMajor = "Software Engineering"; 
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the Inheritance Module of the C# Tutorial

            /* inheritance simply means to be able to use different methods and attributes found
            in different classes. Often, these other categories are subcategories of one main
            category */

            /* for example, written above, we have a main category class, also known as a parent
            class, titled "Major". We then have a subcategory class, also known as a child class,
            titled SoftwareEngineering, and since we want SoftwareEngineering to inherit all of
            the methods and attributes of the Major class, we use the : to inherit all the
            information from that class*/

            /* this is usefully in many situaitons, as we won't have to rewrite the same code over
            and over again. Rather, we will just use the methods and attributes found in th parent
            class when we call the child class*/

            var college = new SoftwareEngineering();
            
            /* as we can see, since we declared the child class first, we are able to use methods and
            attributes for both the child and parent class. If we were to just call the parent class,
            we wouldn't be able to access anything from the child class SoftwareEngineering. */ 
            System.Console.WriteLine(college.byuiMajor + "" + college.myMajor);
            college.displayChant();

        }
    }
}