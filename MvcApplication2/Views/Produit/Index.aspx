<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication2.Models.Produit>>" %>

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
            Nom_Produit
        </th>
        <th>
            Sous_Famille
        </th>
        <th>
            Profile_Ga
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nom_Produit) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Sous_Famille.Nom_SFamille) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Profile_Ga.In_Ga) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.Code_Produit }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.Code_Produit }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.Code_Produit }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
