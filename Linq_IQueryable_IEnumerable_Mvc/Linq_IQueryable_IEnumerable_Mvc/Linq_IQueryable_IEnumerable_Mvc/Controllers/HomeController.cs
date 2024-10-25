using Linq_IQueryable_IEnumerable_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Linq_IQueryable_IEnumerable_Mvc.Controllers
{
	public class HomeController : Controller
    {
		// GET: Home
		StudentDatabaseDataContext db;
		public ActionResult Index()
        {
			db = new StudentDatabaseDataContext();
			IEnumerable<Student> std = db.Students.Where(y => y.standard.Equal(11));
            return View();
        }
    }
}