namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class HomeController : BaseController
    {
        // GET: home/index
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Social()
        {
            return this.View();
        }

        // GET: home/inbox
        public ActionResult Inbox()
        {
            return this.View();
        }

        // GET: home/widgets
        public ActionResult Widgets()
        {
            return this.View();
        }

        // GET: home/chat
        public ActionResult Chat()
        {
            return this.View();
        }
    }
}
