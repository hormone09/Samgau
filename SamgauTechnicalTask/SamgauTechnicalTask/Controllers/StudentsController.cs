using Business.QueryModels;
using Business.Managers;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamgauTechnicalTask.Controllers
{
	public class StudentsController : Controller
	{
		StudentManager studentManager;

		public StudentsController(StudentManager studentManager)
		{
			this.studentManager = studentManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public JsonResult GetList(StudentQueryModel queryModel)
		{
			return Json(studentManager.GetList(queryModel));
		}
	}
}
