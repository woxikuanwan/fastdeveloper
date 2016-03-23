<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.User>" %>
@model MvcApplication2.Models.User
<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>User</title>
</head>
<body>
    <div>
       <%-- @ViewData["name1"] 
        @ViewBag.name --%>
       <%-- @Html.TextBox("Username") --%>
        @model.Username 
        <%--@ViewBag.aaa--%>
        <%--  <%: Html.LabelFor(m => m.Username) %>--%>
        <%--<%: Html.TextBoxFor(x => x.Username) %>--%>
    </div>
</body>
</html>
