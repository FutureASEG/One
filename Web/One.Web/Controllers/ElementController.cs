namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class ElementController : BaseController
    {
        // GET: /elements/general/
        public ActionResult General()
        {
            return this.View();
        }

        // GET: /elements/buttons/
        public ActionResult Buttons()
        {
            return this.View();
        }
    }
}
