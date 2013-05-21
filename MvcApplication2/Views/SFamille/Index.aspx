<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication2.Models.Sous_Famille>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            Nom_SFamille
        </th>
        <th>
            Profile_Ga
        </th>
        <th>
            Famille
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nom_SFamille) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Profile_Ga.In_Ga) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Famille.Nom_Famille) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.ID_SFamaille }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.ID_SFamaille }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.ID_SFamaille }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
