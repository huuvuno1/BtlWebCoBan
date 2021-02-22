<%@ Page Title="" Language="C#" MasterPageFile="~/WebCommon.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="BtlWebForm.Views.Common.detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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

                <div class="bottom_detail">
                    <div class="nav_detail flex">
                        <div style="border-bottom: 2px solid orange;">THÔNG TIN SẢN PHẨM</div>
                        <div>ĐÁNH GIÁ</div>
                        <div>BÌNH LUẬN</div>
                    </div>
                    <div class="description" id="descript" runat="server">
                        Màn Hình : 13.3 inchs QHD IPS
                        CPU : Intel Core i7-8550U
                        RAM : 8 GB DDR4 2133 MHz
                        VGA : Intel HD Graphics 620
                        HĐH : Windows 10
                        Nặng : 1.3 Kg...
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
</asp:Content>
