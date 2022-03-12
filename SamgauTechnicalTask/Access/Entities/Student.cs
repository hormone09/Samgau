using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Сущность студента
	/// </summary>
	public class Student : PeopleBase
	{
		/// <summary>
		/// Флаг, получает ли студент степендию
		/// </summary>
		public bool IsBudget { get; set; }

		/// <summary>
		/// Ссылка на группу
		/// </summary>
		public long? GroupID { get; set; }
	}
}
