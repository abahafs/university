using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using university_app.Models;

namespace university_app.Controllers
{
    public class RoomController : Controller
    {
        univerdbcontext mydb = new univerdbcontext();
        //[HttpGet] 
        public ActionResult Index()

        {
            List<room> roomLst = new List<room>();

            roomLst = (from R_obj in mydb.rooms
                       select R_obj).ToList();

            return View(roomLst);
            //return RedirectToAction("getRoomDetails", "Room", new { })
        }

        public ActionResult getRoomDetails(int id)
        {
            room RoomDet = new room();

            RoomDet = (from Rdet in mydb.rooms
                       where Rdet.Id == id
                       select Rdet).FirstOrDefault();

            return View(RoomDet);
        }

        public ActionResult DeleteRoom(int id)
        {
            room DelRoom = new room();
            DelRoom = (from D_room in mydb.rooms
                       where D_room.Id == id
                       select D_room).FirstOrDefault();

            mydb.rooms.Remove(DelRoom);

            mydb.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult InsertRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertRoom(room room,string isavilable)
        {

            if (isavilable=="on")
            {
                room.isavilable = true;
            }
            else
            {
                room.isavilable = false;
            }
            mydb.rooms.Add(room);

            mydb.SaveChanges();

            return RedirectToAction("index");
        }
    }
}