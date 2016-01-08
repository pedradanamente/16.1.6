<?php

include("class/Loja.class.php");

$OO = new Loja();

$OO -> itens['bermudas'] += 5;
echo "<hr/>(Adiciona 5) Valor: R$ ".number_format($OO -> itens['bermudas'],2);

$OO -> adiciona("bermudas",5);
echo "<hr/>(Adiciona 5) Valor: R$ ".number_format($OO -> itens['bermudas'],2);

$OO -> itens['bermudas'] -= 5;
echo "<hr/>(Remove 5) Valor: R$ ".number_format($OO -> itens['bermudas'],2);

$OO -> remove("bermudas",5);
echo "<hr/>(Remove 5) Valor: R$ ".number_format($OO -> itens['bermudas'],2);
?>