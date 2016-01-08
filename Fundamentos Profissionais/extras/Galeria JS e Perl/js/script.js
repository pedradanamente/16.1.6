/* Mensagem de senha incorreta */
function msgdenied() {
	alert("Senha incorreta")
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
	document.getElementById("ajuda").style.display = "block";
	document.getElementById("ajuda").style.color = "yellow";
	document.getElementById("ajuda").innerHTML = text;
}