namespace One.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class GraphsController : BaseController
    {
        // GET: graphs/flot
        public ActionResult Flot()
        {
            return this.View();
        }

        // GET: graphs/morris
        public ActionResult Morris()
        {
            return this.View();
        }

        // GET: graphs/inline
        public ActionResult Inline()
        {
            return this.View();
        }

        // GET: graphs/dygraphs
        public ActionResult Dygraphs()
        {
            return this.View();
        }

        // GET: graphs/chart-js
        public ActionResult ChartJs()
        {
            return this.View();
        }

        // GET: graphs/highcharts
        public ActionResult HighCharts()
        {
            return this.View();
        }
    }
}
