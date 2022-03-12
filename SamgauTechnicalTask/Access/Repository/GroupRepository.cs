using Access.Entities;
using Access.Query;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repository
{
	public class GroupRepository : RepositoryBase<Group>
	{
		public List<Group> GetList(GroupQuery query)
		{
			if (query == null) throw new ArgumentNullException(nameof(GroupQuery));

			string where = string.Empty;
			string order = " ORDER BY ID ";

			order += query.IDs != null ? (string.IsNullOrEmpty(where) ? " WHERE ID IN @IDs"
				: " AND ID IN @IDs") : string.Empty;

			order += !string.IsNullOrEmpty(query.Name) ? (string.IsNullOrEmpty(where) ? " WHERE Name like CONCAT ('%', @Name, '%')"
				: " AND Name like CONCAT ('%', @Name, '%')") : string.Empty;

			order += query.TeacherIDs != null ? (string.IsNullOrEmpty(where) ? " WHERE TeacherID IN @TeacherIDs"
				: " AND TeacherID IN @TeacherIDs") : string.Empty;

			order += query.SortingType != Enums.SortingType.Ascending ? "DESC" : string.Empty;

			using (var connection = new SqlConnection(ConnectionString))
			{
				string sql = $"SELECT * FROM {TableName} {where} {order}";

				return connection.Query<Group>(sql, query).ToList();
			}
		}
	}
}
