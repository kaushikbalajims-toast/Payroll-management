using System;
using System.Text.RegularExpressions;

namespace Name
{
    public class Employee{
        private static int counter = 1001;
        private int empID;
        private string name;
        private string department;
        private string designation;
        private double salary;

        public Employee(){
            empID = counter++;
        }

        public int EmpID{
            get { return empID; }
            set { empID = value; }
        }

        public string Name{
            get { return name; }
            set { 
                while(true) {
                    var m = Regex.Match(value, "^[A-Z][a-zA-Z ]+");
                    if(m.Success){
                        break;
                    }
                    else{
                        System.Console.WriteLine("Enter a name starting with caps");
                        System.Console.WriteLine("Enter name: ");
                        value = Console.ReadLine();
                    }
                }
                name = value;
            }
        }

        public string Department{
            get { return department; }
            set { 
                string[] department_array = {"R & D", "IT", "Admin", "HR", "Support"};
                bool validInput = false;
                bool starting = true;
                int dept_choice =0;
                while(true){
                    if(starting){
                        System.Console.WriteLine("\nDepartment choices \n1.R & D\n2.IT\n3.Admin\n4.HR\n5.Support\nEnter department choice:");
                        value = Console.ReadLine();
                        starting = false;
                    }
                    validInput = int.TryParse(value, out dept_choice); 
                    if(validInput){
                        if(dept_choice<6 && dept_choice>0)
                            break;
                        else{
                            System.Console.WriteLine("Enter a numerical choice\nDepartment choices \n1.R & D\n2.IT\n3.Admin\n4.HR\n5.Support\nEnter department choice:");
                            value = Console.ReadLine();
                        }
                    }
                    else if(!validInput || !(dept_choice<6 && dept_choice>0)){
                        System.Console.WriteLine("Enter a valid choice\nDepartment choices \n1.R & D\n2.IT\n3.Admin\n4.HR\n5.Support\nEnter department choice:");
                        value = Console.ReadLine();
                    }
                }
                department = department_array[Convert.ToInt32(dept_choice) - 1];
            }
        }

        public string Designation{
            get { return designation; }
            set {                 
                string[] designation_array = {"Manager", "Senior developer", "Software developer", "Intern"};
                bool validInput = false;
                int desg_choice =0;
                bool starting = false;
                while(true){
                    if(starting){
                        System.Console.WriteLine("\nDesignation choice\n1.Manager\n2.Senior developer\n3.Software developer\n4.Intern\nEnter designation choice: ");
                        value = Console.ReadLine();
                        starting = false;
                    }
                    validInput = int.TryParse(value, out desg_choice); 
                    if(validInput){
                        if(desg_choice<5 && desg_choice>0)
                            break;
                        else{
                            System.Console.WriteLine("Enter a numerical choice\nDesignation choice\n1.Manager\n2.Senior developer\n3.Software developer\n4.Intern\nEnter designation choice: ");
                            value = Console.ReadLine();
                        }
                    }
                    else if(!validInput || !(desg_choice<5 && desg_choice>0)){
                        System.Console.WriteLine("Enter a valid choice\nDesignation choice\n1.Manager\n2.Senior developer\n3.Software developer\n4.Intern\nEnter designation choice: ");
                        value = Console.ReadLine();
                    }
                }
                designation = designation_array[Convert.ToInt32(desg_choice) - 1];
            }
         }

        public double Salary{
            get { return salary; }
            set {  
                bool validInput = false;
                double sal = 0;
                string inp = "";
                bool starting = true;
                while(true){
                    if(starting){
                        System.Console.Write("Enter salary: ");
                        inp = Console.ReadLine();
                        starting = false;
                    }
                    validInput = double.TryParse(inp, out sal); 
                    if(validInput){
                        if(sal>9999)
                            break;
                        else{
                            System.Console.Write("Enter a 5 figure salary\nEnter salary: ");
                            inp = Console.ReadLine();
                        }
                    }
                    else if(!validInput || !(sal>9999)){
                        System.Console.Write("Enter a valid salary\nEnter salary: ");
                        inp = Console.ReadLine();
                    }
                }
                salary = sal;
                
            }   
        }

        public override string ToString(){
            return name + " - " + empID + " - " + department + " - " + designation + " - " + salary;
        }
    
        public void SetAllowance(){
            if(Designation == "Manager"){
                salary = salary + (20*salary/100);
            }
            else{
                salary = salary + (10*salary/100);
            }
       }
    }
}