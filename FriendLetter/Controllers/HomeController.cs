using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }
        [Route("/goodbye")]
        public string GoodBye() { return "GoodBye friend.";}

        [Route("/")]
        public  ActionResult Letter()
        {
          return View();
        }
        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }

    }
}
