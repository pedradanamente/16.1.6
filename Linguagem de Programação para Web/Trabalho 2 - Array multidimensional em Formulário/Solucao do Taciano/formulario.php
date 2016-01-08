<!DOCTYPE html>
<html lang="pt-br">
<head>
	<title>Atividade 02</title>
</head>
<body>
	<form action="processa.php" method="POST"/>
	<?php
		$alunos = 5;

		for($x=1; $x<=$alunos; $x++) 
		{
			echo "<h2>Aluno {$x}</h2>";
	?>		
			<p>Nome: <input type="text" name="nome<?php=$x?>" value="Aluno 0<?php=$x?>" size="50"/></p>
			<p>Idade: <input type="number" name="idade<?php=$x?>" max="100" min="16" value="<?php=rand(20,30)?>" size="10"/></p>
			<p>
				Sexo: <input type="radio" name="sexo<?php=$x?>" value="Masculino" id="M<?php=$x?>" /> <label for="M<?php=$x?>">Masculino</label>
				<input type="radio" name="sexo<?php=$x?>" value="Feminino" id="F<?php=$x?>" /> <label for="F<?php=$x?>">Feminino</label>
				
			</p>
			<p>
			<select name="curso<?php=$x?>">
				<option value="1">Administração</option>
				<option value="2">Ciências Contábeis</option>
				<option value="3">Sistemas de Informação</option>
			</select>
			</p>
	<?php
		}
	?>				
		<p>
			<input type="submit" value="Enviar" name="enviar"/>
		</p>
				
	</form>		
</body>
</html>