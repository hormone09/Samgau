using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Query
{
	public class TeacherQuery : QueryBase
	{
		public string LastName { get; set; }
		public long? GroupID { get; set; }
	}
}
