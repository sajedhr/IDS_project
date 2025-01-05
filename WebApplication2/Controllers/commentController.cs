using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class commentController : Controller
    {

        private readonly ICommentRepository _ICommentRepository;

        public commentController(ICommentRepository ICommentRepository)
        {
            _ICommentRepository = ICommentRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var comments = _ICommentRepository.GetAllcomments();
            return View(comments);

        }
        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        public IActionResult Create(comment comment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ICommentRepository.Addcomment(comment);
                    return RedirectToAction(nameof(Index));
                }


                return View(comment);
            }
            catch
            {
                return View(comment);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var comment = _ICommentRepository.Getbyid(id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }


        [HttpPost]

        public IActionResult Edit(comment comment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ICommentRepository.Updatecomment(comment);
                    return RedirectToAction(nameof(Index));
                }
                return View(comment);
            }
            catch
            {

                return View(comment);
            }
        }




        // POST: UserController/Delete/5
        [HttpPost]

        public ActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _ICommentRepository.Deletecomment(id);
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
