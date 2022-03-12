using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Сущность группы студентов
	/// </summary>
	public class Group : EntityBase
	{
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Идентификатор специализации
		/// </summary>
		public long SpecialityID { get; set; }
		/// <summary>
		/// Идентификатор куратора группы
		/// </summary>
		public long TeacherID { get; set; }
	}
}
