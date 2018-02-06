namespace One.Web.Controllers
{
    using System.Web.Mvc;

    public class EmailTemplatesController : BaseController
    {
        // GET: /emailtemplates/basic
        public ActionResult Basic()
        {
            return this.View();
        }

        // GET: /emailtemplates/sidebar
        public ActionResult SideBar()
        {
            return this.View();
        }

        // GET: /emailtemplates/hero
        public ActionResult Hero()
        {
            return this.View();
        }

        // GET: /emailtemplates/sidebarhero
        public ActionResult SideBarHero()
        {
            return this.View();
        }

        // GET: /emailtemplates/newsletter
        public ActionResult NewsLetter()
        {
            return this.View();
        }
    }
}
