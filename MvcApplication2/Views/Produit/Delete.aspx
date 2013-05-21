<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Produit>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Produit</legend>

    <div class="display-label">Nom_Produit</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom_Produit) %>
    </div>

    <div class="display-label">Sous_Famille</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sous_Famille.Nom_SFamille) %>
    </div>

    <div class="display-label">Profile_Ga</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Profile_Ga.In_Ga) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
