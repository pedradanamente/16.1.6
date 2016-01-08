<?php
include("lib/general.functions.php");
include("lib/prints.functions.php");

$lj=2;
$nome="Loja tudão";
configuracao();
if (isset($_POST['buttonChange'])) { change($lj); }
?>
<!Doctype html>
<html lang="pt-br">
<head>
	<meta charset="UTF-8">
	<title><?php echo $nome; ?></title>
</head>
<body>
<nav><?php welcome($nome); ?></nav>
<section>
	<div style="width:715px;border:1px solid green;padding:15px;background-color:#eeeee0;">
			<form action='<?php echo $_SERVER["PHP_SELF"]; ?>' method='post'>
				<button style="border:1px solid green;height:25px;width:100px;background-color:#4169e1;color:white;font-size:12px;font-family:Arial;" name='buttonChange'>Mudar de Loja</button>
			</form>
			<hr/>
			<?php include("includes/entrada.php"); ?>
	<?php
	if (isset($_POST['buttonIncluir'])) {
	
		$dados['item']=$_POST['item'];
		$dados['preco']=$_POST['preco'];
		$dados['desconto']=number_format($_POST['desconto'],2,",",".");
		$dados['parcelas']=$_POST['parcelas'];
		$dados['txjuros']=$_POST['txjuros'];
		
		$dados['parcela']=parcela($dados);
		pFinal($dados);
		include("includes/saida.php");
	}
	?>
	</div>
</section>
<footer><?php footer(); ?></footer>
</body>
</html>