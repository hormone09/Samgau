using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Query
{
	public class GroupQuery : QueryBase
	{
		public string Name { get; set; }
		public List<long> SpecialityIDs { get; set; }
		public List<long> TeacherIDs { get; set; }
	}
}
