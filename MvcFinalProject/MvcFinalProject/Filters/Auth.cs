using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using MvcFinalProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFinalProject.Filters
{
    public class Auth:ActionFilterAttribute
    {
        private readonly CorporXContext _context;
        public Auth(CorporXContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool hasToken = context.HttpContext.Request.Cookies.TryGetValue("token", out string token);
            if (!hasToken)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "index", controller = "home", area = "control" }));
            }
            var user = _context.Users.FirstOrDefault(u => u.Token == token);
            if (user == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "index", controller = "home", area = "control" }));
            }
            context.RouteData.Values["User"] = user;
            base.OnActionExecuting(context);
        }
    }
}
