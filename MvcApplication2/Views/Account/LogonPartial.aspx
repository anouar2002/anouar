<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage"%>
    <p>
       
        S'il vous plaît entrer votre Login et Mot de Passe pour vous connecter :
    </p>
    <% using (Html.BeginForm("LogedInUser", "Account")) { %>
        <table>
            <tr><td><label for="username" style="width:10em">Matricule :</label></td><td><%= Html.TextBox("Matricule") %><%= Html.ValidationMessage("Matricule") %></td></tr>
            <tr><td><label for="password" style="width:10em">Mot de passe:</label></td><td><%= Html.Password("passWord") %><%= Html.ValidationMessage("passWord") %></td></tr>
            <tr><td></td><td><%= Html.CheckBox("rememberMe") %> <label for="rememberMe">Se souvenir de moi ?</label></td></tr>
            <tr><td></td><td><input type="submit" value="Se Connecter" /></td></tr>
        </table>
<% } %>
