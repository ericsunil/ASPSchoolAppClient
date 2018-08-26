using ASPSchoolAppClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPSchoolAppClient.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllSlider());
        }

        IEnumerable<Slider> GetAllSlider()
        {
            using (DBModel db = new DBModel())
            {
                return db.Sliders.ToList<Slider>();
            }
        }
        //[HttpGet] iterator will be by default
        public ActionResult AddorEdit(int id = 0)
        {
            Slider emp = new Slider();
            if (id != 0)
            {
                using (DBModel db = new DBModel())
                {
                    emp = db.Sliders.Where(x => x.SliderID == id).FirstOrDefault<Slider>();
                }
            }
            return View(emp);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddorEdit(Slider emp)
        {
            try
            {
                if (emp.ImageUpload != null)
                {
                    String fileName = Path.GetFileNameWithoutExtension(emp.ImageUpload.FileName);
                    String extension = Path.GetFileName(emp.ImageUpload.FileName);
                    fileName = "IMG" + DateTime.Now.ToString("yymmssfff") + extension;
                    emp.ImagePath = "~/AppFiles/Images/Slider/" + fileName;
                    emp.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFiles/Images/Slider/"), fileName));
                }
                using (DBModel db = new DBModel())
                {
                    if (emp.SliderID == 0)
                    {
                        db.Sliders.Add(emp);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(emp).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                return RedirectToAction("Index");
                //return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllSlider()), message = "Submitted Successfully" }, JsonRequestBehavior.AllowGet);
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
                    Slider emp = db.Sliders.Where(x => x.SliderID == id).FirstOrDefault<Slider>();
                    db.Sliders.Remove(emp);
                    db.SaveChanges();

                }
                return Json(new { success = true, html = GlobalClass.RenderRazorViewToString(this, "ViewAll", GetAllSlider()), message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}