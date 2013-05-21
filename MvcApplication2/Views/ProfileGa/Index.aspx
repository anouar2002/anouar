<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.FlowViewModel>" %>
<%@ Import Namespace="Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gestion de flux de production</h2>



<p>
    <%: Html.ActionLink("Ajouter une nouvelle gamme", "Create") %>
</p>

<table>
    <tr>
        <th>
            ID Gamme
        </th>
        <th>
            Entrée
        </th>
        <th>
           Sortie
        </th>
        <th>
            Gamme Suivante
        </th>
        <th>
            Etat
        </th>
        <th>Opérations</th>
    </tr>

<% foreach (var item in Model.Profile_GaItems) { %>
    <tr>
         <td>
            <%: Html.DisplayFor(modelItem => item.ID_Gamme) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.In_Ga) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Out_Ga) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Next_Gamme) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Etat) %>
        </td>
        <td>
            <%: Html.ActionLink("Modifier", "Edit", new { id=item.ID_Gamme }) %> |
            <%: Html.ActionLink("Détails", "Details", new { id=item.ID_Gamme }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.ID_Gamme }) %>
        </td>
    </tr>
    
     
<% } %>

</table>
<% using (Html.BeginForm("Save", "ProfileGa"))
   { %>
  <div><%:Html.Label("Gamme :")%><%: Html.DropDownListFor(model => model.SelectedProfile_Ga, new SelectList(Model.Profile_GaItems, "ID_Gamme", "ID_Gamme"))%> <input type="button" value="Configurer" id="btnShowGestion" /></div> 
   


        
<div id="divGestion"><%: Html.Partial("Gestion", Model) %></div>
       <% } %>   
        <script type="text/javascript">

            $(document).ready(function () {





                $('#btnShowGestion').click(function () { $('#divGestion').slideToggle("slow") });
              
               

            });

</script>
<fieldset>
<legend>Gestion des Gammes</legend>
<table>
    <tr>
        <th>
            ID Gamme
        </th>
        <th>
            ID Poste
        </th>
        <th>
           Nombre de Passage
        </th>
        <th>
            Position
        </th>
        <th>
            Poste Précédent
        </th>
         <th>
            Poste Suivant
        </th>
        <th>Opérations</th>
    </tr>

<% foreach (var item in Model.GaItems) { %>
    <tr>
         <td>
            <%: Html.DisplayFor(modelItem => item.ID_Gamme) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ID_Poste) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nbr_Passage) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Position) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Last_Posts) %>
        </td>
         <td>
            <%: Html.DisplayFor(modelItem => item.Next_Posts) %>
        </td>
        <td>
        
            <%: Html.ActionLink("Modifier", "Update", new { id=item.ID_Gamme }) %> |
            <%: Html.ActionLink("Détails", "Details", new { id=item.ID_Gamme }) %> |
            <%: Html.ActionLink("Supprimer", "Delete", new { id=item.ID_Gamme }) %>
        </td>
    </tr>
    
     
<% } %>

</table>
 </fieldset>     
</asp:Content>


        