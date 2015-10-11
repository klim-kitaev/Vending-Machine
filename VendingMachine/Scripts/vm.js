/// <reference path="jquery-1.9.1.intellisense.js" />
$(document).ready(function () {
    load_vm_wallet();
    load_user_wallet();
    load_product_catalog();
    
    $('#btnChange').click(function () {
        get_change();
    })
});

function enter_money(stype) {
    $('#allert-container').html('');
    $.get("Home/EnterMoney", {"s_type":stype}, function (data) {
        if (data == true) {
            get_money_cache();
            load_user_wallet();
            load_vm_wallet();
        }
    }, 'json');
}

function buy_product(ptype) {
    $('#allert-container').html('');
    $.get("Home/Buy", { "p_type": ptype }, function (data) {
        $('#allert-container').html(data);
        load_vm_wallet();
        load_product_catalog();
        get_money_cache();
    });
}

function get_change() {
    $('#allert-container').html('');
    $.get("Home/GetChange", function (data) {
        get_money_cache();
        load_user_wallet();
        load_vm_wallet();
    }, 'json');
}

function get_money_cache() {
    $.get("Home/GetMoneyCache", function (data) {
        $('#entered_summ').text(data)
    }, 'json');
}

function load_vm_wallet() {
    $.get("Home/GetVMWallet", function (data) {
        $('#vwWallet_container').html(data);
    });
}

function load_user_wallet() {
    $.get("Home/GetUserWallet", function (data) {
        $('#userWallet_container').html(data);
        $('.enter-button').click(function () {
            var stype = $(this).attr("data-face");
            enter_money(stype);
        });
    });
}

function load_product_catalog() {
    $.get("Home/GetProductCatatalog", function (data) {
        $('#products_container').html(data);
        $('.buy-button').click(function () {
            var ptype = $(this).attr("data-face");
            buy_product(ptype);
        });
    });
}