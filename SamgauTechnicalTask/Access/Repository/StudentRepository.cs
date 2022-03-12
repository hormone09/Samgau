using Access.Entities;
using Access.Enums;
using Access.Query;

using Dapper;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repository
{
	public class StudentRepository : RepositoryBase<Student>
	{
		public List<Student> GetList(StudentQuery query)
		{
			if (query == null) throw new ArgumentNullException(nameof(StudentQuery));

			string select = $"SELECT * FROM {TableName} ";
			string where = GetCondition(query);
			string order = " ORDER BY ID ";


			order += query.SortingType == SortingType.Descending ? " DESC " : string.Empty;

			using (var connection = new SqlConnection(ConnectionString))
			{
				string sql = $"{select} {where} {order}";

				return connection.Query<Student>(sql, query).ToList();
			}
		}

		public Student Find(StudentQuery query)
		{
			if (query == null) throw new ArgumentNullException(nameof(StudentQuery));

			string where = GetCondition(query);
			string sql = $"SELECT * FROM {TableName} {where}";

			using (var connection = new SqlConnection(ConnectionString))
			{
				return connection.QueryFirstOrDefault<Student>(sql, query);
			}
		}

		private string GetCondition(StudentQuery query)
		{
			string condition = string.Empty;

			condition += query.IDs != null ? (string.IsNullOrEmpty(condition) ? " WHERE ID IN @IDs "
				: " AND ID IN @IDs ") : string.Empty;

			condition += query.GroupID != null ? (string.IsNullOrEmpty(condition) ? " WHERE GroupID = @GroupID "
				: " AND GroupID = @GroupID ") : string.Empty;

			condition += query.LastName != null ? (string.IsNullOrEmpty(condition)) ? $" WHERE LastName like CONCAT(@LastName, '%') "
				: " AND LastName like CONCAT(@LastName, '%')" : string.Empty;

			return condition;
		}
	}
}
