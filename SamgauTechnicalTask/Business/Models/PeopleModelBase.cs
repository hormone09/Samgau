using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public abstract class PeopleModelBase : ModelBase
	{
		public int Age { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string LastName { get; set; }
		public string ShortName { get; set; }
		public int SexID { get; set; }
	}
}
