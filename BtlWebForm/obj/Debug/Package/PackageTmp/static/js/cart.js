﻿window.onload = function msg() {
    var url = window.location.href;
    if (url.includes("?msg=success"))
        alert("Đơn hàng của bạn đang được xử lý, bạn có thể theo dõi thông tin đơn hàng bằng tài khoản này");
    if (url.includes("?msg=register-success"))
        alert("Đăng ký tài khoản thành công, xin mời bạn đăng nhập");
    if (url.includes("?msg=false-field-null"))
        alert("Chưa thể thêm sản phẩm vì bạn nhập thiếu thông tin cần thiết");
    if (url.includes("/admin"))
        loadForm(1);
}

