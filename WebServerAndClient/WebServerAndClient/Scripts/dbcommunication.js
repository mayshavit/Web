﻿//var clientsUri = "api/Client"

/*var btn = document.getElementById("btnRegister");
btn.onclick = function () {
    $.ajax({
        method: "POST",
        url: "api/Client",
        data: 
    })
}*/

$("#btnRegister").click(function () {
    var dataa = {
        ID: 1,
        UserName: $("#usrName").val(),
        Password: $("#password").val(),
        EMail: $("#email").val()
    };
    //$.ajax({
    //    method: "POST",
    //    url: "../api/Client",
    //    data: dataa
    //}).done(function () {
    //        alert("ghgjhgjh");
    //    });
    $.post("../api/Client", dataa, function () { alert("hola baby"); });
});