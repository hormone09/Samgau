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
		public static StudentModel Map(Student studentEntity, Speciality specialityEntity = null, Group groupEntity = null, Teacher teacherEntity = null)
		{
			var groupModel = Map(groupEntity, teacherEntity, specialityEntity);

			var studentModel = studentEntity == null ? null : new StudentModel
			{
				ID = studentEntity.ID,
				Age = studentEntity.Age,
				FirstName = studentEntity.FirstName,
				Group = groupModel,
				IsBudget = studentEntity.IsBudget,

			};

			return studentModel;
		}

		public static GroupModel Map(Group groupEntity, Teacher teacherEntity = null, Speciality specialityEntity = null)
		{
			var groupModel = groupEntity == null ? null : new GroupModel
			{
				ID = groupEntity.ID,
				Name = groupEntity.Name,
				Speciality = Map(specialityEntity),
				Teacher = Map(teacherEntity)
			};

			return groupModel;
		}

		public static SpecialityModel Map(Speciality specialityEntity)
		{
			var specialityModel = specialityEntity == null ? null : new SpecialityModel
			{
				ID = specialityEntity.ID,
				Name = specialityEntity.Name
			};

			return specialityModel;
		}

		public static CourseModel Map(Course courseEntity, Teacher teacherEntity = null)
		{
			var courseModel = teacherEntity == null ? null : new CourseModel
			{
				ID = courseEntity.ID,
				Name = courseEntity.Name,
				Teacher = Map(teacherEntity)
			};

			return courseModel;
		}

		public static TeacherModel Map(Teacher teacherEntity)
		{
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

			return teacherModel;
		}
	}
}
