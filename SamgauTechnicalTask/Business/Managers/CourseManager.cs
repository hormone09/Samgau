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
	public class CourseManager
	{
		private readonly CourseRepository courseRepository;
		private readonly TeacherRepository teacherRepository;

		public CourseManager(CourseRepository courseRepository, TeacherRepository teacherRepository)
		{
			this.courseRepository = courseRepository;
			this.teacherRepository = teacherRepository;
		}

		public List<CourseModel> GetList(CourseQueryModel queryModel)
		{
			if (queryModel == null) throw new ArgumentNullException(nameof(CourseQueryModel));

			var query = QueryMapper.Map(queryModel);

			var entities = courseRepository.GetList(query);

			if (entities == null || entities.Count < 1) throw new Exception("Курсы по заданному фильтру не найдены!");

			var models = new List<CourseModel>();

			foreach(var entity in entities)
			{
				var teacherEntity = teacherRepository.Get(entity.ID);

				models.Add(ModelMapper.Map(entity, teacherEntity));
			}

			return models;
		}

		public void Update(CourseModel model)	
		{
			if (model == null) throw new ArgumentNullException(nameof(CourseModel));

			var validationResult = model.Validate();
			if (!validationResult.IsValid) throw new Exception(validationResult.GetMessage());

			var entity = EntityMapper.Map(model);

			try
			{
				if (model.ID > 0) 
					courseRepository.Update(entity);
				else 
					courseRepository.Insert(entity);
			}
			catch(Exception ex)
			{
				throw new Exception($"Ошибка добавления: \n {ex.Message}");
			}
		}

		public void Delete(long? ID)
		{
			if (ID == null) throw new ArgumentNullException("Ошибка удаления, ID не получен.");

			try
			{
				courseRepository.Delete(ID.Value);
			}
			catch(Exception ex)
			{
				throw new Exception($"Ошибка удаления: \n {ex.Message}");
			}
		}
	}
}
