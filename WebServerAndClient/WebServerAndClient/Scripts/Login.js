﻿$(document).ready(function () {
    $("#loginForm").submit(function () {
        var username = $("#usernameId").val();
        var password = $("#passwordId").val();
        if (username == "" || password == "") {
            alert("you have to fill username and password");
        }
        else {
            sessionStorage.setItem("playerName", username);
            window.location.href = "HomePage.html";
        }
    });
});