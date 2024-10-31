using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWVApi.Controllers
{
    public class UserTravelController : Controller
    {
        // GET: UserTravelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserTravelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserTravelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTravelController/Create
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

        // GET: UserTravelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserTravelController/Edit/5
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

        // GET: UserTravelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserTravelController/Delete/5
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
