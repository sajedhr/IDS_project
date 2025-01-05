using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class PostCategoryController : Controller
    {
        private readonly IpostcategoryRepos _postcategRepository;

        public PostCategoryController(IpostcategoryRepos PostcategRepository)
        {
            _postcategRepository = PostcategRepository;
        }
        // GET: PostCategoryController
        [HttpGet]
        public ActionResult Index()
        {
            var postsctg = _postcategRepository.GetAllpostcategory();
            return View(postsctg);
          
        }

        // GET: PostCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostCategoryController/Create
        [HttpPost]
        public ActionResult Create(postcategory postctg)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _postcategRepository.Addpostcategory(postctg);
                    return RedirectToAction(nameof(Index));
                }


                return View(postctg);
            }
            catch
            {
                return View(postctg);
            }
        }


        // GET: PostCategoryController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var postcategory = _postcategRepository.Getbyid(id);
            if (postcategory == null)
            {
                return NotFound();
            }
            return View(postcategory);
        }


        // POST: PostCategoryController/Edit/5
        [HttpPost]
        
        public ActionResult Editt(postcategory postcategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _postcategRepository.Updatepostcategory(postcategory);
                    return RedirectToAction(nameof(Index));
                }
                return View(postcategory);
            }
            catch
            {

                return View(postcategory);
            }
        }

        // GET: PostCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostCategoryController/Delete/5
        [HttpPost]
    
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _postcategRepository.Deletepostcategory(id);
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
