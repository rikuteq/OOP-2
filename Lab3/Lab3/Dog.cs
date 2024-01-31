using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dog : Animal
    {
        public Dog(string name, string color, int age):base("","",0) 
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        
       
        public override string ToString()
        {
            return $"Dog Details: \n" +
                $"Name: {this.name} \n" +
                $"Color: {this.color} \n" +
                $"Age: {this.age}";
        }
    }
}
