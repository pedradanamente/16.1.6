<?php

ini_set('display_errors', 1);
ini_set('default_charset','UTF-8');

function __autoload($className) {
    $filename = "class/".$className.".class.php";
    if (is_readable($filename)) {
        require $filename;
    }
}

echo "<hr/><strong>Chamada do Metodo bomDia a partir da Classe1:</strong><hr/>";
$OO = new Classe1();
$OO -> bomDia();

?>