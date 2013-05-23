<%@  Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MvcApplication2.Models.FlowViewModel>" %>
 
<% using (Html.BeginForm("Save", "ProfileGa")) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset class="parametrage">
        <legend>Gestion de Gamme</legend>
     
        <div>
        <%:Html.Label("Poste :")%><%: Html.DropDownListFor(model => model.SelectedPoste, Model.PostesItems, new { @id = "poste" })%>
        <input type="checkbox" name="option1" value="Poste Initial" id= "chkMain" onclick="test();"/>Poste Initial
        <input type="checkbox" name="option2" value="Poste Final" id= "chkFirst" onclick="test2();"/>Poste Final
        </div>
        
         
         <div>
         <%:Html.Label("Nombre de Passage :")%><%: Html.EditorFor(model=>model.Nbr_Passage)%>
         </div>
         <div class="editor-field">
          <%: Html.ValidationMessageFor(model => model.Nbr_Passage)%>
          </div>
        
        <div>
        <%:Html.Label("Position :")%><%: Html.EditorFor(model=>model.Position)%>
        </div>
      
       <%-- <div>
       <%:Html.Label("Poste Précédent :")%><%: Html.DropDownListFor(model => model.PostePrecedentSelected, Model.PostesItems)%>
       </div>--%>
        
        <div>
        <%:Html.Label("Poste Suivant :")%><%: Html.DropDownListFor(model => model.PosteSuivantSelected, Model.PostesItems, new { @id = "dd" })%>
        <input type="button" value="Ajouter" id="add"  onclick="addtext()"/>
        <%--<asp:Panel id="Panel1" runat="server"
            BackColor="gainsboro"
            Height="150px"
            Width="200px">
 
            <p>Panel1: Here is some static content...</p>
            
 
       </asp:Panel>--%>
       <textarea ID="ta" cols="10"  name="S1" rows="8" readonly="true"></textarea>
        </div>
      
       
        <div>
        <input type="submit" value="Enregistrer" id="btnSave"  />
        </div>
      
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
             var dd = document.getElementById('dd');
             var ta = document.getElementById('ta');
             var add = document.getElementById('add');
            
             if (chkFirst.checked) {
                 chkMain.disabled = 'disabled';
                 dd.disabled = 'disabled';
                 ta.value = "Poste0";
                 add.disabled = 'disabled';
                

             }
             else {
                 chkMain.disabled = false;
                 dd.disabled = false;
                 ta.value = "";
                 add.disabled = false;
             }
         }
   
    </script>
    <script language="javascript" type="text/javascript">
        var storedValues = [];
        function addtext() {

            var dd = document.getElementById('dd');
            var ta = document.getElementById('ta');
            var add = document.getElementById('add');
           
                var selectedValue = dd.options[dd.selectedIndex].value + " ";
                if (storedValues.indexOf(selectedValue) === -1) {
                    storedValues.push(selectedValue)
                    ta.value = storedValues.join('')
                }
           
            
        }
</script>

<%--<script type="text/javascript">

         function remove() {
             var rm = document.getElementById('btnSave');
             var poste = document.getElementById('poste');

             poste.doc
</script>--%>
        <% } %>
    
 