<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier un utilisateur</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>User</legend>

        <%: Html.HiddenFor(model => model.Matricule) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nom_User) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nom_User) %>
            <%: Html.ValidationMessageFor(model => model.Nom_User) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.passWord) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.passWord) %>
            <%: Html.ValidationMessageFor(model => model.passWord) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Type_User, "Type Utilisateur :")%>
        </div>

        <div class="editor-field">
            <%: Html.DropDownList("Type_User", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.Type_User) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_UF, "UF :") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_UF", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_UF) %>
        </div>

      <p>
            <input type="submit" value="Enregistrer" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Retour à la liste", "Index") %>
</div>

</asp:Content>
