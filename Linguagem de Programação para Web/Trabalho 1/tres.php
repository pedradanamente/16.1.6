<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
3) [0,4] Escreva um algoritmo PHP que gere dois números aleatórios, x e y entre 0 e 10, e 
mostre na tela y vezes os números de 1 a x. Por exemplo, se entrar 7 e 4,mostrar na tela:
1 2 3 4 5 6 7
1 2 3 4 5 6 7
1 2 3 4 5 6 7
1 2 3 4 5 6 7
* ---------------------------------------------------------------------------------------------------- */
$x=rand(0,10);
$y=rand(0,10);
for ($i=0;$i<$y;$i++) {
	for ($j=1;$j<=$x;$j++) {
		echo "$j ";
	}
	echo "<br/>";
}
?>

