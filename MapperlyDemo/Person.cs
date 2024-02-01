using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyDemo
{
	public class Person
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public List<string> Tags { get; set; }
		public EmploymentStatusDto EmploymentStatus { get; set; }
	}

	public enum EmploymentStatus
	{
		Employed = 1000,
		Unemployed = 2000,
		Retired = 3000,
		Student = 4000
	}
}
