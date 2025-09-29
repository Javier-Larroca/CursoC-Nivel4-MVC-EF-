using dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using negocio;

namespace discos_mvc.Controllers
{
    public class DiscosController : Controller
    {
        // GET: DiscosController
        public ActionResult Index()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            var listDiscos = negocio.listar();

            return View(listDiscos);
        }

        // GET: DiscosController/Details/5
        public ActionResult Details(int id)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            var disco = discoNegocio.listar().Find(d => d.Id == id);
            return View(disco);
        }

        // GET: DiscosController/Create
        public ActionResult Create()
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            ViewBag.Estilos = new SelectList(estiloNegocio.listar(), "Id", "Descripcion");

            TipoEdicionNegocio tipoNegocio = new TipoEdicionNegocio();
            ViewBag.Tipos = new SelectList(tipoNegocio.listar(), "Id", "Descripcion");

            return View();
        }

        // POST: DiscosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Disco disco)
        {
            try
            {
                DiscoNegocio negocio = new DiscoNegocio();

                if (!ModelState.IsValid)
                {
                    return View(disco);
                }

                negocio.agregar(disco);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiscosController/Edit/5
        public ActionResult Edit(int id)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoNegocio = new TipoEdicionNegocio();

            var disco = discoNegocio.listar().Find(d=>d.Id==id);

            var listaEstilos = estiloNegocio.listar();

            var listaTipos = tipoNegocio.listar();

            ViewBag.Estilos = new SelectList(listaEstilos, "Id", "Descripcion", disco.Estilo.Id);
            ViewBag.Tipos = new SelectList(listaTipos, "Id", "Descripcion", disco.TipoEdicion.Id);

            return View(disco);
        }

        // POST: DiscosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Disco disco)
        {
            try
            {
                DiscoNegocio negocio = new DiscoNegocio();
                negocio.modificar(disco);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiscosController/Delete/5
        public ActionResult Delete(int id)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            var disco = discoNegocio.listar().Find(d => d.Id == id);
            return View(disco);
        }

        // POST: DiscosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                DiscoNegocio negocio = new DiscoNegocio();
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
