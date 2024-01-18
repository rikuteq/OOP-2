using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Relation
    {
        public string RelationshipType;
        
        public Relation(string RelationshipType)
        {
            this.RelationshipType = RelationshipType;
        }
        
        public void ShowRelationShip(Person firstPerson, Person secondPerson)
        {
            Console.WriteLine($"Relationship between {firstPerson.firstName} and {secondPerson.firstName} is: {this.RelationshipType}");
        }
    }
   
}
