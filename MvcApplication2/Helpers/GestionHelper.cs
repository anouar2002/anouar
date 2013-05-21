using System;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;



namespace Helpers
{
    public static class GestionHelper
    {
        public static string GestionLinkHelper(this HtmlHelper helper){
            string currentControllerName = (string)helper.ViewContext.RouteData.Values["controller"];
            string currentActionName = (string)helper.ViewContext.RouteData.Values["action"];
            
            var sb = new StringBuilder();
            
            sb.Append("<div id=\"gestionlink\">");

            sb.Append(helper.ActionLink("aaaaa", "Gestion", "Anouar"));
            sb.Append("</div>");
            return sb.ToString();
        }
    }
}