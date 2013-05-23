<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Fonction>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Détails de fonction</h2>

<fieldset>
    <legend>Fonction</legend>

    div class="display-label">ID Fonction</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ID_Fonction) %>
    </div>

    <div class="display-label">Nom Fonction</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom_Fonction) %>
    </div>

    <div class="display-label">Phase</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Phase.Nom_Phase) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Modifier", "Edit", new { id=Model.ID_Fonction }) %> |
    <%: Html.ActionLink("Retour à la liste", "Index") %>
</p>

</asp:Content>
