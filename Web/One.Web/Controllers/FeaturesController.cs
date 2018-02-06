namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class FeaturesController : BaseController
    {
        // GET: home/calendar
        public ActionResult Calendar()
        {
            return this.View();
        }

        // GET: home/google-map
        public ActionResult GoogleMap()
        {
            return this.View();
        }
    }
}
