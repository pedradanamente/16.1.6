<?php
date_default_timezone_set('America/Sao_Paulo');
echo "Hoje é " . date("d/m/Y \à\s H:i:s");
$timestamp = mktime(date(H), date(i), date(s), date(m), date(d)+7, date(Y));
$d=date('d/m/Y',$timestamp);
echo "<br/>Daqui uma semana será dia $d";
?>