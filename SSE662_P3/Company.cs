using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE662_P3
{
    public class Company
    {
        private readonly List<Employee> _employees;

        public Company()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee e)
        {
            _employees.Add(e);
        }

        public void RemoveEmployee(Employee e)
        {
            _employees.Remove(e);
        }

        public int GetNumberOfEmployees()
        {
            return _employees.Count;
        }
    }
}
