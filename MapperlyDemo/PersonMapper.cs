using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyDemo
{
	[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
	public partial class PersonMapper
	{
		[MapProperty(nameof(Person.Id), nameof(PersonDto.PersonId))]
		[MapProperty(nameof(Person.Name), nameof(PersonDto.FullName))]
		[MapProperty(nameof(Person.EmploymentStatus), nameof(PersonDto.Status))]
		public partial PersonDto PersontoPersonDto(Person person);
	}
}
