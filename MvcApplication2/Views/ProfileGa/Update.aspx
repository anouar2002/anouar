<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.FlowViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Update
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Modifier une gamme</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Gamme</legend>
        <div><%:Html.Label("Gamme :")%><%: Html.DropDownListFor(model => model.SelectedProfile_Ga, new SelectList(Model.Profile_GaItems, "ID_Gamme", "ID_Gamme"))%></div>
         
         <div><%:Html.Label("Poste :")%><%: Html.DropDownListFor(model => model.SelectedPoste, Model.PostesItems)%><input type="checkbox" name="option1" value="Poste Initial" id= "chkMain" onclick="test();"/>Poste Initial<input type="checkbox" name="option2" value="Poste Final" id= "chkFirst" onclick="test2();"/>Poste Final</div>
        
         
         <div><%:Html.Label("Nombre de Passage :")%><%: Html.EditorFor(model=>model.Nbr_Passage)%></div><div class="editor-field"> <%: Html.ValidationMessageFor(model => model.Nbr_Passage)%></div>
        <div><%:Html.Label("Position :")%><%: Html.EditorFor(model=>model.Position)%></div>
        <div><%:Html.Label("Poste Précédent :")%><%: Html.DropDownListFor(model => model.PostePrecedentSelected, Model.PostesItems)%></div>
        <div><%:Html.Label("Poste Suivant :")%><%: Html.DropDownListFor(model => model.PosteSuivantSelected, Model.PostesItems)%></div>
        <p>
            <input type="submit" value="Enregistrer" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Reour à la liste", "Index") %>
</div>

 <script type="text/javascript">

     function test() {
         var chkMain = document.getElementById('chkMain');
         var chkFirst = document.getElementById('chkFirst');

         if (chkMain.checked) {
             chkFirst.disabled = 'disabled';

         }
         else {
             chkFirst.disabled = false;

         }
     }
   
    </script>

     <script type="text/javascript">

         function test2() {
             var chkMain = document.getElementById('chkMain');
             var chkFirst = document.getElementById('chkFirst');

             if (chkFirst.checked) {
                 chkMain.disabled = 'disabled';

             }
             else {
                 chkMain.disabled = false;

             }
         }
   
    </script>


</asp:Content>
