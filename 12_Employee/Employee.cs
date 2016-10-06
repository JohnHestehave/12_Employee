using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
	public class Employee
	{
		public int Id;
		public string Name;
		public string Type;

		public Employee(string name, string type, int id)
		{
			Id = id;
			Name = name;
			Type = type;
		}
	}
}
