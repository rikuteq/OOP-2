using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColor;
        public int age;
        public bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }
        public Relation relation;
        

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{this.personId}: {this.firstName} "+ $"{this.lastName}'s favorite color is {this.favoriteColor}");
        }
        public void ChangeFavoriteColor()
        {
            this.favoriteColor = "White";
        }
        public int GetAgeInTenYears()
        {
            return this.age + 10;
        }
        public override string ToString()
        {
            return $"Person ID: {this.personId}\n" +
                $"First Name: {this.firstName}\n" +
                $"Last Name: {this.lastName}\n" +
                $"Favorite Color: {this.favoriteColor}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking}";
        }
    }
}
