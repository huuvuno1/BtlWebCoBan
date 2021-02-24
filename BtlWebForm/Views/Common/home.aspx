<%@ Page Title="" Language="C#" MasterPageFile="~/WebCommon.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BtlWebForm.Views.Common.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Trang chủ</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CommonBody" runat="server">
    <div class="container">
        <div class="banner">
            <div class="banner_top flex">
                <div class="width75" style="margin-right: 4px;">
                    <a href="">
                        <img class="img290" src="/static/img/banner/slide_img_1.jpg" alt="">
                    </a>
                </div>
                <div class="with25">
                    <div class="width100" style="margin-bottom: 4px;">
                        <a href="">
                            <img class="img140" src="/static/img/banner/banner_slide_img_1.jpg" alt="">
                        </a>
                    </div>
                    <div class="width100">
                        <a href="">
                            <img class="img140" src="/static/img/banner/banner_slide_img_2.jpg" alt="">
                        </a>
                    </div>
                </div>
            </div>
            <div class="banner_bot flex">
                <div class="width33">
                    <a href="">
                        <img class="img" src="/static/img/banner/banner_bot_slide_img_1.jpg" alt="">
                    </a>
                </div>
                <div class="width33">
                    <a href="">
                        <img class="img" src="/static/img/banner/banner_bot_slide_img_2.jpg" alt="">
                    </a>
                </div>
                <div class="width33">
                    <a href="">
                        <img class="img" src="/static/img/banner/banner_bot_slide_img_3.jpg" alt="">
                    </a>
                </div>

            </div>
        </div>

        <!-- Danh muc may tinh -->
        <div class="nav flex space_">
            <div class="nav_title">
                Máy tính
            </div>
            <div class="nav_list flex">
                <ul class="__ul flex">
                    <li><a href="/">Trang chủ</a></li>
                    <li><a href="/may-tinh">Sản phẩm</a></li>
                    <li><a href="/blog">Blog</a></li>
                    <li><a href="/about">Giới thiệu</a></li>
                    <li><a href="/contact">Liên hệ</a></li>
                </ul>
            </div>
        </div>
        <div class="form_category" id="maytinh" runat="server">
            

            <!-- start list -->
            
            
        </div>
        <div class="clear"></div>
        <div class="banner flex" style="margin-top: 30px;">
            <div class="width49">
                <img class="img" src="/static/img/banner/banner_two_1.jpg" alt="">
            </div>
            <div class="width49">
                <img class="img" src="/static/img/banner/banner_two_22.jpg" alt="">
            </div>
        </div>

        <!-- start phu-kien -->
        <div class="nav flex space_ margintop" style="background-color: #dd2b2b;">
            <div class="nav_title">
                Phụ kiện
            </div>
            <div class="nav_list flex">
                <ul class="__ul flex">
                    <li><a href="/">Trang chủ</a></li>
                    <li><a href="/phu-kien">Sản phẩm</a></li>
                    <li><a href="/blog">Blog</a></li>
                    <li><a href="/about">Giới thiệu</a></li>
                    <li><a href="/contact">Liên hệ</a></li>
                </ul>
            </div>
        </div>
        <div class="form_category" id="phukien" runat="server">
            
            
        </div>

        <div class="clear"></div>

        <div class="banner fullwidth" style="margin-top:30px">
            <img class="img" src="/static/img/banner/banner_full_width.png" alt="">
        </div>
    </div>


</asp:Content>
