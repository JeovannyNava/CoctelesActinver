// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#parametroBusqueda").change(function () {

    $.ajax({
        type: "post",
        url: "/cocteles/getbyname",
        contenttype: 'application/json; charset=utf-8',
        data: {
            Nombre: $(this).val()
        },
        async: false,
        cache: false,
        success: function (msg) {
            console.log(msg);
            $("#busqueda").html(msg);

        },
        error: function (err) {
            console.log(err);
        }
    });
});


