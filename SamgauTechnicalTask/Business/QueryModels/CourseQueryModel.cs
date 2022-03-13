using Business.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.QueryModels
{
	public class CourseQueryModel : QueryModelBase
	{
		public List<TeacherModel> Teachers { get; set; }
		public string Name { get; set; }
	}
}
