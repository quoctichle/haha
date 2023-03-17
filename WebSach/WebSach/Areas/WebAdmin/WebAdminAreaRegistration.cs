﻿using System.Web.Mvc;

namespace WebSach.Areas.WebAdmin
{
    public class WebAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WebAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WebAdmin_default",
                "WebAdmin/{controller}/{action}/{id}",
                 defaults: new { area = "WebAdmin", controller = "HomeAdmin", action = "Index", id = UrlParameter.Optional }

            );

            

        }
    }
}