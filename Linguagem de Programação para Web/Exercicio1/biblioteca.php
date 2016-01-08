<!Doctype html>
<html lang="pt-br">
<body>
<head>
	<title>library</title>
	<meta charset="UTF-8">
	<style>
	body {font-family:Arial;font-size:12px;}
	input {border:0px;background-color:rgba(0,0,0,0.2);}
	</style>
</head>
<nav>
	<h3>Biblioteca Acadêmica</h3>
</nav>
<section>
<?php
if (isset($_POST['enviar'])) {
	//entrada
	$id_book=$_POST['id_book'];
	$nome_book=$_POST['nome_book'];
	$tipo_usuario=$_POST['tipo_usuario'];
	$id_usuario=$_POST['id_usuario'];
	$nome_usuario=$_POST['nome_usuario'];
	
	//processamento
	if ($tipo_usuario=="professor") {
		$devolucao=date('d/m/Y',strtotime('+10 days'));
	}
	if ($tipo_usuario=="aluno") {
		$devolucao=date('d/m/Y',strtotime('+3 days'));
	}
	
	//saida
	echo "<h2>Impressão:</h2>";
	echo "<strong>ID:</strong> {$id_book}, <strong>NOME LIVRO:</strong> {$nome_book}, <strong>TIPO DE USUARIO:</strong> {$tipo_usuario}, <strong>ID DO USUARIO:</strong> {$id_usuario}, <strong>NOME DE USUÀRIO:</strong> {$nome_usuario}";
	echo "<p><strong>Data para devolução:</strong> {$devolucao}</p> ";
	echo "<hr/>";
}
?>
</section>
<section>
	<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
		<table>
			<tr>
				<td>Id do Livro:</td>
				<td><input type="number" min="0" name="id_book" required/></td>
			</tr>
			<tr>
				<td>Nome do Livro:</td>
				<td><input type="text" name="nome_book" required/></td>
			</tr>
			<tr>
				<td>Tipo de usuário:</td>
				<td></td>
			</tr>
			<tr>
				<td>
					<label for="professor">Professor</label>
					<input type="radio" id="professor" name="tipo_usuario" value="professor" />
				</td>
				<td>
					<label for="aluno">Aluno</label>
					<input type="radio" id="aluno" name="tipo_usuario" value="aluno" checked/>
				</td>
			</tr>
			<tr>
				<td>Id do usuário:</td>
				<td><input type="number" min="0" name="id_usuario" required/></td>
			</tr>
			<tr>
				<td>Nome do usuário:</td>
				<td><input type="text" name="nome_usuario" required/></td>
			</tr>
		</table>
		<hr/>
		<button name="enviar">Enviar</button>
	</form>
</section>
<footer></footer>
</body>
</html>