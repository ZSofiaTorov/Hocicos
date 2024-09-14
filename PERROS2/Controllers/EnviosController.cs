using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PERROS2.Controllers
{
    public class EnviosController : Controller
    {
        // GET: EnviosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EnviosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnviosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnviosController/Create
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

        // GET: EnviosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnviosController/Edit/5
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

        // GET: EnviosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnviosController/Delete/5
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
