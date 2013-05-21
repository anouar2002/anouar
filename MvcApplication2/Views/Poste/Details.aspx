<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Poste>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Informations sur ce poste</h2>
<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
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
<% } %>
<div>

    <%: Html.ActionLink("Modifier", "Edit", new { id=Model.ID_Poste }) %> |
    <%: Html.ActionLink("Retour à la liste", "Index") %>
</div>

</asp:Content>
