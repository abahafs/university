using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using university_app.Models;

namespace university_app.Controllers
{
    public class studentController : Controller
    {
        univerdbcontext mydb = new univerdbcontext();
        public ActionResult Index()
        {
            List<student> studentLst = new List<student>();
            studentLst = (from stdList in mydb.students
                          select stdList).ToList();

            return View(studentLst);
        }
        [HttpGet]
        public ActionResult InsertStudent()
        {
            return View();   
        }

        [HttpPost]
        public ActionResult InsertStudent(student student)
        {
            mydb.students.Add(student);
            mydb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteStudent(int id)
        {
            student student = new student();
            student = (from obj in mydb.students
                       where obj.ID == id
                       select obj).FirstOrDefault();

            mydb.students.Remove(student);
            mydb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetDetails(int id)
        {
            student student = new student();
            student = (from obj in mydb.students
                       where obj.ID == id
                       select obj).FirstOrDefault();

            return View(student);
        }
        
    }
}