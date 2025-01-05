using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;

namespace WebApplication2.Controllers
{
    public class notficationsController : Controller
    {
        public class NotficationsController : Controller
        {
            private readonly InotificationRepository _notificationsRepository;

            public NotficationsController(InotificationRepository notificationsRepository)
            {
                _notificationsRepository = notificationsRepository;
            }
            // GET: notficationsController
            public ActionResult Index()
            {
                var notifcations = _notificationsRepository.GetAllnotification();
                return View(notifcations);
            }

            // GET: notficationsController/Details/5
            public ActionResult Details(int id)
            {
                return View();
            }

            // GET: notficationsController/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: notficationsController/Create
            [HttpPost]

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

            // GET: notficationsController/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: notficationsController/Edit/5
            [HttpPost]
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

            // GET: notficationsController/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: notficationsController/Delete/5
            [HttpPost]
           
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _notificationsRepository.Deletenotification(id);
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
        }
    }
}
