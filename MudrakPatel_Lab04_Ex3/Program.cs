using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_Ex3
{
    class Program
    {
        public static string[] employeeNames = {
                "Alex",
                "Bruce",
                "Clint",
                "Donald",
                "Ebon",
                "Face"
            };
        static void Main(string[] args)
        {
            //SortedDictionary<int, Employee> created
            SortedDictionary<int, Employee> employeeSortedDictionary = 
                new SortedDictionary<int, Employee>();
            //Add some Employee objects to the SortedDictionary<int, Employee>
            //Temporary variables to be used in the for loop
            double tempSalary = 10000;

            Console.WriteLine(">>> Initial list of empoyees...\n");
            for (int index = 0; index <= employeeNames.Length; index++)
            {
                employeeSortedDictionary.Add(index, new Employee(employeeNames[index], tempSalary * index));
                Console.WriteLine("---Employee>>> Name: {0,3} Salary: {1,3}\n", 
                                  employeeSortedDictionary.ElementAt(index).Value.Name, 
                                  employeeSortedDictionary.ElementAt(index).Value.Salary);
            }
            /////////////////////////////////////
            ////Testing user defined methods
            /////////////////////////////////////
            AddDictionaryItem(employeeSortedDictionary, "Gray", 500000); //Add an employee
            PrintDictionary(employeeSortedDictionary); //Print all employees after adding an employee
            RemoveDictionaryItem(employeeSortedDictionary); //Remove a dictionary item at index 0
            SearchDictionaryItem(employeeSortedDictionary, "Clint"); //Search for an employee
            MaxDictionaryItem(employeeSortedDictionary); //Search for an employee with highest salary
            //Garbage collection
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        //AddDictionaryItem method
        public static void AddDictionaryItem(SortedDictionary<int, Employee> inputSortedDictionary, string name, double salary)
        {
            try
            {
                Console.WriteLine("\n>>> Adding a new employee to the sorted dictionary...\n");
                inputSortedDictionary.Add(inputSortedDictionary.Keys.Max() + 1,
                                          new Employee(name, salary));
                Console.WriteLine("\n>>> New employee added\n---Name: {0,3} Salary: {1,3}\n", name, salary);
                employeeNames.ToList().Add(name);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n>>>{0,2}\n  Exception handling in process...\n", exception.Message);
            }
        }
        //RemoveDictionaryItem method
        public static void RemoveDictionaryItem(SortedDictionary<int, Employee> inputSortdeDictionary)
        {
            try
            {
                Console.WriteLine("\n>>> Removing an employee to the sorted dictionary...\n");
                var removedEmployee = inputSortdeDictionary.Remove(0);
                Console.WriteLine("\n>>> Removed employee: {0,3}\n", removedEmployee.ToString());
                employeeNames.ToList().RemoveAt(0);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n>>>{0,2}\n  Exception handling in process...\n", exception.Message);
            }
        }
        //PrintDictionary method
        public static void PrintDictionary(SortedDictionary<int, Employee> inputSortedDictionary)
        {
            try
            {
                Console.WriteLine(">>> Printing all employees using PrintDictionary() method....\n");
                foreach (var employee in inputSortedDictionary)
                {
                    Console.WriteLine("\n--- Name: {0,3} Salary: {1,3}\n", employee.Value.Name, employee.Value.Salary);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n>>>{0,2}\n  Exception handling in process...\n", exception.Message);
            }
        }
        //SearchDictionaryItem method
        public static void SearchDictionaryItem(SortedDictionary<int, Employee> inputSortedDictionary, string name)
        {
            try
            {
                var selectedEmployees = from employee in inputSortedDictionary
                                       where (employee.Value.Equals(name))
                                       select employee;
                Console.WriteLine("\n>>> Employees that match search criteria:\n");
                foreach (var employee in selectedEmployees)
                {
                    Console.WriteLine("\n---- Name: {0,3} and Salary: {1,3}\n", employee.Value.Name, employee.Value.Salary);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n>>>{0,2}\n  Exception handling in process...\n", exception.Message);
            }
        }
        //MaxDictionaryItem method
        public static void MaxDictionaryItem(SortedDictionary<int,Employee> inputSortedDictionary)
        {
            try
            {
                //Query to find max salary from all employees salaries
                var maxSalary = inputSortedDictionary.Values.Max().Salary;
                //Query to find the name of the employee whose 
                //salary is the salary returnded from above query
                var nameOfMaxSalaryEmployee = from employee in inputSortedDictionary.Values
                                              where (employee.Salary.Equals(maxSalary))
                                              select employee.Name;
                Console.WriteLine("\n>>> Employee(s) with highest salary:\n--- Name: {0,3} Salary: {1,3}",
                                    nameOfMaxSalaryEmployee, maxSalary);
            }
            catch (Exception exception)
            {
                Console.WriteLine("\n>>>{0,2}\n  Exception handling in process...\n", exception.Message);
            }
        }
    }
}
