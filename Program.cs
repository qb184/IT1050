using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            // [type] [name]

            // When you instantiate (create) a new object, it automatically
            // gets member variables created inside it, which were specified
            // inside the class.

            Person p1 = new Person(); // Main Program Variable Declaration 1
            Person p2 = new Person(); // Main Program Variable Declaration 2

            p1.spouse = new Person(); // p1 Member Variable
            p2.spouse = new Person(); // p2 Member Variable

            Console.WriteLine("Enter Information for p1");
            Console.WriteLine("\n");

            p1.askUser();
            p1.askSpouse();

            Console.WriteLine("\n");
            Console.WriteLine("Enter information for p2");
            Console.WriteLine("\n");

            p2.askUser();
            p2.askSpouse();

            Console.WriteLine("\n");
             
            p1.printNameAndAge();
            p1.spouse.printNameAndAge();
            p2.printNameAndAge();
            p2.spouse.printNameAndAge();
            
            Console.WriteLine("\n");
            Console.WriteLine("Average age = " + Person.averageAge());

        }
    }
}
