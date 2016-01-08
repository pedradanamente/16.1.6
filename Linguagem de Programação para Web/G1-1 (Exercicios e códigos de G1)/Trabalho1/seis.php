<?php
ini_set('default_charset','UTF-8');
/* --------------------------------------------------------------------------------------------------- *
6) [0,7] Escreva um algoritmo PHP que crie um array multidimensional de carros onde o 
índice será a marca (VW, GM, Fiat, Ford) e para cada uma dessas marcas/posições 
adicione quatro veículos. Depois imprima o carro dois da VW, o carro um da GM, o carro 
quatro da Fiat e o carro três da Ford.
* ---------------------------------------------------------------------------------------------------- */	
$carros = array(
	"VW" => 
		array (
			0 => "BMW X1 2.0 18l 4X2 16V", 
			1 => "BMW X5 3.0 SI 4X4 24V",
			2 => "CHEVROLET CELTA 1.0 MPFI",
			3 => "CHEVROLET VECTRA 2.0"),
	"GM" =>
		array (
			0 => "S10",
			1 => "Trailblazer",
			2 => "Onix",
			3 => "Prisma"),
	"FIAT" =>
		array (
			0 => "Sedan",
			1 => "Suv",
			2 => "Station Wagon",
			3 => "Minivan"),
	"FORD" =>
		array (
			0 => "Fiesta 2000",
			1 => "K",
			2 => "New Fiesta Hatch",
			3 => "Novo Focus Hatch")
);
$t=count($carros);
foreach ($carros as $key => $elemento) {
	for ($i=0;$i<$t;$i++) {
		if ($i==0) { echo "<hr/><strong>Série $key:</strong><br/>"; }
		if( ($key == "VW")&&($i==1) || ($key == "GM")&&($i==0) || ($key == "FIAT")&&($i==3) || ($key=="FORD")&&($i==2) ){
			$x=$carros[$key][$i];
			if (!empty($x)){ echo "$x<br/>"; }
		}
	}
}
?>