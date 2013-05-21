<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Supprimer un utilisateur</h2>

<h3>Etes-vous sûr de vouloir supprimer cet utilisateur ?</h3>
<form id="form1" runat="server">
<fieldset>
    <legend>User</legend>

    <div class="display-label">Nom Utilisateur :</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom_User) %>
    </div>

    <div class="display-label">Mot de passe : </div>
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
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Supprimer" /> |
        <%: Html.ActionLink("Retour à la liste", "Index") %>
    </p>
<% } %>
</form>
</asp:Content>
