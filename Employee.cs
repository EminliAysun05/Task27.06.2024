

namespace Task27._06._2024
{
    internal class Employee : IPerson
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public double Salary { get; set; }
        public Employee(string name, byte age, double salary)
        {
            Id = ++_id;
            Age = age;
            Name = name;
            Salary = salary;
        }
        public string ShowInfo()
        {

            return $"Name - {Name}, Age - {Age}, Id- {Id}, Salary: {Salary}";
        }
        public override string ToString()
        {
            return ShowInfo();


        }


    }
}
