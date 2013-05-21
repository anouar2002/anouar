<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Register assembly="DevExpress.Web.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxNavBar" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSiteMapControl" tagprefix="dx" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %> </h2>
    <p>
        Sagemcom est un groupe français de haute technologie à dimension internationale. Ayant acquis des positions de premier plan grâce à son fort potentiel d&#8217;innovation, Sagemcom a l&#8217;ambition de devenir un des leaders mondiaux des terminaux Haut débit, de la Convergence et de l&#8217;Energie.
    </p>
    <p>
        Pour plus d'information, vous pouvez consulter <a href="http://www.sagemcom.com">le site officiel. </a>
    </p>
    
    
    
    <form id="form1" runat="server">
        <fieldset>
            <legend>Listes des fonctionnalités </legend>

            
        </fieldset>
    </form>
    
</asp:Content>
