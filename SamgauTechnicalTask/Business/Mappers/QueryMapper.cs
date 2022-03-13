using Access.Query;

using Business.QueryModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappers
{
	public static  class QueryMapper
	{
		public static StudentQuery Map(StudentQueryModel queryModel)
		{
			var query = new StudentQuery
			{
				IDs = queryModel.IDs,
				GroupID = queryModel.GroupID,
				LastName = queryModel.LastName,
				SortingType = (Access.Enums.SortingType)queryModel.SortingType
			};

			return query;
		}

		public static GroupQuery Map(GroupQueryModel queryModel)
		{

			var query = new GroupQuery
			{
				IDs = queryModel.IDs,
				Name = queryModel.Name,
				SortingType = (Access.Enums.SortingType)queryModel.SortingType,
				SpecialityIDs = queryModel.Specialities.Select(x => x.ID).ToList(),
				TeacherIDs = queryModel.Teachers.Select(x => x.ID).ToList()
			};

			return query;
		}

		public static CourseQuery Map(CourseQueryModel queryModel)
		{
			var query = new CourseQuery
			{
				IDs = queryModel.IDs,
				Name = queryModel.Name,
				SortingType = (Access.Enums.SortingType)queryModel.SortingType,
				TeacherIDs = queryModel.Teachers.Select(x => x.ID).ToList()
			};

			return query;
		}
	}
}
