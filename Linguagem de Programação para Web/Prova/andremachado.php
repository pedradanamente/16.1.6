<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
0, 1, 1, 2, 3, 5, 13, 21, 34, 55, 89, 144, 233, 377, ...
* ---------------------------------------------------------------------------------------------------- */
//numero de sequencia a apresentar:
$fib=rand(5,20);

//começando com 0 e 1:
$mrfib[0]=0;
$mrfib[1]=1;
$q=2;
$apresentacao="0, 1, ";

//processamento:
for ($i=1;$q<$fib;$i++) {
	$apresentacao.=$mrfib[0]+$mrfib[1].", ";
	$atual=$mrfib[0]+$mrfib[1];
	$mrfib[0]=$mrfib[1];
	$mrfib[1]=$atual;
	$q++;
}
echo "Os $fib primeiros numeros da sequencia é: $apresentacao";
?>
