using Access.Entities;

using Business.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappers
{
	public static class EntityMapper
	{
		public static Course Map(CourseModel model)
		{
			return new Course
			{
				ID = model.ID,
				Name = model.Name,
				TeacherID = model.Teacher.ID
			};
		}

		public static Student Map(StudentModel model)
		{
			return new Student
			{
				ID = model.ID,
				Age = model.Age,
				FirstName = model.FirstName,
				LastName = model.LastName,
				SecondName = model.SecondName,
				GroupID = model.Group.ID,
				IsBudget = model.IsBudget,
				SexID = model.SexID,
				ShortName = model.ShortName
			};
		}

		public static Group Map(GroupModel model)
		{
			return new Group
			{
				ID = model.ID,
				Name = model.Name,
				SpecialityID = model.Speciality.ID,
				TeacherID = model.Teacher.ID
			};
		}
	}
}
