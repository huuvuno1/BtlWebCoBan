<%@ Page Title="" Language="C#" MasterPageFile="~/WebCommon.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BtlWebForm.Views.Common.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CommonBody" runat="server">
    
    <form action="/search">
        <input placeholder="Nhap san pham can tim" name="q"/>
        <button>Tim kiem</button>
    </form>

</asp:Content>
