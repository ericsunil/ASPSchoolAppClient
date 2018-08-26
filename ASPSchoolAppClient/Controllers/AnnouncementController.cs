using ASPSchoolAppClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPSchoolAppClient.Controllers
{
    public class AnnouncementController : Controller
    {
        // GET: Announcement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllAnnouncement());
        }

        IEnumerable<Announcement> GetAllAnnouncement()
        {
            using (DBModel db = new DBModel())
            {
                return db.Announcements.ToList<Announcement>();
            }
        }

        //[HttpGet] iterator will be by default
        public ActionResult AddorEdit(int id = 0)
        {
            Announcement emp = new Announcement();
            if (id != 0)
            {
                using (DBModel db = new DBModel())
                {
                    emp = db.Announcements.Where(x => x.AnnouncementID == id).FirstOrDefault<Announcement>();
                }
            }
            return View(emp);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddorEdit(Announcement emp)
        {
            try
            {
                using (DBModel db = new DBModel())
                {
                    if (emp.AnnouncementID == 0)
                    {
                        db.Announcements.Add(emp);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(emp).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                return RedirectToAction("Index");
                //return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllAnnouncement()), message = "Submitted Successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                using (DBModel db = new DBModel())
                {
                    Announcement emp = db.Announcements.Where(x => x.AnnouncementID == id).FirstOrDefault<Announcement>();
                    db.Announcements.Remove(emp);
                    db.SaveChanges();

                }
                return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllAnnouncement()), message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}