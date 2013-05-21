<%@  Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MvcApplication2.Models.FlowViewModel>" %>
 
<% using (Html.BeginForm("Save", "Anouar")) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset class="parametrage">
        <legend>Gestion de Gamme</legend>
     
        <div><%:Html.Label("Poste :")%><%: Html.DropDownListFor(model => model.SelectedPoste, Model.PostesItems)%><input type="checkbox" name="option1" value="Poste Initial" id= "chkMain" onclick="test();"/>Poste Initial<input type="checkbox" name="option2" value="Poste Final" id= "chkFirst" onclick="test2();"/>Poste Final</div>
        
         
         <div><%:Html.Label("Nombre de Passage :")%><%: Html.EditorFor(model=>model.Nbr_Passage)%></div><div class="editor-field"> <%: Html.ValidationMessageFor(model => model.Nbr_Passage)%></div>
        <div><%:Html.Label("Position :")%><%: Html.EditorFor(model=>model.Position)%></div>
        <div><%:Html.Label("Poste Précédent :")%><%: Html.DropDownListFor(model => model.PostePrecedentSelected, Model.PostesItems)%></div>
        <div><%:Html.Label("Poste Suivant :")%><%: Html.DropDownListFor(model => model.PosteSuivantSelected, Model.PostesItems)%></div>
      
       
        <div><input type="submit" value="Enregistrer" id="btnSave"  /></div>
      
        </fieldset>
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


        <% } %>
    
 