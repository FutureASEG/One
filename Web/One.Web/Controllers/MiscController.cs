namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class MiscController : BaseController
    {
        // GET: /misc/pricing
        public ActionResult Pricing()
        {
            return this.View();
        }

        // GET: /misc/invoice
        public ActionResult Invoice()
        {
            return this.View();
        }

        // GET: /misc/blank
        public ActionResult Blank()
        {
            return this.View();
        }

        // GET: /misc/email-template
        public ActionResult EmailTemplate()
        {
            return this.View();
        }

        // GET: /misc/search
        public ActionResult Search()
        {
            return this.View();
        }

        // GET: /misc/ck-editor
        public ActionResult CKEditor()
        {
            return this.View();
        }

        // GET: /misc/error404
        public ActionResult Error404()
        {
            return this.View();
        }

        // GET: /misc/error500
        public ActionResult Error500()
        {
            return this.View();
        }
    }
}
