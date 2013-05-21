<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Produit>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Produit</legend>

        <%: Html.HiddenFor(model => model.Code_Produit) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nom_Produit) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nom_Produit) %>
            <%: Html.ValidationMessageFor(model => model.Nom_Produit) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_SFamille, "Sous_Famille") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_SFamille", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_SFamille) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_Gamme, "Profile_Ga") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_Gamme", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_Gamme) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
