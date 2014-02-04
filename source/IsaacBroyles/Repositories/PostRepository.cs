using IsaacBroyles.Data;
using IsaacBroyles.Models;
using IsaacBroyles.Utilities;
using System.IO;
using System.Web;

namespace IsaacBroyles.Repositories
{
    public class PostRepository
    {
        private readonly IFormatter _postFormatter;

        private static readonly string POSTS_PATH = HttpContext.Current.Server.MapPath("~/Content/markdown/posts");

        public PostRepository(IFormatter postFormatter)
        {
            _postFormatter = postFormatter;
        }

        public Post GetPostWithTitle(string title)
        {
            try
            {
                TextFile file = new TextFile(GetFilePathFromTitle(title));
                var textFromFile = file.Read();

                return new Post { Content = _postFormatter.Transform(textFromFile) };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static string GetFilePathFromTitle(string title)
        {
            return Path.Combine(POSTS_PATH, GetFileNameFromTitle(title));
        }

        public static string GetFileNameFromTitle(string title)
        {
            return title + ".md";
        }
    }
}