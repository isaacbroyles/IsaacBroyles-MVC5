using System.Web.Mvc;
using IsaacBroyles.Repositories;

namespace IsaacBroyles.Controllers
{
    public class PostController : Controller
    {
        private readonly PostRepository _postRepository;

        public PostController(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        //
        // GET: /Post/
        public ActionResult Index()
        {
            return View();
        }

        [HandleError]
        public ActionResult Detail(string title)
        {
            return View(_postRepository.GetPostWithTitle(title));
        }
	}
}