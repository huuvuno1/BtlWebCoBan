<%@ Page Title="" Language="C#" MasterPageFile="~/WebCommon.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="BtlWebForm.Views.Common.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CommonBody" runat="server">
    <section class="vitritrang">
        <div class="container">
            <ul>
                <li class="tenvitri"><a href=""> Trang chủ</a></li>
                <li class="tenvitri"><a href="">></a></li>
                <li class="tenvitri"><a href=""><span> Tìm kiếm</span></a></li>
            </ul>
        </div>
    </section>
    <section class="content">
        <div class="container">
            <div class="message margin-bottom-20">
                <h1 id="CountResult" runat="server"></h1>
            </div>
            <div class="products" id="ListProduct" runat="server">
                
                


            </div>
        </div>
    </section>
    <div class="clear"></div>
    <div class="show-form">
        <div class="form-quick-view frame" id="result-ajax">
            
            

        </div>
        <div class="fade" onclick="btnClose(1)">
        </div>
        <div class="form-cart frame">
            <a href="javascript:;" class="btn-close" onclick="btnClose(2)">〤</a>
            <div class="product-name-just-added">
                <span>Bạn đã thêm <a href="#">Acer Nitro 5 AN515 51 739L i7 7700HQ/8GB/1TB/2GB</a> vào giỏ hàng </span>
            </div>
            <div class="content-cart">
                <div class="title-cart">
                    Giỏ hàng của bạn
                </div>
                <div class="row-title">
                    <div class="title-view view-product-info">
                        Sản phẩm
                    </div>
                    <div class="title-view view-product-price">
                        Giá
                    </div>
                    <div class="title-view view-product-quantity">
                        Số lượng
                    </div>
                    <div class="title-view view-product-total-money">
                        Tổng tiền
                    </div>
                </div>
                <div class="view-product-selected">
                    <div class="view-row-product">
                        <div class="view-product-info">
                            <div class="view-img">
                                <img src="img/product/apple-macbook-12-mnyk2sa-a-450x300-450x300.jpg" alt="">
                            </div>
                            <div class="view-info">
                                <div class="view-info-name text-2-line">
                                    Apple Macbook 12" MNYK2SA/A Core M 1.2GHz/8GB/256GB (2017)
                                </div>
                                <span class="click-remove" onclick="removeProduct(this)">
                                    〤 Xóa
                                </span>
                            </div>
                        </div>
                        <div class="view-product-price">
                            <span class="red line37">7,000,000 ₫</span>
                        </div>
                        <div class="view-product-quantity">
                            <div class="cha">
                                <span class="con minus" onclick="minusQuantity(this); sumOfMoney(this.parentNode.children[1]);">–</span>
                                <input type="text" value="1" onchange="sumOfMoney(this)">
                                <span class="con add" onclick="addQuantity(this); sumOfMoney(this.parentNode.children[1]);">+</span>
                            </div>
                            
                        </div>
                        <div class="view-product-total-money">
                            <span class="red line37">7,000,000 ₫</span>
                        </div>
                    </div>

                    <div class="view-row-product">
                        <div class="view-product-info">
                            <div class="view-img">
                                <img src="img/product/apple-macbook-12-mnyk2sa-a-450x300-450x300.jpg" alt="">
                            </div>
                            <div class="view-info">
                                <div class="view-info-name text-2-line">
                                    Apple Macbook 12" MNYK2SA/A Core M 1.2GHz/8GB/256GB (2017)
                                </div>
                                <span class="click-remove" onclick="removeProduct(this)">
                                    〤 Xóa
                                </span>
                            </div>
                        </div>
                        <div class="view-product-price">
                            <span class="red line37">9,000,000 ₫</span>
                        </div>
                        <div class="view-product-quantity">
                            <div class="cha">
                                <span class="con minus" onclick="minusQuantity(this); sumOfMoney(this.parentNode.children[1]);">–</span>
                                <input type="text" value="1" onchange="sumOfMoney(this)" id="aaa">
                                <span class="con add" onclick="addQuantity(this); sumOfMoney(this.parentNode.children[1]);">+</span>
                            </div>
                        </div>
                        <div class="view-product-total-money">
                            <span class="red line37">9,000,000</span>
                        </div>
                    </div>

                    <div class="view-row-product">
                        <div class="view-product-info">
                            <div class="view-img">
                                <img src="img/product/apple-macbook-12-mnyk2sa-a-450x300-450x300.jpg" alt="">
                            </div>
                            <div class="view-info">
                                <div class="view-info-name text-2-line">
                                    Apple Macbook 12" MNYK2SA/A Core M 1.2GHz/8GB/256GB (2017)
                                </div>
                                <span class="click-remove" onclick="removeProduct(this)">
                                    〤 Xóa
                                </span>
                            </div>
                        </div>
                        <div class="view-product-price">
                            <span class="red line37">8.000.000 ₫</span>
                        </div>
                        <div class="view-product-quantity">
                            <div class="cha">
                                <span class="con minus" onclick="minusQuantity(this); sumOfMoney(this.parentNode.children[1]);">–</span>
                                <input type="text" value="1" onchange="sumOfMoney(this)">
                                <span class="con add" onclick="addQuantity(this); sumOfMoney(this.parentNode.children[1]);">+</span>
                            </div>
                            
                        </div>
                        <div class="view-product-total-money">
                            <span class="red line37">8.000.000</span>
                        </div>
                    </div>
                  

                </div>
            </div>
            <div class="check-out">
                <span>Tổng số thành tiền: </span>
                <span class="red" id="tong-tien">
                    19.240.000
                </span>
                <br style="margin: 15px;">
                <button id="btn-add-to-cart">Tiến hành thanh toán</button>
            </div>
        </div>

    </div>
    
    <div class="pagination">
        <a href=""><span class="arrow-left"></span></a>
        <a href=""><span>1</span></a>
        <a href=""><span>2</span></a>
        <a href=""><span>3</span></a>
        <a href=""><span class="arrow-right"></span></a>
    </div>

</asp:Content>
