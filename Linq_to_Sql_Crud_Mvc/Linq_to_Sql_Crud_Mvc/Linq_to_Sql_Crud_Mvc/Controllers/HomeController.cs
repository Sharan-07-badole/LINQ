using Linq_to_Sql_Crud_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Linq_to_Sql_Crud_Mvc.Controllers
{
	// First create controller
	// First create database inside application or in ssms ,
	// now we are creating inside appliaction App_Data folder i.e go to project -> right click ->
	// -> choose new item -> choose inside data folder database in SQL
	// create context class (i.e here we are using linq not EF) inside model folder
	// bcoz all models we are creating inside model itself,
	// model -> right click -> new item -> linq to database (now db context created so through linq not EF)
	// now follow the linq steps i.e drag and drop inside left side in dbml 
	// now come into controller, create object for dbcontext ,
	// call the table method by passing required arguiments (by mistake we create student table by name of table)

	public class HomeController : Controller
    {
		// GET: Home

		// creating context object
		string connectionString = ConfigurationManager.ConnectionStrings["StudentDBConnectionString"].ConnectionString;
		StudentDatabaseDataContext db;


		public ActionResult Index()
        {
			db = new StudentDatabaseDataContext(connectionString);
			// calling student method by converting into list 
			var data = db.Tables.ToList();
            return View(data);
        }	 
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]

		public ActionResult Create(Table s)
		{
			db = new StudentDatabaseDataContext(connectionString);
			db.Tables.InsertOnSubmit(s);
			db.SubmitChanges();
			return RedirectToAction("Index");
		}
		public ActionResult Edit(int id)
		{
			db = new StudentDatabaseDataContext(connectionString);

			var std = db.Tables.Single(x =>x.Id == id);
			return View(std);
		}
		[HttpPost]
		public ActionResult Edit(Table s,int id)
		{
			db = new StudentDatabaseDataContext(connectionString);


			var std = db.Tables.Single(x => x.Id == id);
			std.Name = s.Name;
			std.Gender=s.Gender;
			std.Age=s.Age;		
			std.Standard=s.Standard;
			db.SubmitChanges();
			return RedirectToAction("Index");
		}
		public ActionResult Delete(int id)
		{
			db = new StudentDatabaseDataContext(connectionString);

			var std = db.Tables.Single(x => x.Id == id);
			return View(std);
		}
		[HttpPost]
		public ActionResult Delete(Table s,int id)
		{
			db = new StudentDatabaseDataContext(connectionString);

			var std = db.Tables.Single(x => x.Id == id);
			db.Tables.DeleteOnSubmit(std);
			db.SubmitChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			db = new StudentDatabaseDataContext(connectionString);

			var std = db.Tables.Single(x => x.Id == id);
			return View(std);
		}


	}
}