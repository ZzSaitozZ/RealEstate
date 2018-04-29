using System.Web.Mvc;

namespace RealEstate.Areas.Details
{
    public class DetailsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Details";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Details_default",
                "Details/{controller}/{action}/{id}",
                new { action = "Items", id = UrlParameter.Optional }
            );
        }
    }
}