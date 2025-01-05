using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository PostRepository)
        {
            _postRepository = PostRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var posts = _postRepository.GetAllPost();
            return View(posts);

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
        public IActionResult Create(post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _postRepository.AddPost(post);
                    return RedirectToAction(nameof(Index));
                }


                return View(post);
            }
            catch
            {
                return View(post);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var post = _postRepository.Getbyid(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }


        [HttpPost]

        public IActionResult Edit(post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _postRepository.UpdatePost(post);
                    return RedirectToAction(nameof(Index));
                }
                return View(post);
            }
            catch
            {

                return View(post);
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
                    _postRepository.DeletePost(id);
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
