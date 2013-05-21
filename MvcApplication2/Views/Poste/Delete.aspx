<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Poste>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Supprimer un poste</h2>

<h3>Etes-vous sûr de vouloir supprimer ce poste ?</h3>
<form id="form1" runat="server">
<fieldset>
    <legend>Poste</legend>

    <div class="display-label">Nom Poste :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.nom_Poste) %>
    </div>

    <div class="display-label">Application :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Application) %>
    </div>

    <div class="display-label">In Poste :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.In_Po) %>
    </div>

    <div class="display-label">Out Poste :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Out_Po) %>
    </div>

    <div class="display-label">Etat :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Etat) %>
    </div>

    <div class="display-label">ID Ligne :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ID_Ligne) %>
    </div>

    <div class="display-label">Mouvement :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Mouvement) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Supprimer" /> |
        <%: Html.ActionLink("Retour à la liste", "Index")%>
    </p>
<% } %>
</form>
</asp:Content>
