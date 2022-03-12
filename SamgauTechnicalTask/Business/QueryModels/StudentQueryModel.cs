using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.QueryModels
{
	public class StudentQueryModel : QueryModelBase
	{
		public string LastName { get; set; }
		public long? GroupID { get; set; }
	}
}
