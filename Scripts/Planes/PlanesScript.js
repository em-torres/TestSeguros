$('#detallePlanes').click(function(e) {
    var order_id = this.getAttribute("PlanesID");
    var modalOD = $(".detallePlanesModal");
    var modalOrdenCompra = $(".modal-body");

    $.ajax({
        type: "GET",
        url: "/Planes/DetallesPlanesPV",
        data: { id: order_id },
        error: function() {
            alert("No funciono :'(");
        },
        success: function (result) {
            modalOD.modal();
            modalOrdenCompra.html(result);
        }
    });
});
