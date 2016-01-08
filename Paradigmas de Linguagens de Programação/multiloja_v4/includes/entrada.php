<?php if ($lj) { ?>
<div style="height:75px;">
	<form action='<?php echo $_SERVER["PHP_SELF"]; ?>' method='post'>
		<table style="border:0px;">
			<tr style="color:white;border:0px;font-family:Arial;background-color:#696969;font-size:13px;height:24px;">
				<th>Item</th>
				<th>Preço</th>
				<th>Desconto</th>
				<?php
				if ($lj == 2) {
				?>
				<th>Nº de parcelas</th>
				<th>Tx de juros</th>
				<?php
				}
				?>
				<th>Ação</th>
			</tr>
			<tr style="background-color:rgba(0,0,0,0.5);height:26px;margin:0px;">
				<td><input style="padding-left:5px;padding-right:5px;width:150px;background-color:rgba(0,100,100,0.3);color:gold;height:30px;border:0px;" type='text' name='item' required/></td>
				<td><input style="padding-left:5px;padding-right:5px;width:100px;background-color:rgba(0,100,100,0.3);color:gold;height:30px;border:0px;" type='number' step="any" name='preco'  placeholder='0,00' required/></td>
				<td><input style="padding-left:5px;padding-right:5px;width:100px;background-color:rgba(0,100,100,0.3);color:gold;height:30px;border:0px;" type='number' step="any" name='desconto' placeholder='0,00' required/></td>
				<?php
				if ($lj == 2) {
				?>
				<td>
					<select style="margin:0px;padding-left:5px;padding-right:5px;width:100px;background-color:rgba(0,100,100,0.3);color:gold;height:30px;border:0px;" name="parcelas">
						<option value="0">N/A</option>
					<?php for ($i=1;$i<=10;$i++) { ?>
						<option style="background-color:#20b2aa;" value="<?php echo $i; ?>"><?php echo $i; ?></option>
					<?php } ?>
					</select>
				</td>
				<td><input style="padding-left:5px;padding-right:5px;width:100px;background-color:rgba(0,100,100,0.3);color:gold;height:30px;border:0px;" type='number' step="any" name='txjuros' placeholder='0' /></td>
				<?php
				}
				?>
				<td><button style="background-color:#4169e1;height:32px;border:0px;width:100px;color:white;" name='buttonIncluir'>Incluir</button></td>
			</tr>
		</table>
	</form>
</div>
<?php } else { header("Location: ../"); } ?>