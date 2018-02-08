namespace One.Web.Areas.Mail.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class InboxController : Controller
    {
        // GET: Mail/Inbox
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
