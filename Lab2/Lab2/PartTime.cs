using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PartTime:Employee
    {
        protected double rate;
        protected double hours;

        public PartTime():base("","","","",0,"","")
        {
            this.rate = 0;
            this.hours = 0;
        }
        
        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours):base(id, name, address, phone, sin, dob, dept)
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

        /*public double Rate
        {
            get { return this.rate; }
            set { this.rate = value; }
        }

        public double Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }*/
        public void SetHours(double value)
        {
            this.hours = value;
        }

        public virtual double GetPay()
        {
            return this.rate * this.hours;
        }
        
        public override string ToString()
        {
            return $"Part Time Details: \n" +
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
