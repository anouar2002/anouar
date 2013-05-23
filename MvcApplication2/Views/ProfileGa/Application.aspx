<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.FlowViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Application
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Application</h2>
    <form id="form1" runat="server">

<h2><%= Html.Encode(ViewData["Message"]) %> </h2>
   <div>         
         <%:Html.Label("Type :")%><%: Html.DropDownListFor(model => model.SelectedGenre, Model.GenreItems)%>

   </div>

   <table border = "transparent">
    <tr>
        <th>
            
        </th>
        
        </tr>

        <% foreach (var item in Model.FaItems) { %>
    <tr>
         <td>
            <%: Html.DisplayFor(modelItem => item.Nom_Famille) %> 
        </td>
        
        
    </tr>
    <% } %>
    </table>
</form>
</asp:Content>
