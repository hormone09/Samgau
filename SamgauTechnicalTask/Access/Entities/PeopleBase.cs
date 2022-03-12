using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Базовый класс сущности людей
	/// </summary>
	public abstract class PeopleBase : EntityBase
	{
		/// <summary>
		/// Возраст
		/// </summary>
		public int Age { get; set; }
		/// <summary>
		/// Имя
		/// </summary>
		public string FirstName { get; set; }
		/// <summary>
		/// Отчество
		/// </summary>
		public string SecondName { get; set; }
		/// <summary>
		/// Фамилия
		/// </summary>
		public string LastName { get; set; }
		/// <summary>
		/// Фамилия, инициалы
		/// </summary>
		public string ShortName { get; set; }
		/// <summary>
		/// Половой признак
		/// </summary>
		public int SexID { get; set; }
	}
}
