function buysconfirm() {
    if ($("#txt_customerName").val() == '' || $("#txt_customerAdress").val() == '') {
        
        $("#alert2msg").text("Completa los datos para realizar la compra (Nombre, Dirección)");
        $("#alert2").show();
    } else {
        $("#alert2msg").text("");
        $("#alert2").hide();
    
        return $("#txt_customerName").val() + '|' + $("#txt_customerAdress").val();

    }
}

function succesful(purchaseId) {
    $("#alert1msg").text("se creó exitósamente la venta #" + purchaseId + '.  conserve este número para consultas');
    $("#alert1").show();
    $("#divButtonConfirm").hide();
    setTimeout(function () {
        location.reload();
    }, 5000);
    return "ok";
}

function getDetailsInformation() {

    var rowCount = $('#tableProductList tr').length;

    var jsonResult = [];
    var JSonValues = {};
    for (var i = 1; i <= rowCount; i++) {
        if (parseInt($("#qt_" + i).val()) > 0) {
            JSonValues = {
                'productId': parseInt($("#productId_" + i).val()),
                'quantity': parseInt($("#qt_" + i).val()),
                'unitPrice': parseFloat($("#price_" + i).val().replace(",", ".")),
                'totalPrice': (parseFloat($("#qt_" + i).val()) * parseFloat($("#price_" + i).val().replace(",", ".")))
            }
            jsonResult.push(JSonValues);
        }        
    }
    
    var jsonString = JSON.stringify(jsonResult);
        
    return jsonString;
    
}
function onChangeQuantity(buttonId) {
    var elementId = buttonId.replace('button_', '');
    price = (parseFloat($("#qt_" + elementId).val()) * parseFloat($("#price_" + elementId).val().replace(",", ".")));
    $("#subTotal_" + elementId).val(price);
}
function addToCar() {

    var rowCount = $('#tableProductList tr').length;

    var Total = 0.0;
    var Items = 0;
    for (var i = 1; i <= rowCount; i++) {
        Total = Total + (parseFloat($("#subTotal_" + i).val()));
        Items = Items + (parseFloat($("#qt_" + i).val()));
    }
    $("#TotalCompra").text(Total);
    $("#TotalItems").text(Items);
    if (Total > 0) {
        $("#divButtonConfirm").show();

    } else {
        $("#divButtonConfirm").hide();
    }

    
}

