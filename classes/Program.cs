using System;

namespace Classes
{
    public class Example
    {
        public int age;
        private int momAge;
        public static int count = 0;

        public Example()
        {
            
        }
        public Example(int Age)
        {
            this.age = Age;
            
        }

        public void display()
        {
            System.Console.WriteLine("Age is {0}", age);
            System.Console.WriteLine("Age declared in constructor is {0}", this.age);
        }
        
        public void setMomAge(int ageGiven)
        {
            momAge = ageGiven;
        }

        public int getMomAge()
        {
            return momAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the Classes Module of the C# Tutorial

            // Section 1: What is a Class
                /* a class is a building block of software. Within classes, we have two main
                parts that make up its anatomy:
                    1. data = represented by fields
                    2. behavior = represented by methods and functions */
            
            // Section 2: How to Declare a Class
                /* as you can see above, you declare a class in 3 different ways:
                    1. Public = can be used outside the scope of the class
                    2. Private = can only be used inside the class*/

            // Section 3: Creating and Using Objects of a Class
                /* an object of a class is when we want to call a class elsewhere and use its
                methods and attributes. We declare a new object by using the keyword new in 2
                different ways*/

                /* either way works perfectly fine, but the second is way easier to use and is
                used more frequently in C# programs */
            Example demonstration = new Example();
            var demonstrationTwo = new Example();

                /* how we use said object is fairly simple as well. Since we have the object,
                we can access the methods and attributes if they are public. There are ways to
                access the private methods and attributes of classes, and that is with getters
                and setters*/

                // using public methods and attributes
            demonstration.age = 15;
            demonstration.display();

                // using private attributes
            demonstration.setMomAge(55);
            System.Console.WriteLine("Mom's age is {0}", demonstration.getMomAge());

            System.Console.WriteLine("==============================================");
            // Section 4: Class Members
                /* with class members, there are two different types:
                    1. intstance
                        - these are accesible from an object, such as when we called the function
                        above
                    2. static
                        - these members are accessible from the class, such as when we call 
                        System.Console.WriteLine()*/
                
                /* why would we use static variables?
                    - we use these to only have one instance of the data in memory
                    - with the example below, we don't need more than one variable to write what
                    we want to the line. That is why we use the static variable in this situation*/

                /* you declare static variables by using the static key word, and an example can be 
                found in the example class above with the count variable */
            System.Console.WriteLine("Writing to the user");
            // have to use the class here put not being able to call from object
            System.Console.WriteLine("Here is the static count: {0}", Example.count); 

            System.Console.WriteLine("==============================================");
            // Section 5: Object Constructor
                /* an object constructor is a method that is called when an instance of a class is 
                created*/

                /* with object constructors, they have be the same name of the class they are in,
                and can't return anything */

                // an example can be found above titled (publix Example())

                /* now, you may notice that there is more than one constructor in the Example class,
                and that is something we like to call constructor overloading, which is to have multiple
                constructors who have the same name. */

                /* this is very useful when you may want to construct an object to something, but may want
                to construct another object to something completley different */
                int babyAge = 1;

                /* as you can see, since we have two constructors, I can pass either nothing, or pass an age
                to the constructor and both work due to constructor overloading */
                var demoThree = new Example();
                var demoFour = new Example(babyAge);

                demoThree.display();
                demoFour.display();

            System.Console.WriteLine("==============================================");
            // Section 6: Object Intializer
                /* an object intializer is syntax for quickly intializing an object without the need to call
                 one of the constructors*/

                // this is useful when you don't want to use multiple constructors in a class

                // the variables you call in this constructor must already be in the class you are calling

                var demoFive = new Example
                                {
                                    age = 15
                                    
                                };
                demoFive.display();
        }
    }
}