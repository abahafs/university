using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using university_app.Models;

namespace university_app.Controllers
{
    public class HomeController : Controller
    {
        univerdbcontext mydb = new univerdbcontext();

        course courses = new course();
        room rooms = new room();
        student students = new student();
        teacher teachers = new teacher();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        

        [HttpPost]
        public ActionResult Index( string query)
        {
            List<course> courses = (from obj in mydb.courses
                                    where obj.courseName.ToUpper().Contains(query.ToUpper())
                                    select obj).ToList();
            ViewBag.coursesList = courses;
            return View();
            //room room = (from obj in mydb.rooms
            //             select obj).FirstOrDefault();
            //student student = (from obj in mydb.students
            //                   select obj).FirstOrDefault();
            //teacher teacher = (from obj in mydb.teachers
            //                   select obj).FirstOrDefault();



            //if (anything == courses.courseName)
            //{
            //if (thingID != null)
            //    {
            //        courses.Id = int.Parse(thingID);

            //}
            //}
            //else if (anything == rooms.Roomname)
            //{
            //    if (thingID != null)
            //    {
            //        rooms.Id = int.Parse(thingID);
            //    }
            //    return RedirectToAction("getRoomDetails", "Room");
            //}
            //else if (anything == students.studentname)
            //{
            //    if (thingID != null)
            //    {
            //        students.ID = int.Parse(thingID);
            //    }
            //    return RedirectToAction("GetDetails", "student");
            //}
            //else if (anything == teachers.teachertname)
            //{
            //    if (thingID != null)
            //    {
            //        teachers.ID = int.Parse(thingID);
            //    }
            //    return RedirectToAction("GetDetails", "student");
            //}

            //else return View() ;
        }
    }
}