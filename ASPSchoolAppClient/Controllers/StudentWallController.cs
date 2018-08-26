using ASPSchoolAppClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPSchoolAppClient.Controllers
{
    public class StudentWallController : Controller
    {
        // GET: StudentWall
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllStudentWall());
        }

        IEnumerable<StudentWall> GetAllStudentWall()
        {
            using (DBModel db = new DBModel())
            {
                return db.StudentWalls.ToList<StudentWall>();
            }
        }

        //[HttpGet] iterator will be by default
        public ActionResult AddorEdit(int id = 0)
        {
            StudentWall emp = new StudentWall();
            if (id != 0)
            {
                using (DBModel db = new DBModel())
                {
                    emp = db.StudentWalls.Where(x => x.StudentWallID == id).FirstOrDefault<StudentWall>();
                }
            }
            return View(emp);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddorEdit(StudentWall emp)
        {
            try
            {
                using (DBModel db = new DBModel())
                {
                    if (emp.StudentWallID == 0)
                    {
                        db.StudentWalls.Add(emp);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(emp).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                return RedirectToAction("Index");
                //return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllStudentWall()), message = "Submitted Successfully" }, JsonRequestBehavior.AllowGet);
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
                    StudentWall emp = db.StudentWalls.Where(x => x.StudentWallID == id).FirstOrDefault<StudentWall>();
                    db.StudentWalls.Remove(emp);
                    db.SaveChanges();

                }
                return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllStudentWall()), message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}