using Business.Models.Validation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class StudentModel : PeopleModelBase
	{
		public GroupModel Group { get; set; }
		public bool IsBudget { get; set; }

		public override ValidationResult Validate()
		{
			return new ValidationResult(new List<string>());
		}
	}
}
