using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
      class Program
        {
            public abstract class Employee
            {
                public int ID { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }

                public string GetFullName()
                {
                    return "Sir Your Full Name is  " + this.FirstName + " " + LastName;
                }

                public abstract int GetMonthlySalary();
            }

            public class PermanentEmployee : Employee
            {


                public int AnnualSalary { get; set; }

                public override int GetMonthlySalary()
                {
                    return this.AnnualSalary / 12;
                }

            }

            public class ContractEmployee : Employee
            {
                public int HourlyPay { get; set; }
                public int TotalHoursWorked { get; set; }

                public override int GetMonthlySalary()
                {
                    return this.HourlyPay * this.TotalHoursWorked;
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine(" Check the Range Of Integer");
                Console.WriteLine(int.MaxValue);
                var pe = new PermanentEmployee();
                pe.FirstName = "Dennis";
                pe.LastName = "Ritchie";
                pe.AnnualSalary = 180000;

                var ce = new ContractEmployee();
                ce.FirstName = "Anil";
                ce.LastName = "Srivastava";
                ce.HourlyPay = 2000;
                ce.TotalHoursWorked = 6;

                Console.WriteLine(pe.GetFullName());
                Console.WriteLine(pe.GetMonthlySalary());

                Console.WriteLine(ce.GetFullName());
                Console.WriteLine(ce.GetMonthlySalary());

            }
        }
    }

