﻿using Business.Models.Validation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class GroupModel : ModelBase
	{
		public string Name { get; set; }
		public SpecialityModel Speciality { get; set; }
		public TeacherModel Teacher { get; set; }

		public override ValidationResult Validate()
		{
			return new ValidationResult(new List<string>());
		}
	}
}
