using Access.Entities;

using Business.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappers
{
	public static class ModelMapper
	{
		public static StudentModel Map(Student studentEntity, Speciality specialityEntity, Group groupEntity, Teacher teacherEntity)
		{
			var specialityModel = specialityEntity == null ? null : new SpecialityModel
			{
				ID = specialityEntity.ID,
				Name = specialityEntity.Name
			};

			var teacherModel = teacherEntity == null ? null : new TeacherModel
			{
				ID = teacherEntity.ID,
				Age = teacherEntity.Age,
				FirstName = teacherEntity.FirstName,
				LastName = teacherEntity.LastName,
				SecondName = teacherEntity.SecondName,
				ShortName = teacherEntity.ShortName,
				SexID = teacherEntity.SexID
			};

			var groupModel = groupEntity == null ? null : new GroupModel
			{
				ID = groupEntity.ID,
				Name = groupEntity.Name,
				Speciality = specialityModel,
				Teacher = teacherModel
			};

			var model = studentEntity == null ? null : new StudentModel
			{
				ID = studentEntity.ID,
				Age = studentEntity.Age,
				FirstName = studentEntity.FirstName,
				Group = groupModel,
				IsBudget = studentEntity.IsBudget,

			};

			return model;
		}
	}
}
