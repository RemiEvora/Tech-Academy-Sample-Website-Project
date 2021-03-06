﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg140
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees. 
            //Each employee should have a first and last name, as well as an Id.
            //At least two employees should have the first name "Joe".

            List<Employee> EmployeeList = new List<Employee>
            {
                new Employee("Joe", "Johnson", 000001),
                new Employee("Sarah", "Connor", 000002),
                new Employee("Adam", "Sanders", 000003),
                new Employee("Joe", "Black", 000004),
                new Employee("Lisa", "Simpson", 000005),
                new Employee("Frank", "Castle", 000006),
                new Employee("James", "Bond", 000007),
                new Employee("Matthew", "Murdock", 000008),
                new Employee("Daniel", "Rand", 000009),
                new Employee("Jean", "Grey", 000010)
            };

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".
            

            List<Employee> joeList = new List<Employee>();
            
            foreach(Employee name in EmployeeList)
            {

                if (name.FName == "Joe")
                {
                    joeList.Add(name); 
                    Console.WriteLine("{0} , {1} , {2}", name.FName, name.LName, name.IDNumber); 
                    Console.ReadLine();
                }
                
            }


            //3.Do the same thing again, but this time with a lambda expression.
            List <Employee> joeList2 = EmployeeList.Where(x => x.FName == "Joe").ToList();

            foreach (Employee name in joeList2)
            {
                Console.WriteLine("{0} , {1} , {2}", name.FName, name.LName, name.IDNumber);
                Console.ReadLine();

            }

            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> numberList = EmployeeList.Where(y => y.IDNumber > 000005).ToList();

            foreach (Employee name in numberList)
            {
                Console.WriteLine("{0} , {1} , {2}", name.FName, name.LName, name.IDNumber);
                Console.ReadLine();
            }

        }
    }
}







