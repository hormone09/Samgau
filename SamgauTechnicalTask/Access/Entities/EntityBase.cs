using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entities
{
	/// <summary>
	/// Базовый класс для всех сущностей
	/// </summary>
	public abstract class EntityBase
	{
		/// <summary>
		/// Идентификатор в БД
		/// </summary>
		public long ID { get; set; }
	}
}
