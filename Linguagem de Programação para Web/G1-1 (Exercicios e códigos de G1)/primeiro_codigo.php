<?php
error_reporting(E_ALL);
ini_set('display_errors', true);
ini_set('default_charset','UTF-8');
?>
<!DOCTYPE html>
<html lang="pt-br">
<head><title>Primeiro código em php</title></head>
<body>
<?php
//Minhas primeiras linhas em php
$nome = 'André Silveira Machado';
$idade = 24;
echo '<h1>Hello Word!</h1>';
echo "Meu nome é: $nome <br/>";

$arr=array('Palio','Gol','Corsa','Fiesta','Uno');

echo "<br/> VAR DUMP: ";
var_dump($arr);
echo "<br/> VAR DUMP: ";
var_dump($idade);
echo "<br/> ECHO: $arr[1]";
echo "<br/> ECHO SEM INDICE: $arr";
print_r("</br> PRINT_R: $arr[1]");
print_r("</br> PRINT_R SEM INDICE: $arr");
?>
</body>
</html>