var horaInicio;
var peticionesPendientes = 3;

function mostrarTiempo() {
    var horaFin = new Date();
    var tiempo = horaFin - horaInicio;
    var spn = document.getElementById("spnTiempo");
    if (spn) {
        spn.innerHTML = tiempo + " msg";
    }
}

$(document).ready(
    function () {
        horaInicio = new Date();
        var url1 = "Sistema/ListarProductos";
        $.get(url1, function (data) {
            if (data) {
                var html = "<table>";
                html += "<thead>";
                html += "<tr class='FilaCabecera'>";
                html += "<td>Codigo</td>";
                html += "<td>Nombre del Producto</td>";
                html += "<td>Precio</td>";
                html += "<td>Stock</td>";
                html += "</tr>";
                html += "</thead>";
                html += "<tbody>";
                $.each(data, function (index, item) {
                    html += "<tr class='FilaDatos'>";
                    html += "<td>" + item.Codigo + "</td>";
                    html += "<td>" + item.Nombre + "</td>";
                    html += "<td>" + item.Precio + "</td>";
                    html += "<td>" + item.Stock + "</td>";
                    html += "</tr>";
                });
                html += "</tbody>";
                html += "</table>";
                $("#divProducto").html(html);
            }
            peticionesPendientes--;
            if (peticionesPendientes === 0) mostrarTiempo();
        });

        var url2 = "Sistema/ListarClientes"; 
        $.get(url2, function (data) {
            if (data) {
                var html = "<table>";
                html += "<thead>";
                html += "<tr class='FilaCabecera'>";
                html += "<td>Codigo</td>";
                html += "<td>Nombre del Cliente</td>";
                html += "<td>Direccion</td>";
                html += "<td>Contacto</td>";
                html += "</tr>";
                html += "</thead>";
                html += "<tbody>";
                $.each(data, function (index, item) {
                    html += "<tr class='FilaDatos'>";
                    html += "<td>" + item.Codigo + "</td>";
                    html += "<td>" + item.Nombre + "</td>";
                    html += "<td>" + item.Direccion + "</td>";
                    html += "<td>" + item.Contacto + "</td>";
                    html += "</tr>";
                });
                html += "</tbody>";
                html += "</table>";
                $("#divCliente").html(html);
            }
            peticionesPendientes--;
            if (peticionesPendientes === 0) mostrarTiempo();
        });

        var url3 = "Sistema/ListarProveedores";
        $.get(url3, function (data) {
            if (data) {
                var html = "<table>";
                html += "<thead>";
                html += "<tr class='FilaCabecera'>";
                html += "<td>Codigo</td>";
                html += "<td>Nombre del Proveedor</td>";
                html += "<td>Direccion</td>";
                html += "<td>Contacto</td>";
                html += "</tr>";
                html += "</thead>";
                html += "<tbody>";
                $.each(data, function (index, item) {
                    html += "<tr class='FilaDatos'>";
                    html += "<td>" + item.Codigo + "</td>";
                    html += "<td>" + item.Nombre + "</td>";
                    html += "<td>" + item.Direccion + "</td>";
                    html += "<td>" + item.Contacto + "</td>";
                    html += "</tr>";
                });
                html += "</tbody>";
                html += "</table>";
                $("#divProveedor").html(html);
            }
            peticionesPendientes--;
            if (peticionesPendientes === 0) mostrarTiempo();
        });
    });
