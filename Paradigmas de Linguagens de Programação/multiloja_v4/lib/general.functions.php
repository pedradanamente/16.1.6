<?php
/* Seta configurações específicas
------------------------------------------------------------- */
function configuracao() {
	ini_set('display_errors',1);
	ini_set('display_startup_erros',1);
	ini_set('default_charset','UTF-8');
	error_reporting(E_ALL);
	setlocale(LC_ALL,"pt_BR");
	date_default_timezone_set('America/Sao_Paulo');
}
/* Calcula Valor total
------------------------------------------------------------- */
function pFinal(&$dados) {
	if (empty($dados['txjuros'])) { $dados['txjuros'] = 0; }
	$dados['pFinal']=number_format(($dados['preco']-$dados['desconto'])+juros($dados),2,",",".");
}
/* Calcula os Juros
------------------------------------------------------------- */
function juros($dados){
	if ((!empty($dados['parcelas']))&&($dados['parcelas']>0)) {
		$r = ($dados['preco']-$dados['desconto'])*$dados['txjuros']/100;
	}
	else { $r = 0; }
	return $r;
}
/* Calcula Valor da parcela
------------------------------------------------------------- */
function parcela($dados) {
	if(empty($dados['parcelas'])) { $dados['parcelas'] = 0; }
	$r = ($dados['preco']-$dados['desconto']) / $dados['parcelas'];
	if ($dados['parcelas']>0) {
		$r	+=(juros($dados)/$dados['parcelas']);
	}
	return number_format($r,2,",",".");
}
/* Trocar de Loja
------------------------------------------------------------- */
function change($lj) {
	if ($lj==1) {
		$lj = 2;
	} else {
		$lj = 1;
	}
	header("location: $lj" . ".php");
}
?>