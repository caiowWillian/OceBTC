using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Oceannic.Filter
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class OceannicAuthentication : ActionFilterAttribute /*AuthorizeAttribute, IAuthorizationFilter*/
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            //var controllerPrincipal = filterContext.ActionDescriptor.ControllerDescriptor;
            var q = 11;
        }

        //    public void OnAuthorization(AuthorizationFilterContext context)
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
