using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Сущность специальности группы
	/// </summary>
	public class Speciality : EntityBase
	{
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; set; }
	}
}
