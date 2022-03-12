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
	}
}
