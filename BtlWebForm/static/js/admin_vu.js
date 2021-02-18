window.onload = getListProduct();

function addFileImage()
{
    var inp = document.createElement("input");
    inp.setAttribute("type", "file");
    document.getElementById("image_sss").appendChild(document.createElement("br"));
    document.getElementById("image_sss").appendChild(inp);
}

function showFormAdd()
{
    document.getElementsByClassName("show-form")[0].style.display = "block";
    // Gọi ajax lấy form - có thể fix html luôn cũng được nhưng đang còn sửa nữa nên gộp chung
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var dom = document.getElementById("response");
            dom.innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/api/form", true);
    xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xhttp.send();
}

function editProduct(x)
{
    document.getElementsByClassName("show-form")[1].style.display = "block";

    var trCurrent =  x.parentNode.parentNode;
    
}

function addProduct() {

}

function getListProduct()
{
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var dom = document.getElementById("list_pro");
            dom.innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/api/product", true);
    xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xhttp.send();
}