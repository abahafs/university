using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using university_app.Models;

namespace university_app.Controllers
{
    public class teacherController : Controller
    {
        univerdbcontext mydb = new univerdbcontext();
        public ActionResult Index()
        {
            List<teacher> teachersLst = new List<teacher>();
            teachersLst = (from TList in mydb.teachers
                           select TList).ToList();

            return View(teachersLst);
        }
        [HttpGet]
        public ActionResult InsertTeacher()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertTeacher(teacher teacher)
        {
            mydb.teachers.Add(teacher);
            mydb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetDetails(int id)
        {
            teacher tech = new teacher();
            tech = (from obj in mydb.teachers
                    where obj.ID == id
                    select obj).FirstOrDefault();


            return View(tech);
        }

        public ActionResult DeleteTeacher(int ID)
        {
            teacher teacher = new teacher();
            teacher = (from obj in mydb.teachers
                       where obj.ID == ID
                       select obj).FirstOrDefault();

            mydb.teachers.Remove(teacher);
            mydb.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}