<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Profile_Ga>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Détails</h2>

<fieldset>
    <legend>Gamme</legend>

    <div class="display-label"> ID Gamme</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ID_Gamme) %>
    </div>

    <div class="display-label">Gamme Entrante</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.In_Ga) %>
    </div>

    <div class="display-label">Gamme Sortante</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Out_Ga) %>
    </div>

    <div class="display-label">Gamme Suivante</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Next_Gamme) %>
    </div>

    <div class="display-label">Etat</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Etat) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Modifier", new { id=Model.ID_Gamme }) %> |
    <%: Html.ActionLink("Retour à la liste", "Index") %>
</p>

</asp:Content>
