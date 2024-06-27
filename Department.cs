

namespace Task27._06._2024
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public Employee[] Employees;
        public Employee this[int index]
        {
            get { return Employees[index]; }
            set { Employees[index] = value; }
        }
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;

            Employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {


            if (Employees.Length > EmployeeLimit)
            {
                throw new CapacityLimitException("Employee limit has been reached.");





            }
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;

        }
    }
}

