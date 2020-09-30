using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee() { Id=1, Name="Artur", Department=".Net", Email="artur@utaxi.am"},
                new Employee() { Id=2, Name="Ando", Department="Android", Email="ando@utaxi.am"},
                new Employee() { Id=3, Name="Edo", Department="ios", Email="edo@utaxi.am"},
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
