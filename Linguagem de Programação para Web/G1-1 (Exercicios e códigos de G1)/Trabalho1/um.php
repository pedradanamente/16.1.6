<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
1) [0,4] Escreva um algoritmo PHP que gere valores aleatórios entre 0 e 10 para as variáveis 
A, B, C e D. Efetue a soma entre A e C, a multiplicação entre B e D e verifique se o 
resultado da soma é maior, menor ou igual ao da multiplicação. Imprima: "$A+$C é maior 
que $B+$D", "$A+$C é menor que $B+$D", "$A+$C é igual a $B+$D".
* ---------------------------------------------------------------------------------------------------- */
$a=rand(0,10);
$b=rand(0,10);
$c=rand(0,10);
$d=rand(0,10);
$soma=$a+$c;
$multiplicacao=$b*$d;
if ($soma==$multiplicacao) {
	echo "$soma é igual a $multiplicacao";
}
else if ($soma<$multiplicacao) {
	echo "$soma é menor que $multiplicacao";
}
else {
	echo "$soma é maior que $multiplicacao";
}
?>