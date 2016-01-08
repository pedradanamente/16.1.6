<?php
class Loja {
	var $itens;
	
	function __construct() {
		$this -> itens["bermudas"] = 10;
	}
	
	function adiciona($codigo,$quantidade){
		if (isset($this -> itens[$codigo])) {
			$this -> itens[$codigo] += $quantidade;
		}
		else {
			$this -> itens[$codigo] = $quantidade;
		}
	}
	function remove($codigo,$quantidade) {
		if($itens[$codigo] > $quantidade) {
			$itens[$codigo] == $quantidade;
		}
		else {
			return false;
		}
	}
}
?>