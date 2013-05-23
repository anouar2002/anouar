<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Fonction>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Supprimer une fonction</h2>

<h3>Etes-vous sûr de vouloir supprimer cette fonction ?</h3>
<fieldset>
    <legend>Fonction</legend>
    
    <div class="display-label">ID_Fonction</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ID_Fonction) %>
    </div>

    <div class="display-label">Nom_Fonction</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom_Fonction) %>
    </div>

    <div class="display-label">Phase</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Phase.Nom_Phase) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Supprimer" /> |
        <%: Html.ActionLink("Retour à la liste", "Index") %>
    </p>
<% } %>

</asp:Content>
