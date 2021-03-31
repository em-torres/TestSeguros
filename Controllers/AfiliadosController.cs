using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AfiliadosTest.Data;
using AfiliadosTest.Models;

namespace AfiliadosTest.Controllers
{
    public class AfiliadosController : Controller
    {
        private AfiliadosTestContext db = new AfiliadosTestContext();

        // GET: Afiliados
        public ActionResult Index()
        {
            var afiliados = db.Afiliados.Include(a => a.Estatus).Include(a => a.Planes);
            return View(afiliados.ToList());
        }

        // GET: Afiliados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Afiliados afiliados = db.Afiliados.Find(id);
            if (afiliados == null)
            {
                return HttpNotFound();
            }
            return View(afiliados);
        }

        // GET: Afiliados/Create
        public ActionResult Create()
        {
            ViewBag.EstatusID = new SelectList(db.Estatus, "Id", "Estado");
            ViewBag.PlanesID = new SelectList(db.Planes, "Id", "Plan");
            return View();
        }

        // POST: Afiliados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombres,Apellidos,FechaNacimiento,Sexo,Cedula,SeguridadSocial,FechaRegistro,MontoConsumido,PlanesID,EstatusID")] Afiliados afiliados)
        {
            if (ModelState.IsValid)
            {
                db.Afiliados.Add(afiliados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstatusID = new SelectList(db.Estatus, "Id", "Estado", afiliados.EstatusID);
            ViewBag.PlanesID = new SelectList(db.Planes, "Id", "Plan", afiliados.PlanesID);
            return View(afiliados);
        }

        // GET: Afiliados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Afiliados afiliados = db.Afiliados.Find(id);
            if (afiliados == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstatusID = new SelectList(db.Estatus, "Id", "Estado", afiliados.EstatusID);
            ViewBag.PlanesID = new SelectList(db.Planes, "Id", "Plan", afiliados.PlanesID);
            return View(afiliados);
        }

        // POST: Afiliados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombres,Apellidos,FechaNacimiento,Sexo,Cedula,SeguridadSocial,FechaRegistro,MontoConsumido,PlanesID,EstatusID")] Afiliados afiliados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(afiliados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstatusID = new SelectList(db.Estatus, "Id", "Estado", afiliados.EstatusID);
            ViewBag.PlanesID = new SelectList(db.Planes, "Id", "Plan", afiliados.PlanesID);
            return View(afiliados);
        }

        // GET: Afiliados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Afiliados afiliados = db.Afiliados.Find(id);
            if (afiliados == null)
            {
                return HttpNotFound();
            }
            return View(afiliados);
        }

        // POST: Afiliados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Afiliados afiliados = db.Afiliados.Find(id);
            db.Afiliados.Remove(afiliados);
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
