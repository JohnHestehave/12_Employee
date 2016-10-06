using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
	public class EmployeeRepository
	{
		List<Employee> Employees;

		public EmployeeRepository()
		{
			Employees = new List<Employee>();
		}

		public Employee CreateEmployee(string name, string job)
		{
			Employee e = new Employee(name, job, CountEmployees()+1);
			Employees.Add(e);
			return e;
		}

		public void SaveEmployee(Employee e)
		{
			
		}

		public Employee LoadEmployee(int id)
		{
			Employee e = Employees[id-1];
			return e;
		}

		public void Clear()
		{
			Employees.Clear();
		}

		public int CountEmployees()
		{
			return Employees.Count();
		}

		public List<Employee> FindAllEmployees()
		{
			return Employees;
		}

	}
}