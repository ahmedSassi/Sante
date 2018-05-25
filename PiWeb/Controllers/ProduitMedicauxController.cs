using Exam.Domain.Entities;
using Exam.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiWeb.Controllers
{
    public class ProduitMedicauxController : Controller
    {
        IProduitMedicaux pdts=new ProduitMedicauxServices();
        IadminService ad = new AdminService();
        // GET: ProduitMedicaux
        public ActionResult Index()
        {
          var t=  pdts.GetAll();
            return View(t);
        }

        // GET: ProduitMedicaux/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitMedicaux/Create
        public ActionResult Create()
        {
         var a=   ad.GetAll();
            ViewBag.ad = new SelectList(a, "IDAdmin", "IDAdmin");
            return View();
        }

        // POST: ProduitMedicaux/Create
        [HttpPost]
        public ActionResult Create(Produit_Medicaux pdt)
        {
            pdts.Add(pdt);
            pdts.Commit();
            return RedirectToAction("Index");
        }

        // GET: ProduitMedicaux/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitMedicaux/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitMedicaux/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitMedicaux/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
