using Access.Entities;
using Access.Query;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repository
{
	public class SpecialityRepository : RepositoryBase<Speciality>
	{
		public List<Speciality> GetList(SpecialityQuery query)
		{
			if (query == null) throw new ArgumentNullException(nameof(SpecialityQuery));

			string where = query.IDs != null ? " WHERE ID IN @IDs " : string.Empty;
			string order = query.SortingType == Enums.SortingType.Ascending ? " ORDER BY ID " : "OREDER BY ID DESC";

			using (var connection = new SqlConnection(ConnectionString))
			{
				string sql = $"SELECT * FROM {TableName} {where} {order}";

				return connection.Query<Speciality>(sql, query).ToList();
			}
		}
	}
}
