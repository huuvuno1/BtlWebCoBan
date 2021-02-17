<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDetailProduct.aspx.cs" Inherits="BtlWebForm.Views.Ajax.ShowDetailProduct" %>
<a href="javascript:;" class="btn-close" onclick="btnClose(1)">x</a>
        <div class="flex-layout">
            <div class="left-frame">
                <div id="big-img">
                    <asp:Image ID="bigImg" ImageUrl="/static/img/vr3.jpg" runat="server"></asp:Image>
                </div>
                <div class="list-img">
                    <div class="chuyen" onclick="backImg()" style="display: none;">
                        <img src="/static/img/icon/click-left.png" alt="">
                    </div>

                    <div id="PIC" runat="server">

                    </div>

                    <div class="chuyen" onclick="nextImg()">
                        <img src="/static/img/icon/click-right.png" alt="">
                    </div>
                </div>
            </div>
            <div class="right-frame">
                <h3 id="name-product-current">
                    <a href="" id="NAME" runat="server"></a>
                </h3>
                <div class="thongtin">
                    <span>Thương hiệu: </span>
                    <span id="TRADEMARK" runat="server"></span>
                    <span> | </span>
                    <span>Tình trạng: </span>
                    <span class="status" id="QUANTITY_X" runat="server"></span>
                </div>
                <hr class="line">
                <div class="product-price" style="text-align: center;">

                    <span class="product-price-new" id="GIA_MOI" runat="server">
                        
                    </span>

                    <span class="product-price-old" id="GIA_CU" runat="server">
                        
                    </span>
                </div>
                <hr class="line">
                <div class="description">
                    <div class="text-2-line">
                        Màn Hình : 13.3 inchs QHD IPS
                        CPU : Intel Core i7-8550U
                        RAM : 8 GB DDR4 2133 MHz
                        VGA : Intel HD Graphics 620
                        HĐH : Windows 10
                        Nặng : 1.3 Kg...
                    </div>
                    <a href="#">Xem chi tiết</a>
                </div>

                <div class="muahang">
                    <div class="quantity cha">
                            <span class="con minus" onclick="minusQuantity(this)">–</span>
                            <input type="text" value="1" onchange="checkInput(this)">
                            <span class="con add" onclick="addQuantity(this)">+</span>
                    </div>
                    <div class="btn-add-to-cart">
                        <button id="btn-add-to-cart" onclick="addToCart()">Cho vào Thêm vào giỏ hàng</button>
                    </div>
                </div>
            </div>

        </div>