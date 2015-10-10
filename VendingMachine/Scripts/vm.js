/// <reference path="jquery-1.9.1.intellisense.js" />
$(document).ready(function () {
    load_vm_wallet();
    load_user_wallet();
    load_product_catalog();
});

function load_vm_wallet() {
    $.get("Home/GetVMWallet", function (data) {
        $('#vwWallet_container').html(data);
    });
}

function load_user_wallet() {
    $.get("Home/GetUserWallet", function (data) {
        $('#userWallet_container').html(data);
    });
}

function load_product_catalog() {
    $.get("Home/GetProductCatatalog", function (data) {
        $('#products_container').html(data);
    });
}