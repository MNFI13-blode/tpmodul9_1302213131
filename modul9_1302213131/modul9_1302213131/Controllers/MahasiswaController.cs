using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302213131.Controllers
{
    public class MahasiswaController : Controller
    {
        // GET: MahasiswaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MahasiswaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MahasiswaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MahasiswaController/Create
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

        // GET: MahasiswaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MahasiswaController/Edit/5
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

        // GET: MahasiswaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MahasiswaController/Delete/5
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
