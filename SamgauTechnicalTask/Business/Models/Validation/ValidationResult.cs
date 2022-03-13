using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Validation
{
	public class ValidationResult
	{
		private List<string> errors { get; set; }
		public bool IsValid { get { return errors.Count > 1; } }

		public ValidationResult(List<string> errors)
		{
			this.errors = errors;
		}
		public string GetMessage()
		{
			var result = string.Empty;

			for (int i = 1; i <= errors.Count; i++)
				result += $"{i}. {errors[i]} . \n";

			return result;
		}
	}
}
