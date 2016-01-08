<?php if ($lj) { ?>
<h3>Impressão:</h3>
<hr/>
<div style="border:1px solid gray;width:250px;color:black;padding:15px;margin:0px;font-size:12px;font-family:Tahoma;">
<table style="border:0px;">
	<tr>
		<td width="50%">Item:</td>
		<td><input style="width:125px;text-align:center;" type="text" name="1" value="<?php echo $dados['item']; ?>" disabled/></td>
	</tr>
	<tr>
		<td width="50%">Desconto:</td>
		<td><input style="width:125px;text-align:center;" type="text" name="2" value="<?php echo $dados['desconto']; ?>" disabled/></td>
	</tr>
		<?php if ($lj ==2) {	?>
	<tr>
		<td width="50%">Parcelas:</td>
		<?php if ($dados['parcelas']==0){ $dados['parcelas'] = "N/A"; } ?>
		<td><input style="width:125px;text-align:center;" type="text" name="3" value="<?php echo $dados['parcelas']; ?>" disabled/></td>
	</tr>
	<tr>
		<td width="50%">Valor da parcela:</td>
		<td><input style="width:125px;text-align:center;" type="text" name="4" value="<?php echo $dados['parcela']; ?>" disabled/></td>
	</tr>
		<?php } ?>
	<tr>
		<td width="50%">Valor final:</td>
		<td><input style="width:125px;text-align:center;" type="text" name="5" value="<?php echo $dados['pFinal']; ?>" disabled/></td>
	</tr>
		<?php if ($lj ==2) { ?>
	<tr>
		<td width="50%">Tx de juros:</td>
		<td><input style="width:125px;text-align:center;" type="text" name="6" value="<?php echo $dados['txjuros'] . "%"; ?>" disabled/></td>
	</tr>
		<?php } ?>
	</table>
</div>
<?php } else { header("Location: ../"); } ?>