<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MvcApplication2.ViewModels.UserViewModel>" %>


<%
    if (Request.IsAuthenticated) {
%>
        
        Welcome <strong><%: Page.User.Identity.Name %></strong>!
        [ <%: Html.ActionLink("Log Off", "Log Out", "AccountController") %> ]
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Log On", "LogedInUser", "AccountController")%> ]
<%
    }
%>

<%--<% if (Model != null) { %>
    <div>Hello : <%= Html.DisplayFor(model => model.Nom_User) %></div>
<% } %>--%>