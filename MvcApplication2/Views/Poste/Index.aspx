<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication2.Models.Poste>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gestion des Postes</h2>
<br />

<table>
    <tr>
        <th>
        ID Poste
        </th>
        <th>
            Nom Poste
        </th>
        <th>
            Application
        </th>
        <th>
            In Poste
        </th>
        <th>
            Out Poste
        </th>
        <th>
            Etat
        </th>
        <th>
            ID Ligne
        </th>
        <th>
            Mouvement
        </th>
        <th>
        Opérations
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.ID_Poste) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.nom_Poste) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Application) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.In_Po) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Out_Po) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Etat) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ID_Ligne) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Mouvement) %>
        </td>
        <td>
            <%: Html.ActionLink("Modifier", "Edit", new { id=item.ID_Poste }) %> |
            <%: Html.ActionLink("Détails", "Details", new { id=item.ID_Poste }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.ID_Poste }) %>
        </td>
    </tr>
<% } %>

</table>
<br />
<p>
    <%: Html.ActionLink("Ajouter un nouveau Poste", "Create") %>
</p>

</asp:Content>
