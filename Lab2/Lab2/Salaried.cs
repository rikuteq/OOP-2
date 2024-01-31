using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Salaried:Employee
    {
        protected double salary;

        public Salaried():base("", "", "", "", 0, "", "")
        {
            this.salary = 0;
        }
        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary):base(id, name, address, phone, sin, dob, dept)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary;
        }
        
        /*public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }*/

        public virtual double GetPay()
        {
            return this.salary / 52;
        }
        public override string ToString()
        {
            return $"Salaried Details: \n" +
                $"ID: {this.id} \n" +
                $"Name: {this.name} \n" +
                $"Address: {this.address} \n" +
                $"Phone: {this.phone} \n" +
                $"SIN: {this.sin} \n" +
                $"DoB: {this.dob} \n" +
                $"Dept: {this.dept} \n" +
                $"Salary: {this.salary}";
        }
    }
}
