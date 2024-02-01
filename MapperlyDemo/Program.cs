// See https://aka.ms/new-console-template for more information
using MapperlyDemo;

Console.WriteLine("Hello, World!");


var user = new Person()
{
	Name = "Test",
	DateOfBirth = new DateTime(1990, 10, 1),
	Id = 1,
	EmploymentStatus = EmploymentStatusDto.Employed,
	Tags = new List<string>() { "Tags", "Tagss" }
};


var mapper = new PersonMapper();
var dto = mapper.PersontoPersonDto(user);
Console.WriteLine(dto.ToString());