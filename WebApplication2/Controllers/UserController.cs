using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var users = _userRepository.GetAllUsers();
            return View(users);

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
        public IActionResult Create(user user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userRepository.AddUser(user);
                    return RedirectToAction(nameof(Index));
                }

          
                return View(user);
            }
            catch
            {
                return View(user);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }


        [HttpPost]
 
        public IActionResult Edit(user user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userRepository.UpdateUser(user);
                    return RedirectToAction(nameof(Index));
                }
                return View(user);
            }
            catch
            {
           
                return View(user);
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
                    _userRepository.DeleteUser(id);
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
