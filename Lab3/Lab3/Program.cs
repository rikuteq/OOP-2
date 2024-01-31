namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Dog
            //Name
            Console.WriteLine("Enter a dog name: ");
            string nameInput = Console.ReadLine();
            
            //Color
            Console.WriteLine("Enter dogs color: ");
            string colorInput = Console.ReadLine();
            
            //Age
            Console.WriteLine("Enter dogs age: ");
            string ageInput = Console.ReadLine();
            bool t = int.TryParse(ageInput, out int ageInputInt);
           
            //Object Creation
            Dog dog = new Dog(nameInput, colorInput, ageInputInt);
            Console.WriteLine($"{dog.GetName()}, {dog.GetColor()}, {dog.GetAge()}");


            //Name
            Console.WriteLine("Enter cats name: ");
            string catName = Console.ReadLine();

            //Color
            Console.WriteLine("Enter cats color: ");
            string catColor = Console.ReadLine();

            //Age
            Console.WriteLine("Enter cats age: ");
            string catAge = Console.ReadLine();
            bool a = int.TryParse(catAge, out int catAgeInt);

            //Object Creation
            Cat cat = new Cat(catName, catColor, catAgeInt);
            Console.WriteLine($"{cat.GetName()}, {cat.GetColor()}, {cat.GetAge()}");
            cat.Eat();
        }
    }
}
