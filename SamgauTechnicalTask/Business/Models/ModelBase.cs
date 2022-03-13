using Business.Models.Validation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public abstract class ModelBase
	{
		public long ID { get; set; }

		public abstract ValidationResult Validate();
	}
}
