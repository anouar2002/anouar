<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.FlowViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gérer les droits</h2>
 <form id="form1" runat="server">
<fieldset><legend>Gestion</legend>

        <div>
        <%:Html.Label("Poste :")%><%: Html.DropDownListFor(model => model.SelectedPoste, Model.PostesItems)%>
        </div>

        <div>
        <%:Html.Label("Fonction :")%><%: Html.DropDownListFor(model => model.SelectedFonction, Model.FoncItems)%>
        </div>
        <div>
        <textarea ID="ta" cols="10"  name="S1" rows="8" readonly="true"></textarea>
        </div>
</fieldset>
</form>
</asp:Content>
