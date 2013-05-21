<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Sous_Famille>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>Sous_Famille</legend>

    <div class="display-label">Nom_SFamille</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom_SFamille) %>
    </div>

    <div class="display-label">Profile_Ga</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Profile_Ga.In_Ga) %>
    </div>

    <div class="display-label">Famille</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Famille.Nom_Famille) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID_SFamaille }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
