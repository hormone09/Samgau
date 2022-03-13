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
	public class GroupManager
	{
		private readonly GroupRepository groupRepository;
		private readonly TeacherRepository teacherRepository;
		private readonly SpecialityRepository specialityRepository;

		public GroupManager(GroupRepository groupRepository, TeacherRepository teacherRepository, SpecialityRepository specialityRepository)
		{
			this.groupRepository = groupRepository;
			this.teacherRepository = teacherRepository;
			this.specialityRepository = specialityRepository;
		}

		public List<GroupModel> GetList(GroupQueryModel queryModel)
		{
			if (queryModel == null) throw new ArgumentNullException(nameof(GroupQueryModel));

			var query = QueryMapper.Map(queryModel);

			var entities = groupRepository.GetList(query);

			if (entities == null || entities.Count < 1) throw new Exception("Группы по заданному фильтру не найдены!");

			var models = new List<GroupModel>();

			foreach(var entity in entities)
			{
				var teacherEntity = teacherRepository.Get(entity.ID);
				var specialityEntity = specialityRepository.Get(entity.ID);

				models.Add(ModelMapper.Map(entity, teacherEntity, specialityEntity));
			}

			return models;
		}

		public void Update(GroupModel model)
		{
			var validationResult = model.Validate();
			if (!validationResult.IsValid) throw new Exception(validationResult.GetMessage());

			var entity = EntityMapper.Map(model);

			try
			{
				if (model.ID > 0)
					groupRepository.Update(entity);
				else
					groupRepository.Insert(entity);
			}
			catch (Exception ex)
			{
				throw new Exception($"Ошибка добавления: \n {ex.Message}");
			}
		}

		public void Delete(long? ID)
		{
			if (ID == null) throw new ArgumentNullException("Ошибка удаления, ID не получен.");

			try
			{
				groupRepository.Delete(ID.Value);
			}
			catch (Exception ex)
			{
				throw new Exception($"Ошибка удаления: \n {ex.Message}");
			}
		}
	}
}
