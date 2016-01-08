<?php
require("conexao.php");
?>
<div style="margin-bottom:15px;padding:5px;border:0px;">
	<ul style="padding:0px;">
		<li style="list-style:none;"><a style="float:left;text-decoration:none;font-family:'arial';margin-right:30px;" href="index.php">Página inicial</a></li>
		<li style="list-style:none;"><a style="float:left;text-decoration:none;font-family:'arial';margin-right:30px;" href="insert.php">Inserir novo</a></li>
	</ul>
	<div style="clear:both;"><br/><hr/></div>
</div>
<?php
conecta();

$comandoSql = "SELECT * FROM cds";
$query = mysql_query($comandoSql,$conexao) or die (mysql_error());

echo "<h3>Vou fazer a seguinte consulta: $comandoSql</h3>";
?>
<form action="editar.php" method="post">
	<table style="border:1px solid gray;width:400px;">
		<tr style="font-family:'arial';font-size:14px;background-color:gray;height:30px;" >
			<th>Nome do CD</th>
			<th>Categoria</th>
			<th colspan="3">Ação</th>
		</tr>
<?php
while ($row=mysql_fetch_array($query)) {
?>
		<tr style="background-color:rgba(0,0,0,0.2);">
			<td ><?php echo $row['nomeCd']; ?></td>
			<td><?php echo $row['Categoria']; ?></td>
			<td><a href="excluir.php?id=<?php echo $row['idCd']; ?>"><img src="imagens/excluir.png" height="20px;"/></a></td>	
			<td><a id="editando_<?php echo $row['idCd']; ?>" href="editar.php?id=<?php echo $row['idCd']; ?>"><img src="imagens/editar.png" height="20px;" /></a></td>
		</tr>
<?php
}
?>

	</table>
</form>
<br/>
<h3>Foram encontrados <?php echo mysql_num_rows($query); ?> registros na tabela</h3>
<?php

mysql_free_result($query);
fexaconexao();

include("alerts.php");
?>
