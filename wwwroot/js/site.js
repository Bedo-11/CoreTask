﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const Id = document.querySelector('#Id');
const mobile = document.querySelector('#mobile');
const submit = document.querySelector('.submit');

submit.addEventListener('click', () => {

    if (Id.value == "") {
        Id.setCustomValidity('ادخل رقم الهوية');
        Id.oninput = function (e) {
            e.target.setCustomValidity("");
        };
    } else if (Id.value.length !== 10) {
        Id.setCustomValidity('ادخل رقم الهوية كاملا');
        Id.oninput = function (e) {
            e.target.setCustomValidity("");
        };
    }

    if (mobile.value == "") {
        mobile.setCustomValidity('ادخل رقم الجوال');
        mobile.oninput = function (e) {
            e.target.setCustomValidity("");
        };
    } else if (mobile.value.length !== 10) {
        mobile.setCustomValidity('ادخل رقم الجوال كاملا');
        mobile.oninput = function (e) {
            e.target.setCustomValidity("");
        };
    }

})