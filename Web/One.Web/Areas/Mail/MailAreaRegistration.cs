namespace One.Web.Areas.Mail
{
    using System.Web.Mvc;

    public class MailAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mail";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Mail_default",
                "Mail/{controller}/{action}/{id}",
                new { action = "Inbox", id = UrlParameter.Optional });
        }
    }
}
