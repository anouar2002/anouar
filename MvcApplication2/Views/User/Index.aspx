<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication2.Models.User>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gestion des utilisateurs</h2>
<br />

<table>
    <tr>
     <th>
            Matricule
        </th>
        <th>
            Nom Utilisateur
        </th>
        <th>
            Mot de Passe
        </th>
        <th>
            Type Utilisateur
        </th>
        <th>
            ID UF
        </th>
        <th>
        Opérations
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
         <td>
            <%: Html.DisplayFor(modelItem => item.Matricule) %>
        </td>

        <td>
            <%: Html.DisplayFor(modelItem => item.Nom_User) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.passWord) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Type_User) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ID_UF) %>
        </td>
        <td>
            <%: Html.ActionLink("Modifier", "Edit", new { id=item.Matricule }) %> |
            <%: Html.ActionLink("Détails", "Details", new { id=item.Matricule }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.Matricule }) %>
        </td>
    </tr>
<% } %>

</table>
<br />
<p>
    <%: Html.ActionLink("Ajouter un nouveau utilisateur", "Create") %>
</p>
</asp:Content>
