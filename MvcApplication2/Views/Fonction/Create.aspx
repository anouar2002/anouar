<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Fonction>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Ajouter une fonction</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Fonction</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_Fonction) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ID_Fonction) %>
            <%: Html.ValidationMessageFor(model => model.ID_Fonction) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nom_Fonction) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nom_Fonction) %>
            <%: Html.ValidationMessageFor(model => model.Nom_Fonction) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_Phase, "Phase") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_Phase", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_Phase) %>
        </div>

        <p>
            <input type="submit" value="Ajouter" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Retour à la liste", "Index") %>
</div>

</asp:Content>
