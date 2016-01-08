<?php ini_set('default_charset','UTF-8'); ?>
<div style="font-size:12px;font-family:Arial;">
<?php
$contador=1;
$teste=rand(1,20);
while($contador<=$teste){
	if ($contador%2==0) { echo "PAR: $contador <br/>"; }
	else { echo "IMPAR: $contador <br/>"; }
	$contador++;
}
?>
</div>