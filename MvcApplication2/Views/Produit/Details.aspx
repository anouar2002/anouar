<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Produit>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

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
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.Code_Produit }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
