<?php
require("conexao.php");
include("menu.php");
conecta();
$id=$_GET['id'];

$comandoSql="DELETE FROM cds WHERE idCd = '$id'";
$query = mysql_query($comandoSql,$conexao) or die (mysql_error());

if ($query) {
	header("location:index.php?acao=excluirOk");
}else {
    header("location:index.php?acao=excluirErro");
}

fexaconexao();