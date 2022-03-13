using Business.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.QueryModels
{
	public class GroupQueryModel : QueryModelBase
	{
		public string Name { get; set; }
		public List<SpecialityModel> Specialities { get; set; }
		public List<TeacherModel> Teachers { get; set; }
	}
}
