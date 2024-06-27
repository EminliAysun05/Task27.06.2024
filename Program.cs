namespace Task27._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department("IT", 2);
            Employee emp1 = new Employee("Alice", 30, 50000);
            Employee emp2 = new Employee("Bob", 25, 45000);




            try
            {



                department.AddEmployee(emp1);
                department.AddEmployee(emp2);


                Employee emp3 = new Employee("Charlie", 28, 47000);
                department.AddEmployee(emp3);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(department[1]);


        }
    }
}
