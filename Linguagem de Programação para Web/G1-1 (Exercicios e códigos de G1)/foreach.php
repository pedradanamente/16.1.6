<?php ini_set('default_charset','UTF-8'); ?>
<?php
$arr=array('Azul','Verde','Laranja','Vermelho','Preto','Branco');
echo "<h4 style='font-family:Tahoma;'>Foreach S/ Índice</h4><hr/>";
foreach ($arr as $elemento) {
	echo "<p style='font-size:12px;font-family:Arial;margin:0px;padding:0px;'>$elemento</p>";
}
echo "<h4 style='font-family:Tahoma;'>Foreach C/ Índice</h4><hr/>";
foreach ($arr as $i => $elemento) {
	echo "<p style='font-size:12px;font-family:Arial;margin:0px;padding:0px;'>$i => $elemento </p>";
}