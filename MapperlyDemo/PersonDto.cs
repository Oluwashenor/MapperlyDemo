using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyDemo
{
	public class PersonDto
	{
		public int PersonId { get; set; }
		public required string FullName {  get; set; }
		public DateTime DateOfBirth { get; set; }	
		public string[]? Tags { get; set; }
		public EmploymentStatusDto Status {  get; set; }

		public override string ToString()
		{
			return $"Person Id: {PersonId}, + FullName: {FullName}, + DateOfBirth: {DateOfBirth:yyyyy-MM-dd}, Tags: {string.Join(", ", Tags)}, Status: {Status}";
		}
	}

	public enum EmploymentStatusDto
	{
		Retired = 1,
		Employed = 2,
		Student = 3,
		Unemployed = 4
	}
}
