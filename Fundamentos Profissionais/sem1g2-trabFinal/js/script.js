/* Mensagem de senha incorreta */
function msgdenied() {
	alert("Senha incorreta");
}
/* Validação do formulário de cadastro */
function formulario() {
	document.getElementById("formCadastro").onsubmit = validar;
}
function validar(){
	var formCadastro=document.getElementById("formCadastro");
	if (formCadastro.nome.value.length<4) {
	mostraTexto("Nome digitado é muito curto!");
	return false;	
	}	
	if (formCadastro.senha.value.length<4){
		mostraTexto("A senha escolhida é de baixa segurança!");
		return false;
	}
}
function mostraTexto(text) {
	document.getElementById("messageSignUp").style.display = "block";
	document.getElementById("messageSignUp").style.color = "yellow";
	document.getElementById("messageSignUp").innerHTML = text;
}
/* Validação do formulário de contato */
function CttoSendFormulario() {
	document.getElementById("CttoSendFormulario").onsubmit = CttoSendValidar;
}
function CttoSendValidar() {
	var CttoSendFormulario=document.getElementById("CttoSendFormulario");
	if (CttoSendFormulario.cttoMessage.value.length<10){
		alert("Mensagem muito curta!");
		return false;	
	}
}








