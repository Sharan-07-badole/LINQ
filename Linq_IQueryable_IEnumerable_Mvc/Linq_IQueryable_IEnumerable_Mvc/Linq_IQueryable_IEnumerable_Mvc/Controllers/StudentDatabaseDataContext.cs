using System.Collections.Generic;

namespace Linq_IQueryable_IEnumerable_Mvc.Controllers
{
	internal class StudentDatabaseDataContext
	{
		public IEnumerable<object> Students { get; internal set; }
	}
}