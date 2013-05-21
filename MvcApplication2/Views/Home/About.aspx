<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %> </h2>
    <p>
        Sagemcom est un groupe français de haute technologie à dimension internationale. Ayant acquis des positions de premier plan grâce à son fort potentiel d’innovation, Sagemcom a l’ambition de devenir un des leaders mondiaux des terminaux Haut débit, de la Convergence et de l’Energie.
    </p>
    <p>
        Pour plus d'information, vous pouvez consulter <a href="http://www.sagemcom.com">le site officiel. </a>
    </p>
</asp:Content>