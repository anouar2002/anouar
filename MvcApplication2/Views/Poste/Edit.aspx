<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Poste>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier un poste</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Poste</legend>

        <%: Html.HiddenFor(model => model.ID_Poste) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.nom_Poste) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.nom_Poste) %>
            <%: Html.ValidationMessageFor(model => model.nom_Poste) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Application) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Application) %>
            <%: Html.ValidationMessageFor(model => model.Application) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.In_Po) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.In_Po) %>
            <%: Html.ValidationMessageFor(model => model.In_Po) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Out_Po) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Out_Po) %>
            <%: Html.ValidationMessageFor(model => model.Out_Po) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Etat) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Etat) %>
            <%: Html.ValidationMessageFor(model => model.Etat) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ID_Ligne, "Ligne") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("ID_Ligne", String.Empty) %>
            <%: Html.ValidationMessageFor(model => model.ID_Ligne) %>
        </div>

       <div class="editor-label">
            <%: Html.LabelFor(model => model.Mouvement) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Mouvement) %>
            <%: Html.ValidationMessageFor(model => model.Mouvement) %>
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
