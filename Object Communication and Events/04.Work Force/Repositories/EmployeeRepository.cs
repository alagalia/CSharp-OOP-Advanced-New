namespace _04.Work_Force.Repositories
{
    using System.Collections.Generic;

    using _04.Work_Force.Interfaces;

    public class EmployeeRepository
    {
        private readonly Dictionary<string, IEmployee> employees;

        public EmployeeRepository()
        {
            this.employees = new Dictionary<string, IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            this.employees.Add(employee.Name, employee);
        }

        public IEmployee GetEmployee(string name)
        {
            return this.employees[name];
        }
    }
}