namespace One.Web.Controllers
{
    using System.Web.Mvc;

    public class CommerceController : BaseController
    {
        // GET: /commerce/orders
        public ActionResult Orders()
        {
            return this.View();
        }

        // GET: /commerce/productview
        public ActionResult ProductView()
        {
            return this.View();
        }

        // GET: /commerce/detail
        public ActionResult Detail()
        {
            return this.View();
        }
    }
}
