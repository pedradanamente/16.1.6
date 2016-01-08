<?php
if (isset($_GET['acao'])){
	if ($_GET['acao']=="incluidoOk") {
		echo "<script>alert('INCLUIDO');</script>";
	}
	else if ($_GET['acao']=="incluidoErro") {
		echo "<script>alert('ERRO AO INCLUIR');</script>";
	}
	else if ($_GET['acao']=="excluirOk") {
		echo "<script>alert('EXCLUIDO');</script>";
	}
	else if ($_GET['acao']=="excluirErro") {
		echo "<script>alert('ERRO AO EXCLUIR');</script>";
	}
	else if ($_GET['acao']=="editarOk") {
		echo "<script>alert('EDITADO');</script>";
	}
	else if ($_GET['acao']=="editarErro") {
		echo "<script>alert('ERRO AO EDITAR');</script>";
	}
}
?>