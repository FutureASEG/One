namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class IconsController : BaseController
    {
        // GET: /icons/fontawesome
        public ActionResult FontAwesome()
        {
            return this.View();
        }

        // GET: /icons/glyphicons
        public ActionResult GlyphIcons()
        {
            return this.View();
        }

        // GET: /icons/flags
        public ActionResult Flags()
        {
            return this.View();
        }

        // GET: /icons/grid
        public ActionResult Grid()
        {
            return this.View();
        }

        // GET: /icons/treeview
        public ActionResult TreeView()
        {
            return this.View();
        }

        // GET: /icons/nested-lists
        public ActionResult NestedLists()
        {
            return this.View();
        }

        // GET: /icons/jquery-ui
        public ActionResult JQueryUI()
        {
            return this.View();
        }

        // GET: /icons/typography
        public ActionResult Typography()
        {
            return this.View();
        }
    }
}
