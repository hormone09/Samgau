using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Query
{
	/// <summary>
	/// Параметры запроса для поиска студентов
	/// </summary>
	public class StudentQuery : QueryBase
	{
		public string LastName { get; set; }
		public long? GroupID { get; set; }
	}
}
