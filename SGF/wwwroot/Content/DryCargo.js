
$(document).ready(function () {
    GetStates();

    $("#availableStates").on("change", function () {
        var state = $("#availableStates option:selected").val();
        $.ajax({
            type: 'GET',
            data: { state: state },
            url: '/DryCargos/GetCities',
            dataType: 'json',
            success: function (dados) {
                if (dados !== null) {

                    var selectbox = $('#availableCities');
                    $.each(dados.cities, function (i, d) {
                        $('<option>').val(d.Id).text(d.Value).appendTo(selectbox);
                    })
                    $("#availableCities").prop("disabled", false);


                }
            },
            error: function () {
                console.log("Falha ao buscar cidades!");
            }
        })
    });
});


function GetStates() {
        $.ajax({
            type: 'GET',
            url: '/DryCargos/GetStates',
            dataType: 'json',
            success: function (dados) {
                if (dados !== null) {
                    var selectbox = $('#availableStates');
                    $('<option>').val("0").text("Selecione o Estado").appendTo(selectbox);
                    $.each(dados.states, function (i, d) {
                        $('<option>').val(d.Id).text(d.Value).appendTo(selectbox);
                    })


                }
            },
            error: function () {
                console.log("Falha ao buscar estados!");
            }
        })
}