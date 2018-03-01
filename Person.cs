using System;
namespace Project2
{
    public class Person
    {
        public int age;
        public string firstName;
        public string lastName;
        public Person spouse;

        public static double sumOfAllAges;
        public static int count;

        public string getFullName()
        {
            return this.firstName + " " + this.lastName;
        }
     
        public void printNameAndAge()
        {
            Console.WriteLine(this.getFullName() + " (" + this.age + ")");
        }

        public void askUser()
        {
            Console.Write("What is your first name?         ");
            firstName = Console.ReadLine();
            Console.Write("What is your last name?          ");
            lastName = Console.ReadLine();
            Console.Write("How old are you?                 ");
            age = int.Parse(Console.ReadLine());
            count++;
            sumOfAllAges= sumOfAllAges + age;
        }

        public void askSpouse()
        {
            Console.Write("Are you married? (Yes/No)        ");
            string a = Console.ReadLine();
            if (a == "yes")
            {
                Console.Write("What is your spouse's name?      ");
                spouse.firstName = Console.ReadLine();
                Console.Write("How old is your spouse?          ");
                spouse.age = int.Parse(Console.ReadLine());
                spouse.lastName = lastName;
                count++;
                sumOfAllAges= sumOfAllAges + spouse.age;
            }
        }

        public static double averageAge()
        {
            return Person.sumOfAllAges/ Person.count;
        }
    }
}

      
       

    





