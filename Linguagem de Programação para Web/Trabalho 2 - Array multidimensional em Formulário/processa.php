<?php
if (isset($_POST['enviar'])) {

$lista = array();
for($i=1; $i<=5; $i++){
   $lista[$i]['nome'] = $_POST['nome'.$i];
   $lista[$i]['curso']=$_POST['curso'.$i];
   $lista[$i]['idade']=$_POST['idade'.$i];
   $lista[$i]['sexo']=$_POST['sexo'.$i];
}
	?>
	<!doctype html>
	<html>
	<head>
		<title>Resposta do formulário</title>
        <meta charset="UTF-8">
	</head>
	<body>
	<section>
		<div style="padding:15px;border:1px solid gray;width:800px;margin:0 auto;">
			<h3 style="font-family:Arial;">RESPOSTA DO FORMULÁRIO</h3>
			<hr/>
			<h3>Lista de alunos:</h3>
			<div style="border:1px solid gray;width:500px;padding:15px;">
				<table style="width:500px;font-family:Arial;font-size:12px;">
					<tr>
						<th>Aluno</th><th>Curso</th><th>Idade</th><th>Sexo</th>
					</tr>
					<?php
					for ($i=1;$i<=5;$i++){
					?>
					<tr style="text-align:center;">
						<td><?php echo $lista[$i]['nome']; ?></td>
						<td><?php echo $lista[$i]['curso']; ?></td>
						<td><?php echo $lista[$i]['idade']; ?></td>
						<td><?php echo $lista[$i]['sexo']; ?></td>
					</tr>
					<?php
					}
					?>
				</table>
			</div>
			<div>
				<hr/>
				<h3>A média de idade dos 5 alunos:</h3>
				<?php
				$soma=0;
				for ($i=1;$i<=5;$i++) {
					$soma+=$lista[$i]['idade'];
				}
				$media=$soma/5;
				echo "<div style='clear:both;font-size:12px;font-family:Arial;'>{$media}</div>";
				?>
			</div>
			<div>
				<hr/>
				<h3>Alunos que cursam Sistemas de Informação:</h3>
				<?php
				for ($i=1;$i<=5;$i++){
					if ($lista[$i]['curso']=="Sistemas de Informação"){
						echo "<div style='clear:both;font-size:12px;font-family:Arial;'>{$lista[$i]['nome']}</div>";
					}
				}
				?>
			</div>
			<div>
				<hr/>
				<h3>Quantidade dos alunos que cursam Administração do sexo Feminino:</h3>
				<?php
				$alunosADM=0;
				for ($i=1;$i<=5;$i++){
					if (($lista[$i]['curso']=="Administração")&&($lista[$i]['sexo']=="feminino")){
						$alunosADM++;
					}
				}
					echo "<div style='clear:both;font-size:12px;font-family:Arial;'>{$alunosADM}</div>";
				?>
			</div>
			<hr/>
			<div style="margin-top:50px;float:right;"><a href="formulario.php">Voltar p/ formulário</a></div>
			<div style="clear:both;"></div>
		</div>
		</section>
		<footer><div style="margin:0 auto;width:800px;text-align:center;padding:15px;font-size:12px;font-family:Arial;">Desenvolvido por André Silveira Machado</div></footer>
	</body>
	</html>
		<?php
}else {
	header("Location:formulario.php");
}
?>

