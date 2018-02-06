namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class ForumController : BaseController
    {
        // GET: /forum/general-view
        public ActionResult GeneralView()
        {
            return this.View();
        }

        // GET: /forum/topic-view
        public ActionResult TopicView()
        {
            return this.View();
        }

        // GET: /forum/post-view
        public ActionResult PostView()
        {
            return this.View();
        }
    }
}
