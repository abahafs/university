using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using university_app.Models;

namespace university_app.Controllers
{
    public class CoursesController : BaseController
    {
        univerdbcontext myDb = new univerdbcontext();
        //int x = 0;
        public ActionResult getCourses()
        {

            //int y = 0;
            List<course> courseList = new List<course>();
            courseList = (from obj in myDb.courses
                          select obj).ToList();
            //var s_list = myDb.courses.OrderBy(x => x.Id).ToList();
            return View(courseList);
        }

        public ActionResult CourseDetails(int id)
        {
            course courseDet = new course();
            courseDet = (from xyz in myDb.courses
                         where xyz.Id == id
                         select xyz).FirstOrDefault();
            if (courseDet!=null)
            {
                courseDet.teacher= (from xyz in myDb.teachers
                                    where xyz.ID == courseDet.TeachId
                                    select xyz).FirstOrDefault();
                courseDet.room = (from xyz in myDb.rooms
                                     where xyz.Id == courseDet.RoomId
                                     select xyz).FirstOrDefault();
            }
            //var s_w = myDb.courses.Where(x => x.Id == id).FirstOrDefault();
            return View(courseDet);

        }

        [HttpGet]
        public ActionResult insertCourse()
        {
            List<teacher> DDL_tech = (from obj in myDb.teachers
                                      select obj).ToList();
            List<room> DDL_Room = (from r_lst in myDb.rooms
                                   where r_lst.isavilable == true
                                     select r_lst).ToList();

            ViewBag.teacherList = DDL_tech;
            ViewBag.RoomDlist = DDL_Room;

            return View();
        }

        [HttpPost]
        public ActionResult inesrtCourse (course Course,string TeacherID,string RoomID)
        {
            if (RoomID != null)
            {
                Course.RoomId = int.Parse(RoomID);
            }

            if (TeacherID!=null)
            {
                Course.TeachId = int.Parse(TeacherID);
            }
            //courseobj.uid = userId;
            myDb.courses.Add(Course);

            myDb.SaveChanges();

            return RedirectToAction("getCourses");
        }

        public ActionResult DeleteCourse(int id)
        {
            course course = (from obj in myDb.courses
                             where obj.Id == id
                             select obj).FirstOrDefault();

            myDb.courses.Remove(course);

            myDb.SaveChanges();
            return RedirectToAction("getCourses");
        }

       

    }

}