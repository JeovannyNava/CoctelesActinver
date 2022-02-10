// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#parametroBusqueda").change(function () {
    var searchByName = $("input[type='radio'][name='searchBy']:checked").val() == 0;
    let url = searchByName ? "/cocteles/_GetByName" : "/cocteles/_GetByIngredent"
    let data = searchByName ? { name: $(this).val() } : { ingredent: $(this).val() };
    $.ajax({
        type: "post",
        url: url,
        contenttype: 'application/json; charset=utf-8',
        data: data,
        async: true,
        cache: false,
        success: function (response) {
          
            $("#busqueda").html(response);

        },
        error: function (err) {
            console.log(err);
        }
    });
});


function getDetalle(idDrink)
{


    $.post("/Cocteles/_DetailCoctel", { idDrink: idDrink}).done((response) => {
        $("#divModalDetail").html(response)
        $("#modalDetail").modal("show")
    }).fail((e) => { console.log("Error", e) })

}

function AddStorage(name,idDrink)
{
    localStorage.setItem(idDrink, name);
}

function PaintFavorites()
{
    
    var arrayOfValues = Object.values(localStorage);
    var arrayOfKeys = Object.keys(localStorage);
    var htmlCocteles = '';
    for (var i = 0; i < localStorage.length; i++) {

        let name = arrayOfValues[i];
        let idDrink = arrayOfKeys[i];

        htmlCocteles += `<div class='col-md-6'>${name}</div>
                    <div class='col-md-6'> <button class='btn btn-link' onclick=getDetalle(${idDrink})>Ver detalle</button> </div>`;
      

   }
    $("#favoritos").html(htmlCocteles);
}

