using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRegioesMVC.Controllers
{
    public class RegiaoFornecedorController : Controller
    {
        private RegioesADO.ADO.RegiaoDAO regiaoDAO = new RegioesADO.ADO.RegiaoDAO();

        // GET: Regiao
        public ActionResult Index()
        {
            return View(regiaoDAO.findAll());
        }

        // GET: Regiao/Details/5
        public ActionResult Details(long id)
        {
            return View(regiaoDAO.findOne(id));
        }

        // GET: Regiao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regiao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regiao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Regiao/Edit/5
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

        // GET: Regiao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Regiao/Delete/5
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