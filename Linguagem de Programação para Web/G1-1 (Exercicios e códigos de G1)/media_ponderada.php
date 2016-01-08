<?php
$NG1=6;
$NG2=7;
echo '<div style="font-size:12px;font-family:Arial;">';
echo "Nota de G1: $NG1 </br>";
echo "Nota de G2: $NG2 </br>";
$MEDIAF=($NG1+$NG2*2)/3;
$MEDIAF=number_format($MEDIAF,2,',','.');
if ($MEDIAF>=6) { echo "Aprovado com media final: $MEDIAF"; }else { echo "Reprovado com media final: $MEDIAF"; }
echo '</div>';
?>