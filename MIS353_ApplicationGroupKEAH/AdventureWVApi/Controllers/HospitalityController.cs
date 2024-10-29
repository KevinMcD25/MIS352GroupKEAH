using AdventureWVApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWVApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalityController : ControllerBase
    {
        private readonly IHospitalityService hospitalityService;
        // GET: HospitalityController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HospitalityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HospitalityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalityController/Create
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

        // GET: HospitalityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HospitalityController/Edit/5
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

        // GET: HospitalityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HospitalityController/Delete/5
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
