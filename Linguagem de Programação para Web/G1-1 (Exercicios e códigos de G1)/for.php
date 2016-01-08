<?php ini_set('default_charset','UTF-8'); ?>
<?php
$teste=rand(1,20);
echo "<h4 style='font-family:Tahoma'>Incremento:</h4><hr/>";
for ($i=1;$i<=$teste;$i++){
	echo "<p style='font-family:Arial;font-size:12px;margin:0px;padding:0px;'>O valor do indice é $i</p>";
}
echo "<h4 style='font-family:Tahoma'>Decremento:</h4><hr/>";
for ($i=$teste;$i>=1;$i--){
	echo "<p style='font-family:Arial;font-size:12px;margin:0px;padding:0px;'>O valor do indice é $i</p>";
}
?>