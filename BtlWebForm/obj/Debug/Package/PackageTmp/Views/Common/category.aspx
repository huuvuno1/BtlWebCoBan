﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WebCommon.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="BtlWebForm.Views.Common.category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CommonBody" runat="server">
    <section class="vitritrang">
        <div class="container">
            <ul>
                <li class="tenvitri"><a href="/"> Trang chủ</a></li>
                <li class="tenvitri"><a href="">></a></li>
                <li class="tenvitri"><a href="/may-tinh" id="url_server" runat="server"><span id="name_page" runat="server"></span></a></li>
            </ul>
        </div>
    </section>

    <section class="content">
        <div class="container">
            <div class="flex">
                <div class="left-container">
                    <div class="title-container">
                        <div class="left-title-container">
                            <h3>Laptop</h3>
                            <span>(10 sản phẩm)</span>
                            <div class="clear"></div>
                        </div>

                        <div class="right-title-container">
                            <span>Sắp xếp</span>
                            <ul id="selectSort" onclick="showSort()">
                                <li>
                                    <span id="dangchon">Mới nhất</span>
                                    <span class="ky-tu-tro-xuong">
                                        <img src="img/icon/down.gif" alt="">
                                    </span>

                                </li>
                                <li class="sort-type">
                                    <ul>
                                        <li>Top bán chạy</li>
                                        <li>Giá tăng dần</li>
                                        <li>Giá giảm dần</li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <div class="products clear" id="data_server" runat="server">

                    </div>
                </div>
                <div class="right-container">
                    <div class="right-title">
                        <h3>Tìm theo</h3>
                    </div>

                    <div class="search-by-conditions">

                        <div class="price-range">
                            <fieldset>
                                <legend>
                                    <h3>Khoảng giá</h3>
                                </legend>
                                <input type="checkbox" name="favorite_pet" value="all">Tất cả<br><br>
                                <input type="checkbox" name="favorite_pet" value="0-10">Dưới 10 triệu<br><br>
                                <input type="checkbox" name="favorite_pet" value="10-15">Từ 10 - 15 triệu<br><br>
                                <input type="checkbox" name="favorite_pet" value="15-20">Từ 15 - 20 triệu<br> <br>
                                <input type="checkbox" name="favorite_pet" value="20-25">Từ 20 - 25 triệu<br> <br>
                                <input type="checkbox" name="favorite_pet" value=">20">Trên 25 triệu<br> <br>
                            </fieldset>
                        </div>
                        <div class="trademark">
                            <fieldset>
                                <legend>
                                    <h3>Thương hiệu</h3>
                                </legend>
                                <input type="checkbox" name="favorite_pet" value="all">Tất cả<br><br>
                                <input type="checkbox" name="favorite_pet" value="0-10">Macbook<br><br>
                                <input type="checkbox" name="favorite_pet" value="10-15">Dell<br><br>
                                <input type="checkbox" name="favorite_pet" value="15-20">Acer<br> <br>
                                <input type="checkbox" name="favorite_pet" value="20-25">Asus<br> <br>
                                <input type="checkbox" name="favorite_pet" value=">20">Hp<br> <br>
                            </fieldset>
                        </div>
                    </div>
                </div>

            </div>
    </section>
</asp:Content>
