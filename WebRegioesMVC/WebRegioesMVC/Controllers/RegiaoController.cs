using System.Web.Mvc;

using RegioesADO.ADO;
using RegioesADO.Model;

namespace WebRegioesMVC.Controllers
{
    public class RegiaoController : Controller
    {
        private RegiaoDAO regiaoDAO = new RegiaoDAO();
        private Regiao regiao = new Regiao();

        public ActionResult Index()
        {
            ViewBag.SelecaoId = new SelectList(regiaoDAO.findAll(), "estado.idEstado", "estado.uf");

            regiao.regioes = regiaoDAO.findAll();

            return View(regiao);
        }

        [HttpPost]
        public ActionResult Save(Regiao regiao)
        {
            //if (ModelState.IsValid)
            //{
                new RegiaoDAO().addNew(regiao);

                Regiao regiaoNova = new Regiao(); 

                regiaoNova.regioes = regiaoDAO.findAll();

                return View("Index", regiaoNova);
            //}
            //else
            //    return View("Cadastro", new Regiao());
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Regiao regiaoUpdate = new Regiao();

                regiaoUpdate = regiaoDAO.findOne(id);

                Estado estado = new Estado();
                estado.UF = collection.GetValue("UF").ToString();

                regiao.regioes = regiaoDAO.findAll();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
