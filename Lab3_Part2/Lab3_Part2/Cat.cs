using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Interface
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Height {  get; set; }
        public string Color {  get; set; }
        public int Age {  get; set; }
        
        public Cat(string name, string height, string color, int age) 
        {
            this.Name = name;
            this.Height = height;
            this.Color = color;
            this.Age = age;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public virtual string GetHeight()
        {
            return this.Height;
        }
        public virtual void SetHeight(string height)
        {
            this.Height = height;
        }
        public virtual string GetColor()
        {
            return this.Color;
        }
        public virtual void SetColor(string color)
        {
            this.Color = color;
        }
        public virtual int GetAge()
        {
            return this.Age;
        }
        public virtual void SetAge(int age)
        {
            this.Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry()
        {
            return "Meow!";
        }

    }
}
