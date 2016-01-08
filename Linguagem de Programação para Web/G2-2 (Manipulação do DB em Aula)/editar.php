<?php
require("conexao.php");
include("menu.php");
conecta();
$id=$_GET['id'];
$novoNomeCd=rand(100,1000);

$comandoSql="UPDATE cds SET nomeCd = '$novoNomeCd' WHERE idCd = '$id'";
$query = mysql_query($comandoSql,$conexao) or die (mysql_error());

if ($query) {
	header("location:index.php?acao=editarOk");
}else {
    header("location:index.php?acao=editarErro");
}

fexaconexao();