namespace One.Web.Controllers
{
    using System.Web.Mvc;

    public class IntelController : BaseController
    {
        // GET: /intel/settings
        public ActionResult Settings()
        {
            return this.View();
        }

        // GET: /intel/skins
        public ActionResult Skins()
        {
            return this.View();
        }

        // GET: /intel/applayout
        public ActionResult AppLayout()
        {
            return this.View();
        }
    }
}
