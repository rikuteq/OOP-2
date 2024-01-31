using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Wages:Employee
    {
        protected double rate;
        protected double hours;

        public Wages():base("","","","",0,"","")
        {
            this.rate = 0;
            this.hours = 0;
        }
        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours):base(id, name, address, phone, sin, dob, dept)
        {
            this.rate = rate;
            this.hours = hours;
        }

        public double GetRate()
        {
            return this.rate;
        }

        public double GetHours()
        {
            return this.hours;
        }
        /* public double Rate
        {
            get { return this.rate; }
            set { this.rate = value; }
        }
        public double Hours
        {
            get { return this.rate; }
            set { this.rate = value; }
        }*/

        public virtual double GetPay()
        {
            if(this.hours > 40)
            {
                return (this.rate * 40) + ((this.rate * 1.5) * (this.hours - 40));
            }
            else
            {
                return this.rate * this.hours;
            }
        }
        
        public override string ToString()
        {
            return $"Wages Details: \n" +
                $"ID: {this.id} \n" +
                $"Name: {this.name} \n" +
                $"Address: {this.address} \n" +
                $"Phone: {this.phone} \n" +
                $"SIN: {this.sin} \n" +
                $"DoB: {this.dob} \n" +
                $"Dept: {this.dept} \n" +
                $"Rate: {this.rate} \n" +
                $"Hours: {this.hours}";
        }
    }
}
