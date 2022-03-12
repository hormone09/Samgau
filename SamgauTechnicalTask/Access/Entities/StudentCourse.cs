using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Сущность таблицы отношения Course <- -> Student
	/// </summary>
	public class StudentCourse : EntityBase
	{
		/// <summary>
		/// Ссылка на таблицу студентов
		/// </summary>
		public long StudentID { get; set; }
		/// <summary>
		/// Ссылка на таблицу курсов
		/// </summary>
		public long CourseID { get; set; }
	}
}
