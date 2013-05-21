<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Sous_Famille>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Sous_Famille</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nom_SFamille) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nom_SFamille) %>
            <%: Html.ValidationMessageFor(model => model.Nom_SFamille) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_Gamme, "Profile_Ga") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_Gamme", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_Gamme) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_Famille, "Famille") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_Famille", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_Famille) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
