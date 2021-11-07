// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. 
var usuarioPlata = 0;
let seleccionados = []; 

function ValidateJugSelection(posicion, contrato, idJug)  
{  
    /*var checkboxes = document.getElementsById(posicion);
    var numberOfCheckedItems = 0;  
    for(var i = 0; i < checkboxes.length; i++)  
    {  
        if(checkboxes[i].checked) {
            numberOfCheckedItems++;  
        }  
    }  */
    if(seleccionados.indexOf(idJug) != -1) {
        seleccionados.splice(seleccionados.indexOf(idJug), 1);
        usuarioPlata = parseFloat(document.getElementById("plata").innerHTML) + parseFloat(contrato);
        document.getElementById("plata").innerHTML = usuarioPlata;
    }
    else {
        usuarioPlata = document.getElementById("plata").innerHTML - parseFloat(contrato);
        if(usuarioPlata < 0 /*|| numberOfCheckedItems != 1*/) {
            
            alert("¡No podés seleccionarlo!");   
            document.getElementById(posicion).checked = 0;
        }
        else {
            document.getElementById("plata").innerHTML = usuarioPlata;
            seleccionados.push(idJug);
            
        }
    }
    
    
}   
function ValidateJugSelectionSup(posicion, contrato, idJug)  
{  
    /*var checkboxes = document.getElementsById(posicion);
    var numberOfCheckedItems = 0;  
    for(var i = 0; i < checkboxes.length; i++)  
    {  
        if(checkboxes[i].checked) {
            numberOfCheckedItems++;  
        }  
    }  */
    if(seleccionados.indexOf(idJug) != -1) {
        seleccionados.splice(seleccionados.indexOf(idJug), 1);
        usuarioPlata = parseFloat(document.getElementById("plata").innerHTML) + parseFloat(contrato);
        document.getElementById("plata").innerHTML = usuarioPlata;
    }
    else {
        usuarioPlata = document.getElementById("plata").innerHTML - parseFloat(contrato);
        if(usuarioPlata < 0 /*|| numberOfCheckedItems != 1*/) {
            alert("¡No podés seleccionarlo!");
            posicion.checked = 0;
        }
        else {
            document.getElementById("plata").innerHTML = usuarioPlata;
            seleccionados.push(idJug);
            
        }
    }
}  