<?php
require("conexao.php");
conecta();

function geraPalavra() {

    // Marcos Amaral - www.marcosamaral.com

    $CaracteresAceitos = 'abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ';
    $max = strlen($CaracteresAceitos)-1;
    $palavra = NULL;
    for($i=0; $i < 4; $i++) {
         $palavra .= $CaracteresAceitos{mt_rand(0, $max)};
    }    
return $palavra;
}

$nomeCd=geraPalavra();
$emStock=100;
$emEncomenda=40;
$Genero="Popular";
$Categoria="Heavy Metal";

$comandoSql="INSERT INTO cds (nomeCd,emStock,emEncomenda,Genero,Categoria)
	VALUES ('$nomeCd','$emStock','$emEncomenda','$Genero','$Categoria')";
$query = mysql_query($comandoSql,$conexao) or die (mysql_error());

if ($query) {
	header("location:index.php?acao=incluidoOk");
}else {
	header("location:index.php?acao=incluidoErro");
}

fexaconexao();