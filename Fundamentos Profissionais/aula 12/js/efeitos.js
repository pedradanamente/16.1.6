window.onload=iniciar;
function iniciar() {
var botao=document.getElementById("botaozinho");
botao.onclick = muda_texto_botao;
//botao.onclick = texto_apaga;
botao.onmouseover = texto;
}


function texto() {
//document.body.style.backgroundColor="green";
var texto = document.getElementById("ajuda");
texto.innerHTML="Clique para trocar de cor!!";
}
function texto_apaga() {
var texto = document.getElementById("ajuda");
texto.innerHTML="<br/>";
}
function muda_texto_botao() {
var texto = document.getElementById("botaozinho");
texto.innerHTML="NOME NOVO";
}
