<?php
ini_set('default_charset','UTF-8');
ini_set('display_errors', 0);
/* **************************** */
function conecta() {
	
	$bd_servidor="localhost";
	$bd_usuario="root";
	$bd_senha="";
	$bd_banco="aula";
	
	global $conexao;
	$conexao = mysql_connect($bd_servidor,$bd_usuario,$bd_senha) or die ("ERRO AO CONECTAR NO MYSQL");
	mysql_select_db($bd_banco,$conexao) or die ("ERRO AO CONECTAR NO BANCO");
}
/* **************************** */
function fexaconexao() {
	mysql_close();
}
?>