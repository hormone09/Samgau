using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Query
{
	public class CourseQuery : QueryBase
	{
		public List<long> TeacherIDs { get; set; }
		public string Name { get; set; }
	}
}
