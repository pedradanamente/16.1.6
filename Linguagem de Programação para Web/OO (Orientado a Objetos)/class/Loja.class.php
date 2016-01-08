<?php
class Loja {
	var $itens;
	
	public function __construct() {
		$this -> itens["bermudas"] = 10;
	}
	
	public function adiciona($codigo,$quantidade){
		if (isset($this -> itens[$codigo])) {
			$this -> itens[$codigo] += $quantidade;
		}
		else {
			$this -> itens[$codigo] = $quantidade;
		}
	}
	
	public function remove($codigo,$quantidade) {
		if(isset($this -> itens[$codigo]) >= $quantidade) {
			$this -> itens[$codigo] -= $quantidade;
		}
		else {
			return false;
		}
	}

}
?>