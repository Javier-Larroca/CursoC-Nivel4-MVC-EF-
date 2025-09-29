using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace discos_mvc.Controllers
{
    public class TipoEdicionController : Controller
    {
        // GET: TipoEdicionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoEdicionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoEdicionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEdicionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoEdicionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoEdicionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoEdicionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoEdicionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
