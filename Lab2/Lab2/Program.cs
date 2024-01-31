using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Program:Wages
    {
        static void Main(string[] args)
        {
            //Fill a list with objects based on the supplied data file

            string[] data = File.ReadAllLines("C:\\Users\\elias\\Projects\\Lab2\\Lab2\\Resources\\employees.txt");
            List<Employee> empList = new List<Employee>();
            List<Wages> wagedList = new List<Wages>();
            List<Salaried> salList = new List<Salaried>();
            List<PartTime> pTimeList = new List<PartTime>();

            foreach (string line in data)
            {
                string[] splits = line.Split(':');                               
                string id = splits[0];
                string name = splits[1];
                string address = splits[2];
                string phone = splits[3];

                long sin;
                bool t = long.TryParse(splits[4], out sin);

                string dob = splits[5];
                string dept = splits[6];


                if (id.StartsWith("0") || id.StartsWith("1") || id.StartsWith("2") || id.StartsWith("3") || id.StartsWith("4"))
                {
                    double salary;
                    bool s = double.TryParse(splits[7], out salary);
                    Salaried salaried = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                    salList.Add(salaried);
                }
                else if (id.StartsWith("5") || id.StartsWith("6") || id.StartsWith("7"))
                {
                    double rate;
                    bool r = double.TryParse(splits[7], out  rate);
                    
                    double hours;
                    bool h = double.TryParse(splits[8], out hours);
                    Wages waged = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);
                    wagedList.Add(waged);
                }
                else
                {
                    double rate;
                    bool r = double.TryParse(splits[7], out rate);
                    
                    double hours;
                    bool h = double.TryParse(splits[8], out hours);
                    PartTime partTime = new PartTime(id, name, address, phone, sin, dob, dept, rate, hours);
                    pTimeList.Add(partTime);
                }


                Employee employee = new Employee(id, name, address, phone, sin, dob, dept);
                empList.Add(employee);
                
            }                        
            //Calculate and return the average weekly pay for all employees
            double total = 0;
            int count = 0;

            foreach (Wages waged in wagedList)
            {
                total += waged.GetPay();
                count++;
            }
            
            foreach(Salaried salaried in salList)
            {
                total += salaried.GetPay();
                count++;
            }
            
            foreach(PartTime pTime in pTimeList)
            {
                total += pTime.GetPay();
                count++;
            }
            double average = total / count;
            Console.WriteLine($"The average weekly pay for all employees is: {average}");


            //Calculate and return the highest weekly pay for the wage employees, including the name of the employee
            double max = wagedList.Max(employee => employee.GetPay());
            foreach (Wages employee in wagedList)
            {
                if(employee.GetPay() == max)
                {
                    Console.WriteLine($"{employee.GetName()} has the highest weekly pay with a wage of {max}");
                }
            }


            //Calculate and return the lowest salary for the salaried employees, including the name of the employee
            double min = salList.Min(employee => employee.GetPay());
            foreach (Salaried employee in salList)
            {
                if (employee.GetPay() == min)
                {
                    Console.WriteLine($"{employee.GetName()} has the lowest salary with a salary of {min}");
                }
            }


            //What percentage of the company's employees fall into each employee category?
            double totalPeople = empList.Count;  //9 Total Employees

            double salariedPercent = (salList.Count / totalPeople) * 100;
            double wagedPercent = (wagedList.Count / totalPeople) * 100;
            double pTimePercent = (pTimeList.Count / totalPeople) * 100;

            Console.WriteLine($"{salariedPercent}% of employees are Salaried \n" +
                $"{wagedPercent}% of employees are Waged \n" +
                $"{pTimePercent}% of employees are Part Time");


        }
    }
}
