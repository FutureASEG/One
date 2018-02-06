namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class FormsController : BaseController
    {
        // GET: /forms/smart-elements/
        public ActionResult SmartElements()
        {
            return this.View();
        }

        // GET: /forms/templates/
        public ActionResult Templates()
        {
            return this.View();
        }

        // GET: /forms/validation/
        public ActionResult Validation()
        {
            return this.View();
        }

        // GET: /forms/bootstrap/
        public ActionResult Bootstrap()
        {
            return this.View();
        }

        // GET: /forms/plugins/
        public ActionResult Plugins()
        {
            return this.View();
        }

        // GET: /forms/wizard/
        public ActionResult Wizards()
        {
            return this.View();
        }

        // GET: /forms/editors/
        public ActionResult Editors()
        {
            return this.View();
        }

        // GET: /forms/dropzone/
        public ActionResult Dropzone()
        {
            return this.View();
        }

        // GET: /forms/cropping/
        public ActionResult Cropping()
        {
            return this.View();
        }
    }
}
