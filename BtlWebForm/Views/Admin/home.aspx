<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/WebAdmin.Master" CodeBehind="home.aspx.cs" Inherits="BtlWebForm.Views.Admin.home" %>
<asp:Content ContentPlaceHolderID="AdminBody" runat="server">
        


    <div class="main-container">
        <div class="left-admin-container">
            <ul class="menu-admin">
                <li style="font-weight: bold;">Quản lý sản phẩm</li>
                <li>Quản lý người dùng</li>
            </ul>
        </div>

        <div class="right-admin-container">
            <button type="button" id="btnAdd" onclick="showFormAdd()">Thêm sản phẩm</button>


            <h3>Danh sách sản phẩm</h3>

            <table id="table-product">
                <thead>
                    <tr>
                        <td class="name-pro">Tên sản phẩm</td>
                        <td class="price-pro ">Giá</td>
                        <td class="quantity-pro ">Số lượng</td>
                        <td class="image-pro ">Hình ảnh</td>
                        <td class="sale-pro">Mức giảm giá</td>
                        <td class="link-pro ">Link</td>
                        <td class="edit-pro ">Chỉnh sửa</td>
                    </tr>
                </thead>
                <tbody id="list_pro">
                </tbody>
            </table>
        </div>
    <div class="show-form" id="response">

    </div>
</asp:Content>