<!DOCTYPE html>
<html lang="pt-br">
<head>
	<title>Atividade 02</title>
</head>
<body>
		<?
			$alunos = 5;

			for($x=1; $x<=$alunos; $x++) 
			{
				$dados[$x]['nome'] = $_POST["nome".$x];
				$dados[$x]['idade'] = $_POST["idade".$x];
				$dados[$x]['sexo'] = $_POST["sexo".$x];
				$dados[$x]['curso'] = $_POST["curso".$x];
			}

			var_dump($dados);

			$cursos['1'] = 'Administração';
			$cursos['2'] = 'Ciências Contábeis';
			$cursos['3'] = 'Sistemas de Informação';

			$adm = '0';

			for($x=1; $x<=$alunos; $x++)
			{				
				echo "<h3>Aluno {$x}</h3>";
				echo "Nome: {$dados[$x]['nome']}<br/>";
				echo "Idade: {$dados[$x]['idade']}<br/>";
				echo "Sexo: {$dados[$x]['sexo']}<br/>";
				echo "Curso: {$cursos[$dados[$x]['curso']]}<br/><br/>";
				
				$idade += $dados[$x]['idade'];
				
				if($dados[$x]['curso'] == "3")
					$si .= "<li>{$dados[$x]['nome']}</li>";
					
				if(($dados[$x]['sexo'] == "Feminino") && ($dados[$x]['curso'] == 1))
					$adm++;
			}
			
			$media = $idade / $alunos;

			echo "* A média de idade dos alunos é de {$media} anos. <br/><br/>";
			echo "* Os alunos que cursam Sistemas de Informação: <br/> <ul>{$si}</ul><br/>";
			echo "* {$adm} alunas cursam Administração.";
			
		?>
</body>
</html>