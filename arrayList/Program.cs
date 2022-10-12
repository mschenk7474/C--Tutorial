using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to the ArrayList Module of the C# Tutorial

            // when it comes to arrayLists, we have to import another namespace to do so
            /* as you can see in the header, we imported system.collections, which is how 
            we are going to be able to use arrayList */

            /* simply put, an arrayList is a dynamic array, meaning it can increase and 
            decrease in size depending on what the user or programmer would like. In other
            terms, an arrayList is a colleciton of an object that can be indexed individually */

            /* there are three ways you can construct an arrayList:
                    1. the way that is shown below, which will create an instance of arrayList
                    which is empty
                    2. ArrayList(Int32): again, this creates an instance of arrayList which is empty
                    but has the specified type of an int
                    3. ArrayList(ICollection): this constructor is used to create an arrayList
                    intialized with the elements from the specified collecion passed in by 
                    reference and has the same capacity of the colleciton passed */ 

            // you then create a arrayList like so:
            ArrayList myList = new ArrayList();

            // you could also declare the arrayList like this:
            var mySecondList = new ArrayList();
            
            /* there are many different functions that arrayList has available, I will be 
            highlighting the most popular and useful ones here */

            // add
                // can add different types of variables to the array
            myList.Add(15);
            myList.Add('M');
            myList.Add("Harry");
            myList.Add(45);
            myList.Add(55);
            myList.Add(65);
            myList.Add(75);
                foreach (var element in myList)
                {
                    System.Console.WriteLine("Added Item: {0}", element);
                }
            System.Console.WriteLine("==============================================");
            // count 
                // shows the count of the elements in the arrayList
            System.Console.WriteLine("The count of the elements in the list is {0}", myList.Count);
            System.Console.WriteLine("==============================================");
            // capacity
                // displays the current capacity of the arrayList
            System.Console.WriteLine("The capacity of the list is {0}", myList.Capacity);
            System.Console.WriteLine("==============================================");
            // remove
                // removes the item passed in the parameters of the function
            myList.Remove(45);
            foreach (var element in myList)
                {
                    System.Console.WriteLine("Item: {0}", element);
                }
            
            System.Console.WriteLine("==============================================");
            // remove at
                // removes the element at the index passed to the remove at function
            myList.RemoveAt(0);
            foreach (var element in myList)
                {
                    System.Console.WriteLine("Item: {0}", element);
                }

            System.Console.WriteLine("==============================================");
            // remove range
                // removes a range of values between two certain indexes
            myList.RemoveRange(1, 3);
            foreach (var element in myList)
                {
                    System.Console.WriteLine("Item: {0}", element);
                }
            

            System.Console.WriteLine("==============================================");
            // clear
                // removes all elements from the arrayList
            myList.Clear();
            System.Console.WriteLine("The count of the elements in the list is {0}", myList.Count);

            System.Console.WriteLine("==============================================");
            // sort
                // using the QuickSort algorithm, sort sorts the items of an array into ascending order
            myList.Add(55);
            myList.Add(5);
            myList.Add(35);
            myList.Add(50);
            myList.Add(32);
            myList.Add(0);
            myList.Add(2);

            System.Console.WriteLine("Array before sort:");

            foreach (var element in myList)
                {
                    System.Console.WriteLine("Item: {0}", element);
                }
            
            System.Console.WriteLine(" ");

            myList.Sort();

            System.Console.WriteLine("Array after sort:");
            foreach (var element in myList)
                {
                    System.Console.WriteLine("Item: {0}", element);
                }
        }
    }
}