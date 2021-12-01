using Microsoft.AspNetCore.Mvc;
using SignUpValidation.Models;

namespace SignUpValidation.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if(ModelState.IsValid)
            {
                TempData["Message"] = "Account Created Successfully";
                TempData["Name"] = model.Name;
                return RedirectToAction("Dashboard");
            }
            return View();

        }

        public IActionResult Dashboard()
        {
            string Message = (string)TempData["Message"];
            string Name = (string)TempData["Name"];

            return View();
        }
    }
}
