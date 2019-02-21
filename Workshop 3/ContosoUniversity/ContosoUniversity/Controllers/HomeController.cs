using System.Linq;
using System.Web.Mvc;

using ContosoUniversity.DAL;
using ContosoUniversity.ViewModels;
namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<CourseTitleGroup> data = from enrolledCourse in db.Enrollments
                                                group enrolledCourse by enrolledCourse.CourseID into courseGroup
                                                orderby courseGroup.Count() descending
                                                select new CourseTitleGroup()
                                                {
                                                    Title = (from course in db.Courses where course.CourseID == courseGroup.Key select course.Title).FirstOrDefault(),
                                                    StudentCount = courseGroup.Count()
                                                };
            return View(data.ToList());
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}