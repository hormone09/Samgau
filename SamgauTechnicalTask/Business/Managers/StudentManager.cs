using Access.Query;
using Access.Repository;

using Business.Mappers;
using Business.Models;
using Business.QueryModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
	public class StudentManager
	{
		private readonly StudentRepository studentRepository;
		private readonly GroupRepository groupRepository;
		private readonly SpecialityRepository specialityRepository;
		private readonly TeacherRepository teacherRepository;

		public StudentManager(
			StudentRepository studentRepository, 
			GroupRepository groupRepository, 
			SpecialityRepository specialityRepository,
			TeacherRepository teacherRepository
			)
		{
			this.studentRepository = studentRepository;
			this.groupRepository = groupRepository;
			this.specialityRepository = specialityRepository;
			this.teacherRepository = teacherRepository;
		}

		public List<StudentModel> GetList(StudentQueryModel queryModel)
		{
			if (queryModel == null) throw new ArgumentNullException(nameof(StudentQueryModel));

			var query = QueryMapper.Map(queryModel);

			var entities = studentRepository.GetList(query);

			if (entities == null || entities.Count < 1) throw new Exception("Студенты по заданному фильтру не найдены!");

			var models = new List<StudentModel>();

			foreach(var entity in entities)
			{
				var groupEntity = groupRepository.Get(entity.GroupID.Value);
				var specialityEntity = specialityRepository.Get(groupEntity.SpecialityID);
				var teacherEntity = teacherRepository.Get(groupEntity.TeacherID);

				models.Add(ModelMapper.Map(entity, specialityEntity, groupEntity, teacherEntity));
			}

			return models;
		}
	}
}
