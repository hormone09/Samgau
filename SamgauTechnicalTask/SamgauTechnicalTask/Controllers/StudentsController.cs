using Business.QueryModels;
using Business.Managers;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Models;

namespace SamgauTechnicalTask.Controllers
{
	public class StudentsController : Controller
	{
		StudentManager studentManager;

		public StudentsController(StudentManager studentManager)
		{
			this.studentManager = studentManager;
		}

		[HttpPost]
		public JsonResult GetList(StudentQueryModel queryModel)
		{
			return Json(studentManager.GetList(queryModel));
		}

		[HttpPost]
		public void Update(StudentModel model)
		{
			studentManager.Update(model);
		}

		[HttpPost]
		public void Delete(long ID)
		{
			studentManager.Delete(ID);
		}
	}
}
