﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Lab6_Inheritance_And_Polymorphism_
{
   class Employee
    {
        //The below attribute is applicable to both Salaried and Salaried Commission Employees
        protected double base_salary;
        //Parameter Less Constructor usage is Nill,except it is used to invoke the Program in the main Function!
        public Employee()
        {
            base_salary = 0.0;
        }
        //The Belo Ctr is used to set the Base Salary for Both Salaried Employees and Salaried Commisioned Ones
        public Employee(double salary)
        {
            base_salary = salary;
        }
        //Virtual Function to calculate the salary ,Overriden by Derived Classes
        public virtual double calculateSalary()
        {
            return base_salary;
        }
        public void testTheService()
        {
            //The Function is used to test the service called in the main method !
            Console.WriteLine("*******************Welcome To Fight Club Enterprise Limited Employee Management System**********************");
            Console.WriteLine("Please Enter Your Name !");
            String name = Console.ReadLine();
            Console.WriteLine($"Hello {name},Are You A \n1)Salary Employee\n2)Hourly Employee\n3)Commisioned Employee\n4)Salary Commisioned Employee");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SalaryEmployee salaryEmployee = new SalaryEmployee(10000);
                    showInfo(salaryEmployee.calculateSalary());
                    break;
                case 2:
                    HourlyRateEmployee hourlyRateEmployee = new HourlyRateEmployee(1000);
                    Console.WriteLine($"Number of Hours Worked ?");
                    double hours = double.Parse(Console.ReadLine());
                    hourlyRateEmployee.setTime(hours);
                    showInfo(hourlyRateEmployee.calculateSalary());
                    break;
                case 3:
                    Console.WriteLine("Enter The Sales Made ");
                    CommisionedEmployee commisionedEmployee = new CommisionedEmployee();
                    double sales = double.Parse(Console.ReadLine());
                    commisionedEmployee.setSalesMade(sales);
                    showInfo(commisionedEmployee.calculateSalary());
                    break;
                case 4:
                    SalaryCommisionedEmployee salarycommisionedEmployee = new SalaryCommisionedEmployee(10000);
                    Console.WriteLine("Enter The Sales Made ");
                    double sales_made = double.Parse(Console.ReadLine());
                    salarycommisionedEmployee.setSales(sales_made);
                    showInfo(salarycommisionedEmployee.calculateSalary());
                    break;
                default:
                    Console.WriteLine("Please Select A Valid Option !");
                    break;

            }
        }
        private void showInfo(double amount)
        {
            Console.WriteLine($"Your Net Salary is Rs.{amount}");
        }
    }
    class SalaryEmployee:Employee
    {
      public SalaryEmployee()
        {
            base_salary = 0;
        }
        //Ctr reference to base class ctr
        public SalaryEmployee(double base_sal):base(base_sal)
        {}
        //overriden function to calculate the salary
        public override double calculateSalary()
        {
            return base_salary;
        }
    }
    class HourlyRateEmployee: Employee
    {
        //Hourly Rate Employees aren't paid a stable amount and are paid according to the time spend in the workspace
        double hours_worked;
        //rate per hour is initialised in the ctr
        double rate_per_hour;
        public HourlyRateEmployee()
        {
            hours_worked = 0;
            rate_per_hour = 0;
        }
        //We cannot set the rate directly in the main program as Employees cannot decide the rate 
        //Below Constructor is used to set the rate/ hour of the employee
        public HourlyRateEmployee(double rate)
        {
            rate_per_hour = rate;
        }
        //This function is used to set the overall time spend by the employee in the Office 
        public void setTime(double time_spend)
        {
            hours_worked = time_spend;
        }
        //Polymorphic function 
        public override double calculateSalary()
        {
            double final_sal = hours_worked * rate_per_hour;
            double additional_amount_per_hour = 200.00;
            //Terinery operator used so that workers who work for more than 40 gets extra pay
            double final_sal_after_change = ((hours_worked>40)?(final_sal+ ((hours_worked-40)* additional_amount_per_hour)) : final_sal);
            return final_sal_after_change;
        }
    }
    class CommisionedEmployee : Employee
    {
        protected double sales;
        public CommisionedEmployee()
        {
            sales = 0.0;
        }
        //Below Ctr Not Applicable to this class but only used for The Derived class of the current class
        public CommisionedEmployee(double base_sal_for_commission):base(base_sal_for_commission)
        {/*Constructor call to base class Employee */}
        public  void setSalesMade(double sales_made)
        {
            sales = sales_made;
        }
        public override double calculateSalary()
        {
            //We returned the only 75 percentage of the sales, as it is mentioned there !
            return sales*0.75;
        }
    }
    class SalaryCommisionedEmployee : CommisionedEmployee
    {

        public SalaryCommisionedEmployee() : base(0)
        {
            sales = 0;
        }
        public SalaryCommisionedEmployee(double base_sal) : base(base_sal)
        {
            //No need for body as it is set in the base class ctr itself
        }
        //We already have the function to retrive sales in the base class so no need for extra function
        public void setSales(double sales_now)
        {
            base.setSalesMade(sales_now);
        }
        //Since the company offered the SalariedCommisioned Employee a benefit of 10%increase in salary and percentage of sales
        public override double calculateSalary()
        {
            //The Calculation is 10% of increase in base salary+ and percentage of +base salary
            double final_sal=((base_salary*0.1)+ (sales*0.75) + base_salary);
            return final_sal;
        }
        
    }
   
}
