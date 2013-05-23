<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication2.Models.Fonction>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gestion de fonctions</h2>

<p>
    <%: Html.ActionLink("Ajouter une nouvelle fonction", "Create") %>
</p>
<table>
    <tr><th>
            ID Fonction
        </th>

        <th>
            Nom Fonction
        </th>
        <th>
            Phase
        </th>
        <th>Opérations</th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
         <td>
            <%: Html.DisplayFor(modelItem => item.ID_Fonction) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nom_Fonction) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Phase.Nom_Phase) %>
        </td>
        <td>
            <%: Html.ActionLink("Modifier", "Edit", new { id=item.ID_Fonction }) %> |
            <%: Html.ActionLink("Détails", "Details", new { id=item.ID_Fonction }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.ID_Fonction }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
