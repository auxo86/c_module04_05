using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace module04_05.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //GET: Home/GetVideo
        //利用action取檔案
        public ActionResult GetVideo()
        {
            return File("~/Content/movie.mp4", "video/mp4");
        }
    }
}