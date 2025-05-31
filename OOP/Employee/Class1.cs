namespace Employee
{
    public class Employee_Profile
    {
        // instance field
        public string EmpID;
        public string EmpName;
        public int SalaryPerHour;
        public int NoOfWorkingHours;
        public int NetSalary;
        // static field - initialize it where you are creating the object
        public static string OrganizationName;
        public const string TypeOfEmployee= "Contract Based";
        // initialize it in intance creation for once;
        public readonly string DepartmentName;
        public Employee_Profile()
        {
            DepartmentName = "Finance Department";
        }
    }
}
