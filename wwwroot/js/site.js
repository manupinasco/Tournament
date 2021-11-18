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

function verificarPresupuesto() {
    const SIN_SALDO = 0;
    if (parseFloat(document.getElementById("plata").innerHTML) < SIN_SALDO) {
        document.querySelector('#presupuestoColor').classList.add("badge-danger");
        toastr.error("No tiene presupuesto!", "Aviso!");
        return false;
    }
    else {
        document.querySelector('#presupuestoColor').classList.remove("badge-danger");
        validarCampos();
    }
}

function validarCampos(){
        var total, i;
        total = document.querySelectorAll(".selectpicker");
        for (i = 0; i < total.length; i++) {
          if( total[i].value == "") {
            toastr.error("Debe ingresar todos los jugadores!", "Aviso!");
            return false;
          }
        }
        enviarFormulario();
    }

function enviarFormulario(){
  var option = true;
  var hayEquipo = document.getElementById("hayEquipo");
      if (hayEquipo) {
          option = confirm("Ya existe un equipo. ¿Quiere reemplazarlo?");
      }
      if(option) {
          document.querySelector("#form1").submit();
      }
}

let guardarEquipo = document.querySelector("#guardarEquipo");
guardarEquipo.addEventListener("click",verificarPresupuesto);
