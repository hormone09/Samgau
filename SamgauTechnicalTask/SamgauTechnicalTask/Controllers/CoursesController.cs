using Business.Managers;
using Business.Models;
using Business.QueryModels;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamgauTechnicalTask.Controllers
{
	public class CoursesController : Controller
	{
		private readonly CourseManager courseManager;

		public CoursesController(CourseManager courseManager)
		{
			this.courseManager = courseManager;
		}

		[HttpPost]
		public JsonResult GetList(CourseQueryModel queryModel)
		{
			return Json(courseManager.GetList(queryModel));
		}

		[HttpPost]
		public void Update(CourseModel model)
		{
			courseManager.Update(model);
		}

		[HttpPost]
		public void Delete(long ID)
		{
			courseManager.Delete(ID);
		}
	}
}
