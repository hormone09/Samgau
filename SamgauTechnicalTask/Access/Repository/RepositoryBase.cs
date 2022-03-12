using Dapper;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repository
{
	public abstract class RepositoryBase<T>
	{
		public const string TableName = nameof(T);
		public const string ConnectionString = "";

		public virtual T Get(long ID)
		{
			using (IDbConnection db = new SqlConnection())
			{
				string query = $"SELECT * FROM {TableName} WHERE ID = @ID";

				return db.QueryFirstOrDefault<T>(query, ID);
			}
		}

		public virtual long Insert(T entity)
		{
			string query = $"INSERT INTO {TableName}";
			query += " VALUES ( ";

			var properties = entity.GetType().GetProperties();
			var lenght = properties.Length;
			int num = 1;

			foreach(var prop in properties)
			{
				if (prop.Name.Equals("ID")) continue;

				query += $"@{prop.Name}";

				query += num++ != lenght ? ", " : string.Empty;
			}

			query += " ) SELECT SCOPE_IDENTITY()";

			using (IDbConnection db = new SqlConnection())
			{
				return db.QueryFirstOrDefault<long>(query, entity);
			}
		}

		public virtual void Update(T entity)
		{
			string query = $"UPDATE {TableName} SET ";

			var properties = entity.GetType().GetProperties();
			var lenght = properties.Length;
			int num = 1;

			foreach (var prop in properties)
			{
				if (prop.Name.Equals("ID")) continue;

				query += $"{prop.Name} =  @{prop.Name}";

				query += num++ != lenght ? ", " : string.Empty;
			}

			using (IDbConnection db = new SqlConnection())
			{
				db.Query(query, entity);
			}
		}

		public virtual void Delete(long ID)
		{
			string query = $"DELETE FROM {TableName} WHERE ID = @ID";

			using (IDbConnection db = new SqlConnection())
			{
				db.Query(query, ID);
			}
		}
	}
}
