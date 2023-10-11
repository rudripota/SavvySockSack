using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
//using the above connotation to make sure the function runs

namespace SavvySockSack.Controllers
{
    public class HelloSocks : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
