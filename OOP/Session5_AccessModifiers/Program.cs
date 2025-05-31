// See https://aka.ms/new-console-template for more information
/*
 Step 1: Create a class library and console application. Add reference of class library into console application.



Step 2: Create a class called Employee in the class library with fields EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. Additionally, add the following fields:

    - A static field called OrganizationName. It should be initialized as "Harsha Inc." in Main method.

    - A constant field called TypeOfEmployee and initialize it as "Contract Based" along with declaration.

    - A readonly field called DepartmentName and initialize it as "Finance Department" in constructor.



Step 3: Create an object of Employee class in the console application. Read each employee details (EmpID, EmpName, SalaryPerHour, NoOfWorkingHours) from the user (from the keyboard) using loop.

Calculate net salary (SalaryPerHour * NoOfWorkingHours).

And display the all details of the same object (including EmpID, EmpName, SalaryPerHour, NoOfWorkingHours, NetSalary, OrganizationName, TypeOfEmployee, DepartmentName) and then ask the user 'Do you want to continue to next employee'.

If the user choose 'Yes', proceed to the next employee; otherwise stop the loop.
 */

using Employee;

Console.WriteLine("Hello, World!");
string choice = "yes";
do
{
    Employee_Profile employee_Profile = new Employee_Profile();
    Employee_Profile.OrganizationName = "Harsha Inc";

    System.Console.Write("Employee ID: ");
    employee_Profile.EmpID = Console.ReadLine();
    System.Console.Write("Employee Name: ");
    employee_Profile.EmpName = Console.ReadLine();
    System.Console.Write("Salary per Hour: ");
    employee_Profile.SalaryPerHour = int.Parse(Console.ReadLine());
    System.Console.Write("No. of Working Hours: ");
    employee_Profile.NoOfWorkingHours = int.Parse(Console.ReadLine());

    employee_Profile.NetSalary = employee_Profile.NoOfWorkingHours * employee_Profile.SalaryPerHour;


    //display Employee Details
    System.Console.WriteLine("Employee ID: " + employee_Profile.EmpID);
    System.Console.WriteLine("Employee Name: " + employee_Profile.EmpName);
    System.Console.WriteLine("Salary per Hour: " + employee_Profile.SalaryPerHour);
    System.Console.WriteLine("No. of Working Hours: " + employee_Profile.NoOfWorkingHours);
    System.Console.WriteLine("Net Salary: " + employee_Profile.NetSalary);
    System.Console.WriteLine("Type of Employee: " + Employee_Profile.TypeOfEmployee);
    System.Console.WriteLine("Department Name: " + employee_Profile.DepartmentName);


    Console.Write("Do you want to continue to next employee? Yes / No: ");
    choice = Console.ReadLine();
    if (!(choice == "yes" || choice == "YES" || choice == "Yes" || choice == "y" || choice == "Y"))
    {
        break;
    } else { choice = "yes"; }
    System.Console.WriteLine("-----------------------------------");
} while (choice == "yes");
