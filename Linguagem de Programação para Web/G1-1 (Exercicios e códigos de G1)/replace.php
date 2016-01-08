<?php
$str="Generais reunindo seus seguidores como bruxas numa missa negra.";
$replace=str_replace("a", "", $str, $contador);
echo "<p><strong>String modificada:</strong> $replace</p>";
echo "<p><strong>Total de a removido:</strong> $contador</p>";
?>