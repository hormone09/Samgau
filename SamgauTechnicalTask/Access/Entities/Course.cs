using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Сущность курса обучения
	/// </summary>
	public class Course : EntityBase
	{
		/// <summary>
		/// Название 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Идентификатор преподавателя
		/// </summary>
		public long TeacherID { get; set; }
	}
}
