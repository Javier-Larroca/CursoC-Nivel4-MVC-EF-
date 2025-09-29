using dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using negocio;

namespace discos_mvc.Controllers
{
    public class EstiloController : Controller
    {
        // GET: EstiloController
        public ActionResult Index()
        {
            EstiloNegocio negocio = new EstiloNegocio();
            var listEstilos = negocio.listar();

            return View(listEstilos);
        }

        // GET: EstiloController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstiloController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estilo estilo)
        {
            try
            {
                EstiloNegocio negocio = new EstiloNegocio();

                if (!ModelState.IsValid)
                {
                    return View(estilo);
                }

                negocio.agregar(estilo);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstiloController/Edit/5
        public ActionResult Edit(int id)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            var estilo = estiloNegocio.listar().Find(d => d.Id == id);

            return View(estilo);
        }

        // POST: EstiloController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Estilo estilo)
        {
            try
            {
                EstiloNegocio negocio = new EstiloNegocio();
                negocio.modificar(estilo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstiloController/Delete/5
        public ActionResult Delete(int id)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            var estilo = estiloNegocio.listar().Find(d => d.Id == id);

            return View(estilo);
        }

        // POST: EstiloController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                EstiloNegocio negocio = new EstiloNegocio();
                negocio.eliminar(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
