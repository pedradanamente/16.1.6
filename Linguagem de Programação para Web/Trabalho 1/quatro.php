<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
4) [0,4] Escreva um algoritmo PHP que receba uma string com o seu nome, encontre o 
número total de caracteres desta e imprima todos os números que existem entre 0 e o 
número total, exemplo:
Nome = “Taciano Balardin de Oliveira”
Caracteres = 28
Imprime: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27
* ---------------------------------------------------------------------------------------------------- */
$str="André Silveira Machado";
$x=strlen($str);
for ($i=1;$i<$x;$i++) {
	echo "$i ";
}
?>