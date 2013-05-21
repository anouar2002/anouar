using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Filters
{
    public class ActionLogFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
            
        //    GammeContext db = new GammeContext();
        //    ActionLog log = new ActionLog()
        //    {
        //        Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
        //        Action = filterContext.ActionDescriptor.ActionName,
        //        IP = filterContext.HttpContext.Request.UserHostAddress,
        //        DateTime = filterContext.HttpContext.Timestamp
        //    };
        //    db.AddToActionLogs(log);
        //    db.SaveChanges();
        //    base.OnActionExecuting(filterContext);
        //}

    }
}