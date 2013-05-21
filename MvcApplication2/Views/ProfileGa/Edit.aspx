<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.Profile_Ga>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier une gamme</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Gamme</legend>

        <%: Html.HiddenFor(model => model.ID_Gamme) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.In_Ga) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.In_Ga) %>
            <%: Html.ValidationMessageFor(model => model.In_Ga) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Out_Ga) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Out_Ga) %>
            <%: Html.ValidationMessageFor(model => model.Out_Ga) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Next_Gamme) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Next_Gamme) %>
            <%: Html.ValidationMessageFor(model => model.Next_Gamme) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Etat) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Etat) %>
            <%: Html.ValidationMessageFor(model => model.Etat) %>
        </div>

        <p>
            <input type="submit" value="Enregistrer" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Reour à la liste", "Index") %>
</div>

</asp:Content>
