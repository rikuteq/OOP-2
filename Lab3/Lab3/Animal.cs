using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Animal
    {
        public string name;
        public string color;
        public int age;

       public Animal(string name, string color, int age) 
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }
        
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string value)
        {
            this.name = value;
        }
        
        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string value)
        {
            this.color = value;
        }
       
        public int GetAge()
        {
            return this.age;

        }
        public void SetAge(string value)
        {
            this.color = value;
        }

        public abstract void Eat();
    }
}
