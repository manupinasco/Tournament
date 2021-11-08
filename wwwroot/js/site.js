// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. 
var usuarioPlata = 0;
let seleccionados = []; 

function ValidateJugSelection(objeto, contrato, nombre)  
{  
    if(seleccionados.indexOf(nombre) != -1) {
        seleccionados.splice(seleccionados.indexOf(nombre), 1);
        usuarioPlata = parseFloat(document.getElementById("plata").innerHTML) + parseFloat(contrato);
        document.getElementById("plata").innerHTML = usuarioPlata;
    }
    else {
        usuarioPlata = document.getElementById("plata").innerHTML - parseFloat(contrato);
        if(usuarioPlata < 0) {
            
            alert("¡No podés seleccionarlo!");   
            objeto.checked = 0;
        }
        else {
            document.getElementById("plata").innerHTML = usuarioPlata;
            seleccionados.push(nombre);
            
        }
    }
    
    
}   