using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos.UserRegisterDtos;

namespace MovieApi.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(CreateUserRegisterDto createUserRegisterDto) 
        {

            return RedirectToAction("SignIn","Login");
        }
    }
}
