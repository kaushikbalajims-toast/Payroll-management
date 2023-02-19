// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Name
{
    public class Demo{
        public static void Main(string[] args){            
            List<Employee> employees = new List<Employee>();
            int choice = 0;
            while (true){
                bool validInput = false;
                while(true){
                    System.Console.Write("\nMenu\n1.Add Employee\n2.Display Employees\n3.Exit\nEnter choice: ");
                    validInput = int.TryParse(Console.ReadLine(), out choice);
                    if(validInput){
                        if(choice <4 && choice>0)
                            break;
                        else{
                            System.Console.WriteLine("Enter valid choice");
                        }
                    }
                }
                choice = Convert.ToInt32(choice);
                if(choice == 1){
                    Employee e = new Employee();
                    e.Name = "";
                    e.Department = "";
                    e.Designation = "";
                    e.Salary = 0;
                    employees.Add(e);
                    e.SetAllowance();
                }
                else if(choice == 2){
                    foreach (var emp in employees)
                    {
                        System.Console.WriteLine(emp.ToString());
                    }
                }
                else{
                    System.Console.WriteLine("Bye bye");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}