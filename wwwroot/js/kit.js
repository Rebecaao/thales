
var buttonIniciarLeitura = document.getElementsByClassName('button-iniciar-leitura');

console.log(buttonIniciarLeitura);


document.getElementsByClassName('button-iniciar-leitura')[0]
.addEventListener('click', function () {
     document.getElementsByClassName('button-iniciar-leitura')[0].childNodes[1].innerText = "LEITURA INICIALIZADA" 
     document.getElementsByClassName('situacao')[0].style.background = "#6AB8E5"
     document.getElementsByClassName('situacao')[0].innerText = "EM PRODUÇÃO" 

    })