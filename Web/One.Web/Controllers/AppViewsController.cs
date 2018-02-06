namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class AppViewsController : BaseController
    {
        // GET: /appviews/blog
        public ActionResult Blog()
        {
            return this.View();
        }

        // GET: /appviews/projects
        public ActionResult Projects()
        {
            return this.View();
        }

        // GET: /appviews/profile
        public new ActionResult Profile()
        {
            return this.View();
        }

        // GET: /appviews/timeline
        public ActionResult TimeLine()
        {
            return this.View();
        }

        // GET: /appviews/gallery
        public ActionResult Gallery()
        {
            return this.View();
        }
    }
}
