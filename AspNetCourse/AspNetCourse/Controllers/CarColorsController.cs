using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetCourse.Models;

namespace AspNetCourse.Controllers
{
    public class CarColorsController : Controller
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: CarColors
        public ActionResult Index()
        {
            var carColors = db.CarColors.Include(c => c.car).Include(c => c.color);
            return View(carColors.ToList());
        }

        // GET: CarColors/Details/5
        public ActionResult Details(int? idCar, int? idColor)
        {
            if (idCar == null || idColor == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarColor carColor = db.CarColors.Include("car").Include("color").SingleOrDefault(x => x.idCar == idCar && x.idColor == idColor);
            if (carColor == null)
            {
                return HttpNotFound();
            }
            return View(carColor);
        }

        // GET: CarColors/Create
        public ActionResult Create()
        {
            ViewBag.idCar = new SelectList(db.Car, "registrationNumber", "registrationNumber");
            ViewBag.idColor = new SelectList(db.Color, "idColor", "name");
            return View();
        }

        // POST: CarColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCar,idColor")] CarColor carColor)
        {
            if (ModelState.IsValid)
            {
                db.CarColors.Add(carColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCar = new SelectList(db.Car, "registrationNumber", "registrationNumber", carColor.idCar);
            ViewBag.idColor = new SelectList(db.Color, "idColor", "name", carColor.idColor);
            return View(carColor);
        }

        // GET: CarColors/Edit/5
        public ActionResult Edit(int? idCar, int? idColor)
        {
            if (idCar == null || idColor == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarColor carColor = db.CarColors.Include("car").Include("color").SingleOrDefault(x => x.idCar == idCar && x.idColor == idColor);
            if (carColor == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCar = new SelectList(db.Car, "registrationNumber", "registrationNumber", carColor.idCar);
            ViewBag.idColor = new SelectList(db.Color, "idColor", "name", carColor.idColor);
            return View(carColor);
        }

        // POST: CarColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCar,idColor")] CarColor carColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCar = new SelectList(db.Car, "registrationNumber", "registrationNumber", carColor.idCar);
            ViewBag.idColor = new SelectList(db.Color, "idColor", "name", carColor.idColor);
            return View(carColor);
        }

        // GET: CarColors/Delete/5
        public ActionResult Delete(int? idCar, int? idColor)
        {
            if (idCar == null || idColor == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarColor carColor = db.CarColors.Include("car").Include("color").SingleOrDefault(x => x.idCar == idCar && x.idColor == idColor);
            if (carColor == null)
            {
                return HttpNotFound();
            }
            return View(carColor);
        }

        // POST: CarColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int idCar, int idColor)
        {
            CarColor carColor = db.CarColors.Find(idCar, idColor);
            db.CarColors.Remove(carColor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
