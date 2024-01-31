using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    public class Employee
    {
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string dob;
        protected string dept;

        public Employee()
        {
            this.id = "";
            this.name = "";
            this.address = "";
            this.phone = "";
            this.sin = 0;
            this.dob = "";
            this.dept = "";
        }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }
        
        public string GetName()
        {
            return this.name;
        }
        /*public string Name
        {
            get { return this.name; } 
            set {  this.name = value; }
        }*/

        public override string ToString()
        {
            return $"Employee Details: \n" +
                $"ID: {this.id} \n" +
                $"Name: {this.name} \n" +
                $"Address: {this.address} \n" +
                $"Phone: {this.phone} \n" +
                $"SIN: {this.sin} \n" +
                $"DoB: {this.dob} \n" +
                $"Dept: {this.dept}";
        }
    }
}
