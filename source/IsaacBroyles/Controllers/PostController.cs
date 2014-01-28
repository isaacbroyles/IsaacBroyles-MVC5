using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IsaacBroyles.Repositories;

namespace IsaacBroyles.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/
        public ActionResult Index()
        {
            return View();
        }

        [HandleError]
        public ActionResult Detail(string title)
        {
            return View(PostRepository.GetPostWithTitle(title));
        }
	}
}