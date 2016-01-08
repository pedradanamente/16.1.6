<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
5) [0,7] Escreva um algoritmo PHP que crie os arrays $a = array(20,3,15,7,19,13,12,10,4,9,2); 
e $b = array(1,19,11,18,20,5,14,16,8,3,10). Após, ordene e imprima o array $a de forma 
crescente e o array $b de forma decrescente. Por fim, realize a intersecção dos dois arrays
e imprima o resultado.
* ---------------------------------------------------------------------------------------------------- */
$a = array(20,3,15,7,19,13,12,10,4,9,2);
$b = array(1,19,11,18,20,5,14,16,8,3,10);
asort($a);
arsort($b);
$c=array_intersect($a, $b);
echo "<p style='margin-top:10px;'><strong>Primeiro array:</strong></p>";
foreach ($a as $elemento) {
	echo "$elemento ";
}
echo "<p style='margin-top:10px;'><strong>Segundo array:</strong></p>";
foreach ($b as $elemento) {
	echo "$elemento ";
}
echo "<p style='margin-top:10px;'><strong>Terceiro array:</strong></p>";
foreach ($c as $elemento) {
	echo "$elemento ";
}
?>