<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BtlWebForm.Views.Common.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="action" runat="server">
        <input placeholder="Nhap username" name="username" /><br />
        <input placeholder="Nhap password" name="password" /><br />
        <input name="action" value="login" hidden="hidden"/><br />
        <input type="submit" /><br />
    </form>
</body>
</html>
