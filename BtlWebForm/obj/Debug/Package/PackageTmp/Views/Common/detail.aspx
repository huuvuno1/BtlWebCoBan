﻿<%@ Page Title="" Language="C#" MasterPageFile="~/WebCommon.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="BtlWebForm.Views.Common.detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CommonBody" runat="server">
    <section class="vitritrang">
        <div class="container">
            <ul>
                <li class="tenvitri"><a href="/"> Trang chủ</a></li>
                <li class="tenvitri"><a href="">></a></li>
                <li class="tenvitri"><a href="" id="url_page" runat="server"><span id="name_page" runat="server">Máy tính</span></a></li>
                <li class="tenvitri"><a href="">></a></li>
                <li class="tenvitri"><a href="" id="slug_" runat="server"><span id="name_product" runat="server"> Phụ kiện</span></a></li>
            </ul>
        </div>
    </section>
    <div class="page_detail">
        <div class="container flex">
            <div class="left_detail">
                <div class="top_left">
                    <div class="flex-layout">
                        <div class="left-frame">
                            <div id="big-img">
                                <img src="" alt="" id="bigImg" runat="server">
                            </div>
                            <div class="list-img" id="list_anh" runat="server">
                                
                            </div>
                        </div>
                        <div class="right-frame">
                            <h3 id="name-product-current">
                                <a href="" id="name_pro" runat="server"></a>
                            </h3>

                            <div class="product-price">
                                <span class="product-price-new" id="price_new" runat="server">
                                    28.000.000₫
                                </span>
                                <span class="product-price-old" id="price_old" runat="server">
                                    30.000.000₫
                                </span>
                            </div>

                            <div class="thongtin">
                                <span>Tình trạng: </span>
                                <span class="status" id="_status" runat="server">Còn hàng</span>
                            </div>
                            <div class="thongtin">

                                <ul>
                                    <li>
                                        Thương hiệu: Apple
                                    </li>
                                    <li>
                                        Giảm giá 10% cho hoá đơn trên 500k
                                    </li>
                                    <li>
                                        Miễn phí giao hàng trong bán kính 5km
                                    </li>
                                </ul>
                            </div>


                            <div class="muahang">
                                <div class="quantity cha">
                                    <span class="con minus" onclick="minusQuantity(this)">–</span>
                                    <input type="text" value="1" onchange="checkInput(this)" id="_quantity_">
                                    <span class="con add" onclick="addQuantity(this)">+</span>
                                </div>
                                <div class="btn-add-to-cart" id="btn_server" runat="server">
                                </div>
                            </div>

                            <div class="sale-info">
                                <div>
                                    <p class="">
                                       - Giảm giá thêm tới <span>15%</span> giá phụ kiện, 
                                        <span>1%</span> giá máy cho hội viên Smember
                                    </p>
                                </div>
                                <div>
                                    <p class="">
                                       - Giảm giá thêm tới <span>15%</span> giá phụ kiện, 
                                        <span>1%</span> giá máy cho hội viên Smember
                                    </p>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <div class="right_detail">
                <h3>Địa chỉ show room</h3>
                <p>
                    Trụ sở: Tầng 4 - Tòa nhà Hanoi Group - 442 Đội Cấn - Quận Ba Đình - TP Hà Nội
                </p>

                <p>
                    Trụ sở: Tầng 4 - Tòa nhà Hanoi Group - 442 Đội Cấn - Quận Ba Đình - TP Hà Nội
                </p>
                <p>
                    Trụ sở: Tầng 4 - Tòa nhà Hanoi Group - 442 Đội Cấn - Quận Ba Đình - TP Hà Nội
                </p>
                <p>
                    Trụ sở: Tầng 4 - Tòa nhà Hanoi Group - 442 Đội Cấn - Quận Ba Đình - TP Hà Nội
                </p>
            </div>
        </div>
    </div>

    <div class="page_detail">
        <div class="container flex">
            <div class="post_detail" id="post_details" runat="server">

                <!-- content post -->
            </div>

            <div class="info_product">
                <h3>Thông số kỹ thuật</h3>
                <p id="info_detail" runat="server">
                    
                </p>
            </div>        
        </div>
    </div>


    <div class="page_detail">
        <div class="container">
            <div class="comment">
                <h3>Hỏi đáp về Macbook</h3>
                <div class="relative">
                    <textarea placeholder="Viết câu hỏi của bạn" name="" id="comment" cols="30" rows="3"></textarea>

                    <!-- <span class="red" style="display:block; margin: 40px 0;">Đăng nhập để bình luận <a href="/login">Đăng nhập ngay</a></span> -->
                    <button id="btn_send_lv1" runat="server" type="button">Gửi bình luận</button>
                    <!-- <button type="button" onclick="login()">Bạn phải đăng nhập trước</button> -->
                </div>


                <div id="list_comment" runat="server">

                    <!-- comment dau tien -->
                    
                </div>
            </div>
        </div>
    </div>

    <script src="/static/js/comment.js"></script>
</asp:Content>
