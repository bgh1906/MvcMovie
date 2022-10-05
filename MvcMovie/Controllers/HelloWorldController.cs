using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }



        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}
        ////호출 url https://localhost:7291/HelloWorld/Welcome/7?name=Rick
        ////호출값 Hello Rick, ID: 7


        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}