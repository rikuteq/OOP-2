using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Interface
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Height { get; set; }
        string Color { get; set; }
        int Age { get; set; }

        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetHeight()
        {
            return this.Height;
        }
        public void SetHeight(string height)
        {
            this.Height = height;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }
        public int GetAge()
        {
            return this.Age;
        }
        public void SetAge(int age)
        {
            this.Age = age;
        }

        abstract void Eat();
        string Cry();
    }
}
