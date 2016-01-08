<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
2) [0,4] Escreva um algoritmo PHP que gere um valor aleatório entre 5 e 15 e calcule o seu 
fatorial (!), sabendo que fatorial de um número é: 
7! = 7*6*5*4*3*2*1
4! = 4*3*2*1
* ---------------------------------------------------------------------------------------------------- */
$value=rand(5,15);
$x=$value;
for ($i=$value-1;$i>0;$i--) {
	$x*=$i;
}
echo "Fatorial de $value é: $x";
?>
