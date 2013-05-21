<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Informations sur cet utilisateur</h2>
<form id="form1" runat="server">
<fieldset>
    <legend>Utilisateur</legend>

    <div class="display-label">Nom Utilisateur :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom_User) %>
    </div>

    <div class="display-label">Mot de passe :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.passWord) %>
    </div>

    <div class="display-label">Type Utilisateur :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Type_User) %>
    </div>

    <div class="display-label">ID UF :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ID_UF) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Modifier", "Edit", new { id=Model.Matricule }) %> |
    <%: Html.ActionLink("Retour à la liste", "Index") %>
</p>
</form>
</asp:Content>
