using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class CategoryController : Controller
    {

        private readonly IcategoryRepository _IcategoryRepository;

        public CategoryController(IcategoryRepository IcategoryRepository)
        {
            _IcategoryRepository = IcategoryRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var category= _IcategoryRepository.GetAllcategory();
            return View(category);

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
        public IActionResult Create(category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IcategoryRepository.Addcategory(category);
                    return RedirectToAction(nameof(Index));
                }


                return View(category);
            }
            catch
            {
                return View(category);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _IcategoryRepository.Getbyid(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]

        public IActionResult Edit(category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _IcategoryRepository.Updatecategory(category);
                    return RedirectToAction(nameof(Index));
                }
                return View(category);
            }
            catch
            {

                return View(category);
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
                    _IcategoryRepository.Deletecategory(id);
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
