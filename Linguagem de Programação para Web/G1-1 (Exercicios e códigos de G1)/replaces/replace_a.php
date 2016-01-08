<?php
ini_set('default_charset','UTF-8');
if( (isset($_POST['enviar'])) && (!empty($_POST['str'])) ){
	$str=$_POST['str'];
	$a = str_replace("a", "", $str);
	$tamanho=strlen($str)-strlen($a);
	echo "<div style='font-size:12px;font-family:arial;margin-bottom:15px;'>A string final é: <strong>$a</strong> com uma quantidade de a removidos de: <strong>$tamanho</strong></div><hr/>";
}
?>
<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
	<input style="border:1px solid green;background-color:gold;padding:5px;color:green;" type="text" name="str"/>
	<button style="border:1px solid green;background-color:gold;padding:4px;color:green;font-weight:bold;" name="enviar">Enviar</button>
</form>