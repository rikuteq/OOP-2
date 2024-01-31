namespace Lab2_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Dog
            //Name
            Console.WriteLine("Enter a dog name: ");
            string nameInput = Console.ReadLine();

            //Height
            Console.WriteLine("Enter dogs height: ");
            string heightInput = Console.ReadLine();

            //Color
            Console.WriteLine("Enter dogs color: ");
            string colorInput = Console.ReadLine();
            
            //Age
            Console.WriteLine("Enter dogs age: ");
            string ageInput = Console.ReadLine();
            bool t = int.TryParse(ageInput, out int ageInputInt);

            //Object Creation
            Dog dog = new Dog(nameInput, heightInput, colorInput, ageInputInt);
            Console.WriteLine($"\n{dog.GetName()}, {dog.GetHeight()}, {dog.GetColor()}, {dog.GetAge()}");
            dog.Eat();
            Console.WriteLine(dog.Cry());

        //Cat
            //Name
            Console.WriteLine("\nEnter cats name: ");
            string catName = Console.ReadLine();

            //Height
            Console.WriteLine("Enter cats height: ");
            string catHeight = Console.ReadLine();

            //Color
            Console.WriteLine("Enter cats color: ");
            string catColor = Console.ReadLine();

            //Age
            Console.WriteLine("Enter cats age: ");
            string catAge = Console.ReadLine();
            bool a = int.TryParse(catAge, out int catAgeInt);

            //Object Creation
            Cat cat = new Cat(catName, catHeight, catColor, catAgeInt);
            Console.WriteLine($"\n{cat.GetName()}, {cat.GetHeight()}, {cat.GetColor()}, {cat.GetAge()}");
            cat.Eat();
            Console.WriteLine(cat.Cry());

            //List
            List<IAnimal> animals = new List<IAnimal>() { dog, cat };

            Console.WriteLine("\nList of Animal Names: ");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.GetName());
            }
        }
    }
}
