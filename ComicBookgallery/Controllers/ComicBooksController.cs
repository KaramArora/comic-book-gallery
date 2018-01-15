using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return Content ("Hello, this is Karam from Comic books");
        }
    }
}