namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class TablesController : BaseController
    {
        // GET: tables/normal
        public ActionResult Normal()
        {
            return this.View();
        }

        // GET: tables/data-tables
        public ActionResult DataTables()
        {
            return this.View();
        }

        // GET: tables/jq-grid
        public ActionResult JQGrid()
        {
            return this.View();
        }
    }
}
