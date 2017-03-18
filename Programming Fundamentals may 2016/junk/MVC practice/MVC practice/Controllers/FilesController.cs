using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_practice.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            var path = @"C:\";
            var all = new List<string>();
            all.AddRange(Directory.GetFiles(path));
            all.AddRange(Directory.GetDirectories(path));

            return View(all);
        }
    }
}