using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplicationMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // 
        // GET: /HelloWorld/        
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        //// 
        //// GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        // does not like having more than one method with the same name
        //    return "This is the Welcome action method...";
        //}


        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, string name2, int numTimes = 1)//numTimes initialized in paramater? and must be supplied?
        // does not like overloads
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        // GET: /HelloWorld/Welcome/         
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

    }
}