using Access.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Query
{
	/// <summary>
	/// Базовый класс для всех запросов в БД
	/// </summary>
	public class QueryBase
	{
		/// <summary>
		/// Тип сортировки
		/// </summary>
		public SortingType SortingType { get; set; }
		/// <summary>
		/// Список ID сущностей
		/// </summary>
		public List<long> IDs { get; set; }
	}
}
