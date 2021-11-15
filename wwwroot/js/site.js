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
    const SIN_SALDO = 0;
    if (parseFloat(document.getElementById("plata").innerHTML) < SIN_SALDO) {
        toastr.error("No tiene presupuesto!", "Aviso!");
        return false;
    }
    else {
        var option = true;
        var hayEquipo = document.getElementById("hayEquipo");
            if (hayEquipo) {
                option = confirm("Ya existe un equipo. ¿Quiere reemplazarlo?");
            }
            if(option) {
                document.querySelector("#form1").submit();
            }
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

let guardarEquipo = document.querySelector("#guardarEquipo");
guardarEquipo.addEventListener("click",validarCampos);

function Confirm(title, msg, $true, $false, $link) {
    var $content =  "<div class='dialog-ovelay'>" +
                    "<div class='dialog'><header>" +
                     " <h3> " + title + " </h3> " +
                     "<i class='fa fa-close'></i>" +
                 "</header>" +
                 "<div class='dialog-msg'>" +
                     " <p> " + msg + " </p> " +
                 "</div>" +
                 "<footer>" +
                     "<div class='controls'>" +
                         " <button class='button button-danger doAction'>" + $true + "</button> " +
                         " <button class='button button-default cancelAction'>" + $false + "</button> " +
                     "</div>" +
                 "</footer>" +
              "</div>" +
            "</div>";
     $('body').prepend($content);
  $('.doAction').click(function () {
    window.open($link, "_blank"); 
    $(this).parents('.dialog-ovelay').fadeOut(500, function () {
      $(this).remove();
    });
  });
$('.cancelAction, .fa-close').click(function () {
    $(this).parents('.dialog-ovelay').fadeOut(500, function () {
      $(this).remove();
    });
  });
  
}