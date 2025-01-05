using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class VoteController : Controller
    {

        private readonly IVoteRepository _VoteRepository;

        public VoteController(IVoteRepository VoteRepository)
        {
            _VoteRepository = VoteRepository;
        }
        // GET: VoteController
        [HttpGet]
        public ActionResult Index()
        {
            var vote = _VoteRepository.GetAllvote();
            return View(vote);
         
        }

        // GET: VoteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VoteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VoteController/Create
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

        // GET: VoteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VoteController/Edit/5
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

        // GET: VoteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VoteController/Delete/5
        [HttpPost]
       
        public ActionResult Deletee(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _VoteRepository.Deletevote(id);
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
