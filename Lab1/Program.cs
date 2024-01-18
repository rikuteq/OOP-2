using System.Security.Cryptography.X509Certificates;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Person Objects
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            //Gina
            person2.DisplayPersonInfo();
            Console.WriteLine(person3);
            //Ian
            person1.ChangeFavoriteColor();
            person1.DisplayPersonInfo();
            //Mary
            Console.WriteLine($"{person4.firstName} {person4.lastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            //Relationship stuff
            Relation sister = new Relation("Sister");
            Relation brother = new Relation("Brother");
            sister.ShowRelationShip(person2, person4);
            brother.ShowRelationShip(person1, person3);

            //Average Age
            List<Person> list = new List<Person>() {person1, person2, person3, person4 };
            double count = 0;
            double total = 0;
            foreach (Person person in list)
            {
                total += person.age;
                count++;
                double average = total / count;
                if (count==list.Count)
                {
                    Console.WriteLine($"The average age is: {average}");
                }
            }
                  
            //Youngest Person
            int min = list.Min(person => person.age);
            foreach (Person person in list)
            {
                if (person.age == min)
                {
                    Console.WriteLine($"Youngest Person is: {person.firstName} at age {min}");
                }
            }
            

            //Oldest Person
            int max = list.Max(person => person.age);
            foreach (Person person in list)
            {
                if (person.age == max)
                {
                    Console.WriteLine($"Oldest Person is: {person.firstName} at age {max}");
                }
            }

            //Start with M
            Console.WriteLine("Names that start with M:");
            foreach (Person person in list)
            {               
                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine(person.firstName);
                }
            }

            //Person information of the person that likes the color blue


            Console.WriteLine(person3);
            Console.WriteLine(person4);
            Console.WriteLine(person3);
        }
    }
}
