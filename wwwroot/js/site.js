// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. 
var usuarioPlata = 0;
let dict = {};

function ValidateJugSelection(nombre, elemento)  
{  
    contrato = elemento.selectedOptions[0].text.substr(-4);
   if(nombre in dict) {
        usuarioPlata = parseFloat(document.getElementById("plata").innerHTML) + parseFloat(dict[nombre]);
        dict[nombre] = contrato;
        usuarioPlata = usuarioPlata - parseFloat(contrato);
        document.getElementById("plata").innerHTML = usuarioPlata; 
    }
    else { 
        usuarioPlata = parseFloat(document.getElementById("plata").innerHTML) - parseFloat(contrato);
        document.getElementById("plata").innerHTML = usuarioPlata;
        dict[nombre] = contrato;
    }
    
    
}   

function enviarFormulario() {
    if (parseFloat(document.getElementById("plata").innerHTML) < 0) {
        alert("No te alcanza el presupuesto");
    }
    else {
        document.form1.submit();
    }
    
}